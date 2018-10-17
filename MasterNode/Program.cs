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
using System.Diagnostics;

namespace MasterNode
{
    public static class Program
    {
        static public Blockchain Bolis = new Blockchain();
        static List<int> numbers = new List<int>();
        static public int dif = 3;
        static int sek = 0;
        static public string returnCode = "";

        static CSharpCodeProvider provider = new CSharpCodeProvider(); //Code zu Maschinencode
        static CompilerParameters parameters = new CompilerParameters();
        static P2P p2p = new P2P("192.168.81.255"); //P2P

        static void Main(string[] args)
        {
            Console.ReadKey();
        }

        static public string RealtimeCompiler(string Command) //Kompiliert Befehl zu Maschienen Code
        {
            if(Command.Substring(Command.Length-1) != ";")
            {
                Command = "MasterNode.Program.returnCode = Convert.ToString(" + Command + ");";
            }
            
            string code = @"
    using MasterNode;
    using System;

    namespace First
    {
        public class Program
        {
            public static void Main()
            {
                "+Command+@"  
                        
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
            return returnCode;

        }

        static public void ResponseMessage(string message)
        {
            string x = RealtimeCompiler(message);
            if(x != "") { p2p.Send(x); }
            
        }
    }
}
