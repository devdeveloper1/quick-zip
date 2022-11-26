using System;
using System.IO.Compression;

namespace qzip
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                try
                {
                    //Console.WriteLine(args[0]);

                    if (args[0].EndsWith(".zip"))
                    {
                        String arg = args[0].Replace("C:", "");
                        arg = arg.Replace("\\", "/");
                        String path = arg;
                        String removed = path.Remove(path.LastIndexOf("/"));
                        String d = path.Substring(removed.Length);
                        String b = d.Replace(".zip", "");
                        String a = b.Replace("/", "");


                        Console.WriteLine(a);

                        //Console.WriteLine(path.LastIndexOf(".zip"));
                        //Console.WriteLine(path.Substring(path.LastIndexOf("/"), path.LastIndexOf(".zip")));


                        ZipFile.ExtractToDirectory(args[0], String.Format("./{0}", a));
                        break;
                    }
                }
                catch (System.Exception e)
                {
                    Console.WriteLine(e);

                }



            }


        }
    }
}
