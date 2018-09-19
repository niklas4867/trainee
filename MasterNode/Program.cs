using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.CodeDom.Compiler;
using Microsoft.CSharp;
using System.Reflection;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Linq;
using System.Diagnostics;

namespace MasterNode
{
    public static class Program
    {
        static public Blockchain Bolis = new Blockchain();

        delegate void AddMessage(string message);
        static Random rnd = new Random();
        const int port = 54545;
        const string broadcastAddress = "255.255.255.255";
        static public int lastNumber;
        static public int lastNumber2;
        static UdpClient receivingClient;
        static UdpClient sendingClient;

        static List<int> numbers = new List<int>();
        static public int dif = 2;

        static Thread receivingThread;

        static CSharpCodeProvider provider = new CSharpCodeProvider(); //Code zu Maschinencode
        static CompilerParameters parameters = new CompilerParameters();


        static void Main(string[] args)
        {
            parameters.GenerateInMemory = true; //Code zu Maschinencode
            parameters.GenerateExecutable = true;

            InitializeSender();
            InitializeReceiver();

            Console.ReadKey();

        }

        static private void InitializeSender()

        {
            sendingClient = new UdpClient(broadcastAddress, port);
            sendingClient.EnableBroadcast = true;
        }

        static private void InitializeReceiver()
        {
            receivingClient = new UdpClient(port);

            ThreadStart start = new ThreadStart(Receiver);
            receivingThread = new Thread(start);
            receivingThread.IsBackground = true;
            receivingThread.Start();
        }


        static private void Receiver()
        {
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, port);
            AddMessage messageDelegate = MessageReceived;

            while (true)
            {
                byte[] data = receivingClient.Receive(ref endPoint);
                string message = Encoding.ASCII.GetString(data);
                messageDelegate(message);
            }
        }

        static private void MessageReceived(string message)
        {
            string x = message.Substring(message.Length - 4);
            if(x == Convert.ToString(lastNumber) || x == Convert.ToString(lastNumber2)) { return; }
            message = message.Substring(0, message.Length - 4);
#if DEBUG
            Console.WriteLine(message);
#endif
            ResponseMessage(message);
            
        }

        static void Send(string toSend)
        {
            lastNumber2 = lastNumber;
            lastNumber = rnd.Next(1000, 9999);
            toSend = toSend + Convert.ToString(lastNumber);
            byte[] data = Encoding.ASCII.GetBytes(toSend);
            sendingClient.Send(data, data.Length);
        }

        static public void ResponseMessage(string message) //Kompiliert Befehl zu Maschienen Code -- Macht keine änderungen!
        {

            string code = @"
    using System;

    namespace First
    {
        public class Program
        {
            public static void Main()
            {
            " +
                message
                + @"
            }
        }
    }
";
            string exePath = Assembly.GetExecutingAssembly().Location;
            string exeDir = Path.GetDirectoryName(exePath);

            AssemblyName[] assemRefs = Assembly.GetExecutingAssembly().GetReferencedAssemblies();
            List<string> references = new List<string>();

            foreach (AssemblyName assemblyName in assemRefs)
                references.Add(assemblyName.Name + ".dll");

            for (int i = 0; i < references.Count; i++)
            {
                string localName = Path.Combine(exeDir, references[i]);

                if (File.Exists(localName))
                    references[i] = localName;
            }

            references.Add(exePath);

            CompilerParameters compiler_parameters = new CompilerParameters(references.ToArray());
            try
            {
                CompilerResults results = provider.CompileAssemblyFromSource(compiler_parameters, code);
#if DEBUG
                if (results.Errors.HasErrors)
                {
                    StringBuilder builder = new StringBuilder();
                    foreach (CompilerError error in results.Errors)
                    {
                        builder.AppendLine(String.Format("Error ({0}): {1}", error.ErrorNumber, error.ErrorText));
                    }
                    Console.WriteLine(builder.ToString());
                }
#endif
                Assembly assembly = results.CompiledAssembly;
                Type program = assembly.GetType("First.Program");
                MethodInfo main = program.GetMethod("Main");
                main.Invoke(null, null);
            }
            catch {
#if DEBUG
                Console.WriteLine("Error");
#endif
            }

        }

        static public void CheckNr(int Nr,string wallet)
        {
            SHA256 sha256 = SHA256.Create();
            string Hash = Convert.ToBase64String(sha256.ComputeHash(Encoding.ASCII.GetBytes(Convert.ToString(Nr))));
#if DEBUG
            //Console.WriteLine($"{Hash.Substring(0, dif) == String.Concat(Enumerable.Repeat("0", dif))}, {numbers.IndexOf(Nr) == -1}, {0 <= Nr}, {Nr <= 999999999}");
#endif

            if (Hash.Substring(0, dif) == String.Concat(Enumerable.Repeat("0", dif)) && numbers.IndexOf(Nr) == -1 && 0 <= Nr && Nr <= 999999999)
            {
                numbers.Add(Nr);
                Console.WriteLine($"Block wurde von {wallet} abgebaut");
                Bolis.AddBlock(new Block(DateTime.Now, null, $"{{sender:\"MasterNode\",receiver:{wallet},amount:1}}"));
            }
            else
            {
                Console.WriteLine($"Block von {wallet} fehlgeschlagen");
            }
        }


    }
}
