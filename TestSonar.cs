using System;
namespace HelloWorld
{
    class Hello 
    { 
		int a;
        static void Main() 
        {
            Console.WriteLine("Hello World!");

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
			a =+ 10;
            Console.ReadKey();
        }
    }
}