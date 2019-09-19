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
        if ((month > 0 && month <= 12) && (day > 0 && day <= 31) && (year > 0))
        {
            mm = month;
            dd = day;
            yyyy = year;
        }
        else
        {
            splitDate();
        }
    }

    public tDate(string Date)
    {
        String[] DateObject = Date.Split("/");
        month = int.Parse(DateObject[0]);
        day = int.Parse(DateObject[1]);
        year = int.Parse(DateObject[2]);

        if ((month > 0 && month <= 12) && (day > 0 && day <= 31) && (year>0))
        {
            mm = month;
            dd = day;
            yyyy = year;
        }
        else
        {
            splitDate();
        }
    }

    public void showDate (char f)
    {
        
        switch (f)
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