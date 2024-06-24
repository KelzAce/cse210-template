using System;

class Program
{
    static void Main(string[] args)
    {
        string prompty = "Keep track of your day by writing a Journal. ";
        Console.WriteLine(prompty);


            Console.Write("Write your Journal >>: ");
            string enteredText = Console.ReadLine();
            
            Entry prompt1 = new Entry();
            prompt1._date = "2012";
            prompt1._promptedText = prompty;
            prompt1._entryText = enteredText;   //  "I worked entremly hard today and i must salute myself";
            
            
            Entry prompt2 = new Entry();
            prompt2._date = "2020";
            prompt2._entryText = enteredText;
            prompt2._promptedText = prompty;

            Console.WriteLine($"{prompt1._date}");
            Console.WriteLine($"{prompt1._entryText}");

        // while (prompty)
        // {
            
        //     Console.WriteLine(prompty); 
        // }

    }

}