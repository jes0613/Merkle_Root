using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Merkle_Root
{
    class Program
    {
        static void Main(string[] args)
        {
            string tx1Hash = "aad28e85f31ae79339b49d114d7c1811d2c667681a1904ebbc326842a0a81985";
            string tx2Hash = "b963d3426088217357b146d5600817c54f93c2ea1a23126988e36460015ffc0e";
            string tx3Hash = "82498f4da1e1b662b02e95150dc9fd64307ee96b35657f75c7abd82530168ce3";
            string tx4Hash = "ceecfd37686a3ed1759d3cef25e412a800fc8e8846154dbe2a2d72b2af3e3b64";

            string tx12 = tx1Hash + tx2Hash;
            byte[] tx12bytes = Encoding.ASCII.GetBytes(tx12);
            byte[] tx12hashbytes = Encoding.ASCII.GetBytes(BitConverter.ToString(SHA256.Create().ComputeHash(tx12bytes)).Replace("-", "").ToLower());
            string tx12hash = BitConverter.ToString(SHA256.Create().ComputeHash(tx12hashbytes)).Replace("-", "").ToLower();
            Console.WriteLine("First two: " + tx12hash);
            string tx34 = tx3Hash + tx4Hash;
            byte[] tx34bytes = Encoding.ASCII.GetBytes(tx34);
            byte[] tx34hashbytes = Encoding.ASCII.GetBytes(BitConverter.ToString(SHA256.Create().ComputeHash(tx34bytes)).Replace("-", "").ToLower());
            string tx34hash = BitConverter.ToString(SHA256.Create().ComputeHash(tx34hashbytes)).Replace("-", "").ToLower();
            Console.WriteLine("First two: " + tx34hash);
            string tx1234 = tx12hash + tx34hash;
            byte[] tx1234bytes = Encoding.ASCII.GetBytes(tx1234);
            byte[] tx1234hashbytes = Encoding.ASCII.GetBytes(BitConverter.ToString(SHA256.Create().ComputeHash(tx1234bytes)).Replace("-", "").ToLower());
            string tx1234hash = BitConverter.ToString(SHA256.Create().ComputeHash(tx1234hashbytes)).Replace("-", "").ToLower();

            Console.WriteLine("Final: " + tx1234hash);
        }
    }
}
