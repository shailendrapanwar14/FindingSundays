// Finding Sundays Using c#
using System;
namespace repliconinterview.shailendra
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Choose Program to Run 1: Finding Sundays Without Using Inbuild Library 2: Finding Sundays Using DateTime Library :");
            int key = Convert.ToInt32(Console.ReadLine());
           
            switch (key)
            {

                case 1:
                    {
                       var findingsundays = new FindingSundaysWithoutUsingLibrary();
                        findingsundays.Run();
                        break;
                    }
                case 2:
                    {
                       var findingsundays = new FindingSundaysUsingDateTimeLibrary();
                        findingsundays.Run();
                        break;
                    }
                default:
                    throw new ArgumentOutOfRangeException("Value out of range " + key.ToString());
            }
        }
    }
}
