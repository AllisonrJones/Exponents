//promt the user to enter int
// display a table of squares and cubes from 1 to the value entered
//promt user to continue

//application should continue only if user agrees to
// /t to line up colomns properly
//right align number in colums instead of left (formatted strings)
//max cube int

   bool repeat = true;

do { 
    Console.WriteLine("Please enter a number 1-1290");
    int input = int.Parse(Console.ReadLine());

    if (input < 0 && input > 1290)
        {
            Console.WriteLine("Please enter a valid number");
            Console.ReadLine();
        }
    if (input > 0)
    {
        Console.WriteLine("Value\tSquared\tCubed");

        for (int i = 1; i <= input; i++)
        {

            string table= (String.Format("{0,8}{1,8}{2,8}", i, squareNumber((i)), cubedNumber((i))));
            Console.WriteLine(table);
        }

        Console.WriteLine("Would you like to enter another number? 'yes' or 'quit'");
        string response = Console.ReadLine();

      
        if (response == "yes")
        {
            repeat = true;
        }

        else
        {
            repeat = false;
            Console.WriteLine("Not a workable number, Goodbye");
            break;
        }
    }

} while (true);
    


    static int squareNumber(int input)
    {
        return input * input;
    }
  
    static int cubedNumber(int input)
    {
        return input * input * input;
    }


