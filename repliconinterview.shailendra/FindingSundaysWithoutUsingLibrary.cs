


using System;
namespace repliconinterview.shailendra
{
    class FindingSundaysWithoutUsingLibrary
    {
        public void Run()
        {
            Console.WriteLine("Counting of sundays in 20th century January Month :->\n");
            SundaysInJanuary();
            Console.ReadKey();
        }
        int GetDays(int month, int year) // this function for checking days in every month but i am not using it, because we don't want every month data
            {
                switch (month)
                {
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        return 30;
                    case 2:
                        return (IsLeapYear(year)) ? 29 : 28;

                }
                return 31;
            }

            Boolean IsLeapYear(int year) //logic for leap year
            {
                Boolean leap = false;
                if (year % 4 == 0)
                {
                    if (year % 100 == 0)
                    {
                        leap = (year % 400 == 0) ? true : false;
                    }
                    else
                    {
                        leap = true;
                    }
                }
                return leap;
            }
        public void FindingRemainders(ref int firstdateofsunday) // pass by reference 
        {
            if (firstdateofsunday == 0) // because we have only 7 days in a week so it will iterate again from sunday
            {
                firstdateofsunday= 7;
            }
            else if (firstdateofsunday == -1) 
            {
                firstdateofsunday= 6;
            }
            
        }
        public void SundayInAMonth(ref int totalsundayinjan, ref int firstdateofsunday) //again pass by ref, because we need updated value which will be holded back to calling function
        {
            if (firstdateofsunday <= 3)
                totalsundayinjan = 5;
            else
                totalsundayinjan = 4;
        }
           
            void SundaysInJanuary()
            {
                // Sun:1 Mon: 2 ...
                int firstdateofsunday = 6;     // 1 Jan 1901 was Tuesday so first sunday on 6th
                Boolean countleapyear = false;  //this condition for checking previous year is leapyear or not
                int totalsundayinjan = 0;      //taking initial count of sunday in jan
                Console.WriteLine("4 Sundays were accounted in January 1901 \n"); //because first sunday is on 6th so we know there can be maximum 4 sunday in jan
                int startyear = 1902;
                int endyear = 2000;
                int centuryofsundayinjan = 4;    // counting total sunday falls in 20th century on january month and 4 is already printed so we assigned intial value as a 4
       for (int i = startyear; i <= endyear; i++)    // now printing sunday from 1902
           {
                     if (!IsLeapYear(i))   //condition to check leap year or not
                    {
                        if (countleapyear)  //this condition is checking for previous year if last year was leap it means there is 2 odd days
                        {
                            countleapyear = false;
                        firstdateofsunday -= 2;    // leap year has 2 odd days
                        FindingRemainders(ref firstdateofsunday);
                        SundayInAMonth(ref totalsundayinjan, ref firstdateofsunday);

                        }
                        else
                        {
                        firstdateofsunday -= 1;    // it is not leap year so that 1 odd days
                        FindingRemainders(ref firstdateofsunday);
                        SundayInAMonth(ref totalsundayinjan, ref firstdateofsunday);
                        }

                  }

            else    // if leap year control will come here
               {

                    firstdateofsunday -= 1;    //here i am doing -1 because jan comes before feb so the odd days will remain same for this month it will added after next year jan month of after leap year
                        countleapyear = true;   // here i am declaring a leap year so it will help us in next year because next year we have 2 odd days
                    FindingRemainders(ref firstdateofsunday);
                    SundayInAMonth(ref totalsundayinjan, ref firstdateofsunday);
                 }
                    Console.WriteLine( totalsundayinjan + " Sundays were accounted in January " +i +"\n");
                    centuryofsundayinjan += totalsundayinjan;
          }
            Console.WriteLine("Total "+ centuryofsundayinjan + " Sundays were accounted in 20th century of january month"); 
        }
        }

    }
