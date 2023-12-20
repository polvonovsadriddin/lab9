try
{
    Console.Write("Введите день месяца: ");
    int day = int.Parse(Console.ReadLine());
    Console.Write("Введите  месяц: ");
    int month = int.Parse(Console.ReadLine());
    Console.Write("Введите год: ");
    int year = int .Parse(Console.ReadLine());

    Leap leap = new Leap(day,  month, year);
    Console.WriteLine(leap.isleap());
    Console.WriteLine(leap.Add());
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);

}




class Leap
{
    private int  date;
    private int  month;
    private int  year;
    public int  Date
    {
        get { return date; }
        set {if (date>0) date = value+5; }

    }
    public int  Month
    {
        get { return month; }
        set { month = value; }

    }
    public int  Year
    {
        get { return year; }
        set { year = value; }
    }


    public Leap(int  date, int month, int  year)
    {
        this.date = date;
        this.month = month;
        this.year = year;
    }
   public  string isleap () 
    {
        if (year % 4 == 0) return ($"{date}.{month}.{year} Это высокосный год");
        else return ($"{date}.{month}.{year} Это не высокосный год");
    }
    public string Add()
    {
        if (date>0)  date= date+5;
        return ($"{ date}.{month}.{year}");
       
    }

}





























































        
    
