using System;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> myList = new MyList<string>();
            myList.Add("burak");

            Console.WriteLine(myList.Length);
            myList.Add("melisa");

            Console.WriteLine(myList.Length);

            foreach (var item in myList.Items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
