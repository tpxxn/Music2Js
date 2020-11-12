using System;
using System.IO;

namespace Music2Js
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 1)
            {
                string xmlFilePath = args[0];
                Console.WriteLine("xmlFilePath = " + xmlFilePath);
                string content = string.Empty;
                try
                {
                    using (StreamReader sr = new StreamReader(xmlFilePath))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            content += line;
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("文件无法读取:");
                    Console.WriteLine(e.Message);
                }
                MusicXml musicXml = XMLConvert.GetT<MusicXml>(content);
                Console.WriteLine("");
            }
        }
    }
}
