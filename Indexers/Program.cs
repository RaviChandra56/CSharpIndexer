using System;

namespace Indexers
{
    partial class Program
    {
        static void Main(string[] args)
        {
            HttpCookie cookie = new HttpCookie();
            cookie["name"] = "Ravi";
            Console.WriteLine(cookie["name"]);
            Console.ReadLine();
        }
    }
}
