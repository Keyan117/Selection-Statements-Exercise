namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
          //Number Guessing Game
          var r = new Random();
          var favNumber = r.Next(1, 1001);
          

          Console.WriteLine("Pick as favNumber from 1 - 1000");
          var userInput = int.Parse(Console.ReadLine());

          if(userInput < favNumber)
          {
            Console.WriteLine($"{userInput} is too low");
          }
          else if(userInput > favNumber)
          {
            Console.Writeline ($"{userInput} is too high");
          }
          else
          {
            Console.Writline("You guessed it!");
          }

          //Switch-Case
          Console.WriteLine("What is your favorite subject?");
        
          string subject = Console.ReadLine();

          switch (subject.ToLower())
          {
            case "math":
                Console.WriteLine["I hate Math!"];
                break;
            case "science":
                Console.WriteLine["I love science!"];
                break;
            case "pe":
                Console.WriteLine["PE is the best!!"];
                break;
            case "history":
                Console.WriteLine["History is fun."];
                break;
            case "english":
                Console.WriteLine["English is boring."];
                break;
            default:
                Console.WriteLine["I don't know that subject."];
                break;
           }
           int answer = 4;
string response;
if (answer < 9) 
{
    response = answer + " is less than nine";
}
else
{
    response = answer + " is greater than or equal to nine";
}
var answer = 4;
var response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater than nine";
Console.WriteLine(response);


        }
    }
}
