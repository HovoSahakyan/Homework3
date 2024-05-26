namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intq;
            string strj = "56";
            bool b1 = int.TryParse(strj, out intq);
            string strh = "whatever";
            bool b2 = int.TryParse(strh, out intq);

            Console.WriteLine($"can parse: {b1}");
            Console.WriteLine(strj);
            Console.WriteLine($"can parse: {b2}");
            Console.WriteLine(strh);
        }
    }
}
