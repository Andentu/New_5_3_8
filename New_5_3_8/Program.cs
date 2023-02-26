namespace New_5_3_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num = 5;
            GetArrayFromConsole(ref num);
            Console.WriteLine(num);
            
        }
        static void GetArrayFromConsole (ref int num2)
        {
            num2++;
            var arr = new int [num2];
        }
    }
}