﻿namespace CAAssemblies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var type = typeof(Program);
            var assembly = type.Assembly;

            //var stream = assembly.GetManifestResourceStream("CAAssemblies.data.countries.json");
            var stream = assembly.GetManifestResourceStream(type, "data.countries.json");
            var data = new BinaryReader(stream).ReadBytes((int)stream.Length);
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write((char)data[i]);
                System.Threading.Thread.Sleep(300);
            }
            stream.Close();
            Console.ReadKey();
        }
    }
}