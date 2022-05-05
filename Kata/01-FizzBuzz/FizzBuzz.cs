namespace Kata.FizzBuzz;

public class FizzBuzz
{
    public string GetFizzBuzz(int number)
    {
        if (number > 100)
            return "The number must be less than 101";
        else if (number < 1)
            return "The number must be greater than 0";
        else if (number % 5 == 0 && number % 3 == 0)
            return "FizzBuzz";
        else if (number % 3 == 0)
            return "Fizz";
        else if(number % 5 == 0)
            return "Buzz";
        return number.ToString();
    }

        

    
}

