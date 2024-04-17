class Program
{
    static void Main(string[] args)
    {
        var parser = new CSVParser();
        parser.Parse(@"C:\Users\Tika Khadka\Desktop\git\Assignment 01\People.csv");
        parser.PrintNames();
    }

}