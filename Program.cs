using System;

namespace homeworktask1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 2, m = 90, i, count = 0;


            for (i = n; i <= m; i++)
            {

                if (i % 7 == 0)



                    count++;
            }

            Console.WriteLine(count);

        }
    }
}
