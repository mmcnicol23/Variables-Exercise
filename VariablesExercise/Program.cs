namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name = "Mariah";
            string secondName = "Shane";
            int number = 2;
            double price = 10.99;
            bool isSmart = true;
            char letter = 'A';
            decimal age = 10.5m;

//Here is the story using the variables above:
            Console.WriteLine($"{name} and {secondName} have {number} dogs at home.");
            Console.WriteLine($"Last night, they paid {price} for a pizza for dinner.");
            Console.WriteLine($"It's {isSmart} that Shane is very funny and handsome.");
            Console.WriteLine($"Mariah is going to get an {letter} on her assignments at TrueCoders.");
            Console.WriteLine(
                $"{name} and {secondName} took their dog on a trip for her half birthday. She is now {age} years old.");
        }
    }
}