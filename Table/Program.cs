using System;

namespace Table
{
    class Table
    {
        //method declaration
        public void table(int num)
        {
            int i, t, j;
            for (j = 1; j <= 10; j++)
            {
                for (i = num; i <= num + 3; i++)  
                {
                    t = i * j;
                    Console.Write("{0}*{1}={2}\t", i, j, t);
                }
                Console.WriteLine();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Table obj = new Table();
            Console.WriteLine("Enter The Number");
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            obj.table(n);
        }
    }
}
