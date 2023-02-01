namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What is your favorite colour");
            string colour = Console.ReadLine();

            Console.WriteLine("What is your favorite animal");
            string animal = Console.ReadLine();

            Console.WriteLine("What is your favorite band");
            string band = Console.ReadLine();

            Console.WriteLine($"Hello {name} my name is also {name}. What is your favorite " +
                $"colour? Woah {colour} is my favorite colour too! " +
                $"If I had to guess I'd say your favorite animal is probably a {animal}?? " +
                $"I knew it!! Ok so what is your favorite band? OMG I love {band} " +
                $"I listen to them all the time!!");


            Methods.Add(22, 45);
            Console.WriteLine(Methods.Add(22, 45));

            Methods.Subtract(534, 298);
            Console.WriteLine(Methods.Subtract(534, 298));

            Methods.Multiply(6, 333);
            Console.WriteLine(Methods.Multiply(6, 333));

            Methods.Divide(100, 5);
            Console.WriteLine(Methods.Divide(100, 5));

            Methods.Modulus(55, 601);
            Console.WriteLine(Methods.Modulus(55, 601));


        }
    }
}
