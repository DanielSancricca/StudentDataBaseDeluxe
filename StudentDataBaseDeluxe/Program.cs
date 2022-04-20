
class Program
{
    static void Main()
    {
        List<string> studentNames = new List<string>() { "Johnny", "Miguel", "Danny", "Tory", "Sam" };

        List<string> hometowns = new List<string>() { "Detroit", "Los Angeles", "Boston", "Miami", "Dallas" };

        List<string> favoritefoods = new List<string>() { "steak", "hamburgers", "fish", "spaghetti", "tacos" };

        List<string> favoritecolor = new List<string>() { "yellow", "red", "blue", "black", "green" };

        int index;

        bool goAgain = true;

        while (goAgain == true)
        {
            foreach(string student in studentNames)
            {   
                Console.WriteLine(studentNames.IndexOf(student)+1 +"-" + student);
            }
            string response = GetUserInput($"Which of the {studentNames.Count} students would you like to learn about? Please enter 1-{studentNames.Count}:");
            
            try
            {
                index = int.Parse(response);
                string name = studentNames[index - 1];
                string hometown = hometowns[index - 1];
                string favfood = favoritefoods[index - 1];
                string favcolor = favoritecolor[index - 1];
            }
            catch (FormatException e)
            {

                Console.WriteLine("I'm sorry that is not a number corresponding to a student.");
                Console.WriteLine($"Please try a number between 1 and {studentNames.Count}");
                continue;
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine($"The input was out of range, please input a whole number between 1-{studentNames.Count}");
                continue;
            }

            Console.WriteLine($"What would you like to learn about {studentNames[index - 1]}? Their hometown, their favorite food, or their favorite color?");
            string userChoice = Console.ReadLine().ToLower();
            if ("hometown" == userChoice)
            {
                Console.WriteLine($"{studentNames[index - 1]}'s hometown is {hometowns[index - 1]}.");
            }
            else if (userChoice == "favorite food" || userChoice == "food")
            {

                Console.WriteLine($"{studentNames[index - 1]}'s favorite food is {favoritefoods[index - 1]}.");
            }
            else if (userChoice == "favorite color" || userChoice == "color")
            {
                Console.WriteLine($"{studentNames[index - 1]}'s favorite color is {favoritecolor[index - 1]}.");
            }
            else
            {
                Console.WriteLine("I'm sorry we only have information on a student's hometown, favorite food, and favorite color.");
            }
            while (true)
            {
                string userInput = GetUserInput("Would you like to add another student? Please enter y or n ");
                if (userInput == "y" || userInput == "yes")
                {
                    Console.WriteLine("Who would you like to add to the student list?");
                    string newStudent = Console.ReadLine();
                    studentNames.Add(newStudent);
                    Console.WriteLine($"What is {newStudent}'s hometown?");
                    string newhometown = Console.ReadLine();
                    hometowns.Add(newhometown);
                    Console.WriteLine($"What is {newStudent}'s favorite food?");
                    string newfavfood = Console.ReadLine();
                    favoritefoods.Add(newfavfood);
                    Console.WriteLine($"What is {newStudent}'s favorite color?");
                    string newfavcolor = Console.ReadLine();
                    favoritecolor.Add(newfavcolor);
                    continue;


                }
                   
                else if (userInput == "n" || userInput == "no")
                {
                    Console.WriteLine("Sounds good!");
                    break;
                }
                else
                {
                    Console.WriteLine("I'm sorry I didn't understand that response.");
                     continue;
                }
            }

            goAgain = RunAgain();

        }    






        
            
        }

        static string GetUserInput(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();
            return input;
        }

        static bool RunAgain()
        {
            string answer = GetUserInput("Would you like to learn about any of the other students? Please enter y or n").ToLower();

            if (answer == "y" || answer == "yes")
                return true;
            else if (answer == "n" || answer == "no")
            {
                Console.WriteLine("Goodbye!");
                return false;
            }
            else
            {
                Console.WriteLine("I'm sorry I didn't understand that response. Please enter y or n");
                return RunAgain();
            }

        }









    }



        
        
        