// Ryan Gross CIDM 4360

using System;

class tDate
{
    static string earliestDate = "1/1/1900";
    static string latestDate = "12/31/2100";
    public int day;
    public int month;
    public int year;
    char ch;

    public tDate(int month, int day, int year)
    {
        if ((0 < month && month <= 12) && (0 < day && day <= 31) && (year>0))
        {
            Console.WriteLine("{0}/{1}/{2}", month, day, year);
        }
        else
        {
            String[] eDate = earliestDate.Split("/");
            int earlyMonth = int.Parse(eDate[0]);
            int earlyDay = int.Parse(eDate[1]);
            int earlyYear = int.Parse(eDate[2]);
            Console.WriteLine("{0}/{1}/{2}", earlyMonth, earlyDay, earlyYear);
        }
    }

    public tDate(string Date)
    {
        String[] DateObject = Date.Split("/");
        int month = int.Parse(DateObject[0]);
        int day = int.Parse(DateObject[1]);
        int year = int.Parse(DateObject[2]);

        if ((0 < month && month <= 12) && (0 < day && day <= 31) && (year>0))
        {
            Console.WriteLine("{0}/{1}/{2}", month, day, year);
        }
        else
        {
            String[] eDate = earliestDate.Split("/");
            int earlyMonth = int.Parse(eDate[0]);
            int earlyDay = int.Parse(eDate[1]);
            int earlyYear = int.Parse(eDate[2]);
            Console.WriteLine("{0}/{1}/{2}", earlyMonth, earlyDay, earlyYear);
        }
    }

    public void showDate (char ch)
    {
        ch = Convert.ToChar(Console.ReadLine());
        
        switch (ch)
        {
            case 'U':
                Console.WriteLine("{0}/{1}/{3}", month, day, year);
                break;
            case 'E':
                Console.WriteLine("{0}/{1}/{3}", day, month, year);
                break;
        }
    }
}