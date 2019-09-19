// Ryan Gross CIDM 4360

using System;

class tDate
{
    static string earliestDate = "1/1/1900";
    static string latestDate = "12/31/2100";
    public int day;
    public int month;
    public int year;
    public int mm;
    public int dd;
    public int yyyy;

    public tDate(int month, int day, int year)
    {
        if ((0 < month && month <= 12) && (0 < day && day <= 31) && (year>0))
        {
            int mm = month;
            int dd = day;
            int yyyy = year;
        }
        else
        {
            splitDate();
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
            int mm = month;
            int dd = day;
            int yyyy = year;
        }
        else
        {
            splitDate();
        }
    }

    public void showDate (char ch)
    {
        
        switch (ch)
        {
            case 'U':
                Console.WriteLine("{0}/{1}/{3}", mm, dd, yyyy);
                break;
            case 'E':
                Console.WriteLine("{0}/{1}/{3}", dd, mm, yyyy);
                break;
        }
    }

    public void splitDate ()
    {
          String[] eDate = earliestDate.Split("/");
            int earlyMonth = int.Parse(eDate[0]);
            int earlyDay = int.Parse(eDate[1]);
            int earlyYear = int.Parse(eDate[2]);
            Console.WriteLine("{0}/{1}/{2}", earlyMonth, earlyDay, earlyYear);
    }
}