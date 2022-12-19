class EntryPoint
{
    public static void Main()
    {
        // // Numbers: integers and floating point
        // // Integers
        // byte a = 255; // Unsigned - positive values only 0-255
        // short b = -2323;
        // int c = -4242424;
        // long d = 3223242425;

        // // Floating points
        // float e = 345.6742342423424242342f;
        // double f = 355335.445453790823798027498;
        // decimal g = 35324526.352344242423245243523525252m;

        // // Text
        // string name = "Prakash Saud";
        // char gender = 'M';

        // // Boolean
        // bool areYouMale = true;
        // bool? sex = null; // true => Male, false => Female, null => Others

        //         Console.WriteLine("Learn About Variables");
        //         Console.WriteLine(a);
        //         Console.WriteLine(b);
        //         Console.WriteLine(c);
        //         Console.WriteLine(d);
        //         Console.WriteLine(e);
        //         Console.WriteLine(f);
        //         Console.WriteLine(g);
        //         Console.WriteLine(name);
        //         Console.WriteLine(gender);
        //         Console.WriteLine(areYouMale);



        //     }
        // }

        //         var input = Console.ReadLine();
        //         var number = int.Parse(input);

        //         if (number % 2 == 0)
        //         {
        //             Console.WriteLine(number + " is even");
        //         }
        //         else
        //         {
        //             Console.WriteLine(number + " is odd");

        // Cw - Find simple interest for principal amount, time and rate given by user.

        Console.WriteLine("principal amount");
        int amount = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a time period");
        int time_period = int.Parse(Console.ReadLine());
        Console.WriteLine("interest rate");
        int interestrate = int.Parse(Console.ReadLine());
        int simple_interest = amount * time_period * interestrate / 100;
        Console.WriteLine("The simple interest =" + simple_interest);
        Console.ReadLine();
    }
    }


    







//             Console.ReadKey();

//         }
//     }
// }







