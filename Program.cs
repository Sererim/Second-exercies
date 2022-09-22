using System;


int Main()
{
    string load = "LOAD";
    int key = 0;
    Console.WriteLine("Program is starting. Please wait.");
    while(true)
    {
        Console.WriteLine("Enter 1 to find the second number in a number string.\n" +
        "Enter 2 to find the third number in a number string\n" +
        "Enter 3 to find if a specify date of the week is a weekend or not.\n" +
        "Enter 0 to terminate a program.");

        load = Console.ReadLine();
        key = System.Int32.Parse(load);
        switch(key)
        {
            case 1:
                load = homework.GetValue();
                homework.SecondNum(load);
                break;
            case 2:
                load = homework.GetValue();
                homework.ThirdNum(load);
                break;
            case 3:
                load = homework.GetValue();
                homework.WeekEnd(load);
                break;
            case 0:
                Console.WriteLine("Program is being terminated.");
                return 0;


            default:
                break;
        } 


    }
}
Main();
return 0;


class homework
{
    static public string GetValue()
    {
        string load = "NULL";
        Console.WriteLine("Enter a number.");
        load = Console.ReadLine();
        return load;
    }

    unsafe static public void SecondNum(string load = "LOAD")
    {
        if(load.Length >= 2)
            Console.WriteLine($"Second number is {load[1]}");
        else
            Console.WriteLine("ERROR: Number is shorter than needed.\nExample: 10 second number is 0.");
    }

    unsafe static public void ThirdNum(string load = "LOAD")
    {
        if(load.Length >= 3)
            Console.WriteLine($"Third number is {load[2]}");
        else
            Console.WriteLine("ERROR: Number is shorter than needed.\nExample: 123 third number is 3.");
    }

    static public void WeekEnd(string load = "LOAD")
    {
        switch(load)
        {
            case "1":
                Console.WriteLine($"Entered date {load} is not a weekend.");
                break;
                
            case "2":
                Console.WriteLine($"Entered date {load} is not a weekend.");
                break;
                
            case "3":
                Console.WriteLine($"Entered date {load} is not a weekend.");
                break;
                
            case "4":
                Console.WriteLine($"Entered date {load} is not a weekend.");
                break;
                
            case "5":
                Console.WriteLine($"Entered date {load} is not a weekend.");
                break;
                
            case "6":
                Console.WriteLine($"Entered date {load} is a weekend.");
                break;
                
            case "7":
                Console.WriteLine($"Entered date {load} is a weekend.");
                break;

            default:
                Console.WriteLine("ERROR: Incorrect number is given.");
                break;
        }
    }
}