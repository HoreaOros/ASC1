using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;

namespace Linker
{
    class Program
    {
        struct Module
        {
            public Dictionary<string, int> definitionList;
            public Dictionary<string, int> useList;
            public List<int> programText;
            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                foreach (var item in definitionList)
                {
                    sb.Append(item.Key);
                    sb.Append(" ");
                    sb.Append(item.Value);
                    sb.Append(" ");
                }
                sb.Append(Environment.NewLine);

                foreach (var item in useList)
                {
                    sb.Append(item.Key);
                    sb.Append(" ");
                    sb.Append(item.Value);
                    sb.Append(" ");
                }
                sb.Append(Environment.NewLine);
                foreach (var item in programText)
                {
                    sb.Append(item);
                    sb.Append(" ");
                }
                sb.Append(Environment.NewLine);
                return sb.ToString();
            }
            
        }
        static void Main(string[] args)
        {

            try
            {
                StreamReader sr = new StreamReader(args[0]);

                string fileContent = sr.ReadToEnd();

               


                int noModules;
                char[] sep = {' ', '\t', '\n'};

                string[] tokens = fileContent.Split(sep, 2, StringSplitOptions.RemoveEmptyEntries);

                noModules = int.Parse(tokens[0]);
                fileContent = tokens[1];

                //Console.WriteLine(noModules);
                //Console.WriteLine(fileContent);

                List<Module> modules = new List<Module>(noModules);
                int noDef, noUses, noText;
                for (int i = 0; i < noModules; i++)
                {
                    Module m = new Module();


                    //Definitions;
                    tokens = fileContent.Split(sep, 2, StringSplitOptions.RemoveEmptyEntries);

                    noDef = int.Parse(tokens[0]);
                    fileContent = tokens[1];

                    m.definitionList = new Dictionary<string, int>();

                    tokens = fileContent.Split(sep, 2 * noDef + 1, StringSplitOptions.RemoveEmptyEntries);

                    for (int j = 0; j < noDef; j++)
                    {
                        m.definitionList.Add(tokens[2 * j], int.Parse(tokens[2 * j + 1]));
                    }
                    fileContent = tokens[tokens.Length - 1];


                    // Uses
                    tokens = fileContent.Split(sep, 2, StringSplitOptions.RemoveEmptyEntries);

                    noUses = int.Parse(tokens[0]);
                    fileContent = tokens[1];

                    m.useList = new Dictionary<string, int>();

                    tokens = fileContent.Split(sep, 2 * noUses + 1, StringSplitOptions.RemoveEmptyEntries);

                    
                    for (int j = 0; j < noUses; j++)
                    {
                        m.useList.Add(tokens[2 * j], int.Parse(tokens[2 * j + 1]));
                    }
                    fileContent = tokens[tokens.Length - 1];


                    // Program text;
                    tokens = fileContent.Split(sep, 2, StringSplitOptions.RemoveEmptyEntries);

                    noText = int.Parse(tokens[0]);
                    fileContent = tokens[1];

                    m.programText = new List<int>(noText);

                    tokens = fileContent.Split(sep, noText + 1, StringSplitOptions.RemoveEmptyEntries);

                   
                    for (int j = 0; j < noText; j++)
                    {
                        m.programText.Add(int.Parse(tokens[j]));
                    }
                    fileContent = tokens[tokens.Length - 1];

                    modules.Add(m);
                }

                foreach (var item in modules)
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            

        }
    }
}
