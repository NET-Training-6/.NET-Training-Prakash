// class MethodLearner
// {
//     //Methos that returns nothing and takes no arguments
//     public void Print()
//     {
//         Console.WriteLine("Hello World");
//         Console.WriteLine("I'm Here");
//     }

//     //Method that returns nothing takes some argument(s)

//     public void PrintMessage(string message)
//     {
//         Console.WriteLine("Hello World");
//         Console.WriteLine("Message");


//     }

//     //Method that returns something and takes some argument(s)

//     public double Sum(double a, double b)
//     {
//         var s = a + b;
//         return s;
//     }

//     //Write a method takes number as a argument and 
//     // returns if number is even or odd


//     public bool isEven(int number)

//     {
//         if (number % 2 == 0)
//             return true;
//         else
//             return false;


//     }


// public double CalculateAverage(int num1, int num2, int num3 =0)
// {
//     var Sum = num1 + num1 + num3;
//     var average = Sum / 3;
//     return average;
// }

// //Write a method that takes an number array and returns average of those.

// public double CalculateAverage(int[] numbers)
// {
//     var Sum = 0;

// }

// Var average = sum



// }





// Write a method that takes bunch of numbers and returns minimum among them.


// Write 
class MethodLearner
{
    // 1. Method that returns nothing and takes no arguments
    public void Print()
    {
        Console.WriteLine("Hello There!");
        Console.WriteLine("I am inside simplest possible method");
    }

    // 2. Method that returns nothing and takes some argument(s)
    public void Print(string message)
    {
        Console.WriteLine("Hello There!");
        Console.WriteLine(message);
    }

    // 3. Method that returns something and takes some argument(s)
    public double Sum(double a, double b)
    {
        var s = a + b;
        return s;
    }

    // 4. Optional arguments
    public double CalculateAverage(int num1, int num2, int num3 = 0)
    {
        var sum = num1 + num2 + num3;
        var average = sum / 3;
        return average;
    }    

    // 5. Method that returns multiple values
    public (int, int) GetSumAndProduct(byte n1, byte n2)    // Tuple
    {
        var s = n1 + n2;
        var p = n1 * n2;
        return (s, p);
    }

    // 6. Expression bodied member
    public double Product(double a, double b) => a * b;
}