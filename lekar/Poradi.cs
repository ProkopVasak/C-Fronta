using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lekar
{
    internal class Poradi
    {
        private static Queue<int> numbers = new Queue<int>();
        public static int Customer()
        {
            Random random = new Random();
            int num = int.Parse(random.Next(0, 9).ToString() + random.Next(0, 9).ToString() + random.Next(0, 9).ToString());
            do { 
                num = int.Parse(random.Next(0, 9).ToString() + random.Next(0, 9).ToString() + random.Next(0, 9).ToString());

            }while(numbers.Contains(num));
            numbers.Enqueue(num);
            //Console.WriteLine("Zapsané číslo = "+ num); //test
            return num;
        }
        public static int CustomerCount()
        {
            return numbers.Count;
        }
        public static void NextCustomer()
        {
            if (CustomerCount() > 0)
            {
                
                if (numbers.Peek() < 100) Console.WriteLine("0" + numbers.Dequeue() as string);
                else Console.WriteLine(numbers.Dequeue());
            }
            else Console.WriteLine("Fronta je prázdná");
        }
    }
}
