using System;
namespace app
{
    class Program
    {
        static void Main(string[]arg)
        {
            for(int i=1; i<=10;i++)
            {
                if(i==5)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }
    }
}