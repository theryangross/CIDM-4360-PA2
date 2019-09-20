// Ryan Gross CIDM 4360

using System;

class tDate
{
    public static string earliestDate;
    public static string latestDate;
    int day;
    int month;
    int year;
    int mm;
    int dd;
    int yyyy;

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

    public void showDate(char ch)
    {
        
        switch (ch)
        {
            case 'U':
                Console.WriteLine("{0}/{1}/{2}", mm, dd, yyyy);
                break;
            case 'E':
                Console.WriteLine("{0}/{1}/{2}", dd, mm, yyyy);
                break;
        }
    }

    public void splitDate()
    {
        String[] eDate = earliestDate.Split('/');
        mm = int.Parse(eDate[0]);
        dd = int.Parse(eDate[1]);
        yyyy = int.Parse(eDate[2]);
    }
}