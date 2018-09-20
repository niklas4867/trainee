using System;
using System.Text;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Linq;
using System.Reflection;
using System.IO;
using System.CodeDom.Compiler;
using Microsoft.CSharp;
using System.Threading;

namespace MasterNode
{
    public static class Program
    {
        static public Blockchain Bolis = new Blockchain();
        private static System.Timers.Timer Timer;
        static List<int> numbers = new List<int>();
        static public int dif = 3;
        static int sek = 0;

        static CSharpCodeProvider provider = new CSharpCodeProvider(); //Code zu Maschinencode
        static CompilerParameters parameters = new CompilerParameters();
        static P2P p2p = new P2P();

        static void Main(string[] args)
        {
            ThreadStart getdif = new ThreadStart(SetDif); //Erstelle neuen Thread (GETDIF)
            Thread dif = new Thread(getdif);
            dif.Start();
            Console.ReadKey();
        }

        static public void RealtimeCompiler(string Command) //Kompiliert Befehl zu Maschienen Code -- Macht keine änderungen!
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
                Command
                + @"
            }
        }
    }
";
            parameters.GenerateInMemory = true; //Code zu Maschinencode
            parameters.GenerateExecutable = true;
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
            catch
            {
#if DEBUG
                Console.WriteLine("Error");
#endif
            }

        }


        static public void CheckNr(int Nr, string wallet)
        {
            Timer.Stop();
            SHA256 sha256 = SHA256.Create();
            string Hash = Convert.ToBase64String(sha256.ComputeHash(Encoding.ASCII.GetBytes(Convert.ToString(Nr))));
#if DEBUG
            Console.WriteLine(Hash.Substring(0, dif));
            Console.WriteLine($"{Hash.Substring(0, dif) == String.Concat(Enumerable.Repeat("0", dif))}, {numbers.IndexOf(Nr) == -1}, {0 <= Nr}, {Nr <= 999999999}");
#endif

            if (Hash.Substring(0, dif) == String.Concat(Enumerable.Repeat("0", dif)) && numbers.IndexOf(Nr) == -1 && 0 <= Nr && Nr <= 999999999)
            {
                numbers.Add(Nr);
                Console.WriteLine($"Block wurde von {wallet} abgebaut");
                Bolis.AddBlock(new Block(DateTime.Now, null, $"{{sender:\"MasterNode\",receiver:{wallet},amount:1}}"));
                if(sek > 60) { dif++; }
                else if (sek < 60) { dif--; }
                sek = 0;
            }
            else
            {
                Console.WriteLine($"Block von {wallet} fehlgeschlagen");
            }
        }



        static public void ResponseMessage(string message) //Kompiliert Befehl zu Maschienen Code -- Macht keine änderungen!
        {
            RealtimeCompiler(message);
        }

        static public void SetDif()
        {
            while (true)
            {
                p2p.Send("SetDif" + dif);
                Thread.Sleep(4990);
                sek = sek + 5;
            }
        }
    }
}
