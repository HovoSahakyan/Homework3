namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double d1 = 5.64;
            Console.WriteLine($"double = {d1}");
            int int1 = (int)d1;
            Console.WriteLine($"double to int = {int1}");

            int int2 = 6;
            Console.WriteLine($"int = {int2}");
            decimal dec1 = int2;
            Console.WriteLine($"int to decimal = {dec1}");

            decimal dec2 = 6.43m;
            Console.WriteLine($"decimal = {dec2}");
            int int3 = (int)dec2;
            Console.WriteLine($"decimal to int {int3}");

            decimal dec3 = 3.34566m;
            Console.WriteLine($" decimal = {dec3}");
            float fl1 = (float)dec3;
            Console.WriteLine($"decimal to float = {fl1}"); 

        }
    }
}
