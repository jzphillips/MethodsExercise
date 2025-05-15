namespace MethodsExercise
{
    public class Program
    {
        public static void UserIntro(string name)
        {
            Console.WriteLine("What's your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Nice to meet you, {userName}");
        }

        public static void ConvoContinuation(string movie)
        {
            Console.WriteLine("What's your favorite movie?");
            string movieTitle = Console.ReadLine();
            Console.WriteLine("Oh, that's a good one! Nice. ");
        }

        public static void ConvoIntoActor(string actor)
        {
            Console.WriteLine("Is your favorite actor in it; who is it?");
            string actorName = Console.ReadLine();
            Console.WriteLine("They're good. I see why you like them.");
            string response = Console.ReadLine();
        }

        public static void ExitConversation(string who)
        {
            Console.WriteLine("Mhm. Hey, I just saw the time and I need to head off. It was nice meeting you..?");
            string personName = Console.ReadLine();
            Console.WriteLine($"Right! {personName}. Sorry about that. I'll be seeing you around.");
            string responseb = Console.ReadLine();
        }
        static void Main(string[] args)
        {
            UserIntro(name:"");
            ConvoContinuation(movie:"");
            ConvoIntoActor(actor:"");
            ExitConversation("");
            
            Console.WriteLine(Addition(5, 10)); //Output = 15
            Console.WriteLine(Subtraction(4, 14)); //Output = -10
            Console.WriteLine(Multiplication(6, 8)); //Output = 48
            Console.WriteLine(Division (81, 9)); //Output = 9
            Console.WriteLine(PracAdd(11, 11, 22));
        }

        static int Addition(int amntOne, int amntTwo)
        {
            return amntOne + amntTwo;
        }

        static int Subtraction(int amntOne, int amntTwo)
        {
            return amntOne - amntTwo;
        }

        static int Multiplication(int amntOne, int amntTwo)
        {
            return amntOne * amntTwo;
        }

        static int Division(int amntOne, int amntTwo)
        {
            return amntOne / amntTwo;
        }

        public static int PracAdd(params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum+=number;
            }
            return sum;
        }
    }
}
