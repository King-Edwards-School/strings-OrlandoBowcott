using System.Runtime.InteropServices;

class Program()
{
static void Main()
{
        Console.WriteLine("please enter a string"); string userstring =  Console.ReadLine(); int sumascii = 0;  for (int i = 0; i < userstring.Length; i++) { sumascii += userstring[i]}; if(sumascii < 600 && sumascii > 420){ Console.WriteLine("you string is valid") };
}
}