class ConditionalLearner
{
 
    // Ask user to enter his total

    void Task1()
    {
        Console.WriteLine("Enter your total percentage:");
        var markText = Console.ReadLine();
        var totalMarks = double.Parse(markText);
        if (totalMarks < 60)
        {
            Console.WriteLine("You passed with second division");
        }
       else if (totalMarks > 60 && totalMarks < 80)
        {
            Console.WriteLine("You passed with first division");
        }
        else if (totalMarks > 80)
        {
Console.WriteLine("You passed with distictiom");
        }
    } 
}