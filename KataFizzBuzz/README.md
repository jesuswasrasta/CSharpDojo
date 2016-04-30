FizzBuzz
========

Write a program that prints the numbers from 1 to 100. 
But for multiples of three print "Fizz" instead of the number and for the multiples of five print "Buzz". 
For numbers which are multiples of both three and five print "FizzBuzz".

[Fizz Buzz](http://c2.com/cgi/wiki?FizzBuzzTest)


####Project Template
using System;

public class FizzBuzzKata : IFizzBuzzKata
{
    public string Answer(int i)
    {
        throw new NotImplementedException();
    }
}

public interface IFizzBuzzKata
{
    /// <summary>
    /// Give an answer to the current game
    /// </summary>
    /// <param name="number">current number in the game sequence</param>
    /// <returns>appropriate answer to the current number</returns>
    string Answer(int number);
}