using System;
using System.IO;

namespace ByteIO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stream stream = File.OpenWrite("secret.bt");

            //using (BinaryWriter bw = new BinaryWriter(stream))
            //{

            //    bw.Write(413.56);
            //    bw.Write('a');
            //    bw.Write(56);
            //}

            Stream stream = File.OpenRead("secret.bt");

            using(BinaryReader br = new BinaryReader(stream))
            {
                Console.WriteLine(br.ReadDouble());
                Console.WriteLine(br.ReadChar());
                Console.WriteLine(br.ReadInt16());
            }

        }
    }
}
