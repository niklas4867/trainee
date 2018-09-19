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

namespace MasterNode
{
    public static class Program
    {
        delegate void AddMessage(string message);
        static Random rnd = new Random();
        const int port = 54545;
        const string broadcastAddress = "255.255.255.255";
        static public int lastNumber;
        static public int lastNumber2;
        static UdpClient receivingClient;
        static UdpClient sendingClient;

        static Thread receivingThread;
        static CSharpCodeProvider provider = new CSharpCodeProvider();
        static CompilerParameters parameters = new CompilerParameters();


        static void Main(string[] args)
        {
            parameters.GenerateInMemory = true;
            parameters.GenerateExecutable = true;

            InitializeSender();
            InitializeReceiver();

            ResponseMessage(@"MasterNode.Program.CheckNr(12, ""Merlin"");");

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
        
        public void CheckNr(int Nr,string wallet)
        {
            Console.WriteLine(""HHHHHHHHH"");
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
            Console.WriteLine("HHHHHHHHH");
        }


    }
}
