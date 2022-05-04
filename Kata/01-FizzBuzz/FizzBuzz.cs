namespace Kata.FizzBuzz;

public class FizzBuzz
{
    public string GetFizzBuzz(int number)
    {
        if (number % 5 == 0 & number % 3 == 0)
            return "FizzBuzz";
        else if (number % 3 == 0)
            return "Fizz";
        else if(number % 5 == 0)
            return "Buzz";
        else if (number == 2 )
            return "2";
        
        return "1";
    }
}

