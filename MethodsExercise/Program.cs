namespace MethodsExercise
{
    public class Program
    {
        public static void Spacer() //Function to create breaks between outputs - Misc.
        {
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            return;
        }
        public static bool MoreStories() //Determines Continuation - Misc.
        {
            bool ongoing = false; int choice = 0; string answer = "";
            do
            {
                Console.WriteLine("Would you like to make another MadLib (yes/no)?");
                answer = Console.ReadLine();
                if (answer == "yes")
                {
                    ongoing = true;
                    choice = 1;
                }
                else if (answer == "no")
                {
                    ongoing = false;
                    choice = 2;
                }
                else
                {
                    Spacer();
                    Console.WriteLine("Please enter a valid response!");
                    Spacer();
                }
            } while (choice == 0);
            return ongoing;
        }

        //Exercise # 1

        public static void Survey(int total) //Asks for Inputs - Exercise 1
        {
            Console.WriteLine($"Creating Story # {total}:");
            Spacer();
            Console.WriteLine("Name a Person:");
            string person = Console.ReadLine();
            Spacer();
            Console.WriteLine("Name a Place:");
            string place = Console.ReadLine();
            Spacer();
            Console.WriteLine("Name a Color:");
            string color = Console.ReadLine();
            Spacer();
            Console.WriteLine("Name an Animal:");
            string animal = Console.ReadLine();
            Spacer();
            Console.WriteLine("Name a Noun:");
            string noun = Console.ReadLine();
            Spacer();
            Console.WriteLine("Give a Number:");
            int num1 = int.Parse(Console.ReadLine());
            Spacer();
            Console.WriteLine("Give Another Number:");
            int num2 = int.Parse(Console.ReadLine());
            Spacer();
            Prompt(person, place, color, animal, noun, total, num1, num2);
            Spacer();
        }
        public static void Prompt(string person, string place, string color, string animal, string noun, int total, int num1, int num2) //Creates the Story - Exercise 1
        {
            Random rnd = new Random();
            int sum = Tally(num1, num2);
            int mult = ExponentialTally(num1, num2);
            int r = 0;
            r = rnd.Next(0, 4);
            Console.WriteLine($"Complete Story # {total}:");
            if (r == 0) Console.WriteLine($"{person} rode the {color} {noun} with their pet {animal} to get to {place}.");
            if (r == 1) Console.WriteLine($"{person} learned that seasoning {animal} with {noun} from {place} turns the meat {color}.");
            if (r == 2) Console.WriteLine($"{person}, wielding the {noun}, traveled to {place} to do battle with the {color} {animal}.");
            if (r == 3) Console.WriteLine($"The dreaded {animal} of {place} was captured by local legend {color} {person}, using the '{noun} Method.'");
            if (r == 4) Console.WriteLine($"{person} underestimated how much the {animal} from {place} could hate a simple {color} {noun}.");
            Console.WriteLine($"The {mult} events that unfolded over the next {sum} hours should speak for themselves...");
        }

        //Exercise 2

        public static int Tally(int total, int increase) //Adds Numbers, Basic - Exercise 2
        {
            int current = total + increase;
            return current;
        }
        public static int ExponentialTally(int total, int increase) //Multiply Numbers, Basic - Exercise 2
        {
            int current = total * increase;
            return current;
        }

        //Exercise 2 Challenge Mode

        public static int ChallengeSum(params int[] list) //Challenge Mode for Adding Params - Exercise 2
        {
            int finalValue = 0; int i = 0;
            for (i=0; i < list.Length; i++)
            {
                finalValue += list[i];
            }
            return finalValue;
        }
        public static int ChallengeMult(params int[] list) //Challenge Mode for Multiplying Params, Unused - Exercise 2
        {
            int finalValue = 1; int i = 0;
            for (i = 0; i < list.Length; i++)
            {
                finalValue *= list[i];
            }
            return finalValue;
        }

        //Main

        public static void Main(string[] args) //Primary Function - Combines Exercise 1 & Exercise 2
        {
            Console.WriteLine("Welcome to Alex's Madlibs!");
            bool notFinalPrompt = true; int total = 0;
            do
            {
                Spacer();
                total = ChallengeSum(total, 1);
                Survey(total);
                notFinalPrompt = MoreStories();
            } while (notFinalPrompt == true);
        }
    }
}
