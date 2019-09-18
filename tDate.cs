// Ryan Gross CIDM 4360

using System;

class tDate
{
    static string earliestDate = "1/1/1900";
    static string latestDate = "12/31/2100";
    public int day;
    public int month;
    public int year;

    public tDate(int mm, int dd, int yyyy)
    {
        if ((0 < mm && mm <= 12) && (0 < dd && dd <= 31) && (yyyy>0))
        {
            Console.WriteLine("{0}/{1}/{2}", mm, dd, yyyy);
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
        int Month = int.Parse(DateObject[0]);
        int Day = int.Parse(DateObject[1]);
        int Year = int.Parse(DateObject[2]);

        if ((0 < Month && Month <= 12) && (0 < Day && Day <= 31) && (Year>0))
        {
            Console.WriteLine("{0}/{1}/{2}", Month, Day, Year);
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

    public void showDate (char U, char E)
    {
        switch ()
        {
            case 'U':
                Console.WriteLine("", );
                break;
            case 'E':
                break;
        }
    }
}