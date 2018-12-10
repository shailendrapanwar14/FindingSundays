using System;

namespace repliconinterview.shailendra
{
    class FindingSundaysUsingDateTimeLibrary
    {
        public void Run()
        {
            Console.WriteLine("Counting of sundays in 20th century January Month :->\n");
            var endyear = 2000;
            var startyear = 1901;
            int centuryofsundayinjan = 0;//intial count
            int totaldaysinjan = 31;
            for (int year = startyear; year <= endyear; year++)
            {
                var result = 0;
                for (int date = 1; date <= totaldaysinjan; date++)
                {
                    if (new DateTime(year, 1, date).DayOfWeek == DayOfWeek.Sunday)
                    {
                        result++;
                    }
                }
                Console.WriteLine(result +" Sundays were accounted in January "+ year +"\n");
                centuryofsundayinjan += result;
                
            }
            Console.WriteLine("Total "+ centuryofsundayinjan + " Sundays were accounted in 20th century of january month");
            Console.ReadKey();
        }
    }
}
