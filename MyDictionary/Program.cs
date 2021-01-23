using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> books = new MyDictionary<string, string>();
            books.Add("1","Şeker Portakalı");
            books.Add("2", "Körlük");
            books.Add("3", "İncir Kuşları");
            books.Add("4", "Suç ve Ceza");
            books.GetList();

        }
    }
}
