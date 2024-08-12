string[] names = new string[]
{
    "Justin Jones",
    "DeAngelo Robinson",
    "Martina Basquez",
    "Alain Rene",
    "David Goodwin",
    "Joey Molinski",
    "Wren Grasley",
    "Brady Hartman",
    "David Brameijer",
    "Afseen Salam",
    "Ethan Thomas"
};

string[] hometowns = new string[]
{
    "Westerville",
    "Detroit",
    "Edinburg",
    "Homestead",
    "Jersey City",
    "Toledo",
    "Richmond",
    "Saranac",
    "Grand Rapids",
    "India",
    "Bolivar"
};

string[] favoriteFoods = new string[]
{
    "Baja Blast",
    "Pizza",
    "Leftovers",
    "Chicken Wings",
    "Sushi",
    "Dill Pickles",
    "Pizza",
    "Chicken Wings",
    "Tacos",
    "Shawarma",
    "Grapes"
};
bool loopProgram = true;
int studentIndex = 0;

do
{
    do {
        Console.WriteLine($"Welcome! Which student would you like to learn more about? Enter a number 1-{names.Length}:");
        studentIndex = int.Parse(Console.ReadLine()) - 1;
    } while (studentIndex < 0 || studentIndex >= names.Length);

    Console.WriteLine($"Student {studentIndex + 1} is {names[studentIndex]}. Would you like to know about their hometown or favorite food?");
    string answer = Console.ReadLine().ToLower();

    bool validAnswer = false;
    do
    {
        if (answer == "hometown")
        {
            validAnswer = true;
            Console.WriteLine($"{names[studentIndex]}'s hometown is {hometowns[studentIndex]}");
        }
        else if (answer == "favorite food")
        {
            validAnswer = true;
            Console.WriteLine($"{names[studentIndex]}'s favorite food is {favoriteFoods[studentIndex]}");
        }
        else
        {
            Console.WriteLine("Invalid answer. Please enter 'hometown' or 'favorite food'.");
            answer = Console.ReadLine();
        }
    } while (!validAnswer);

    while (true) {
        Console.WriteLine("Would you like to know about another student?");
        string yn = Console.ReadLine();
        if (yn == "y")
        {
            break;
        } else if (yn == "n")
        {
            loopProgram = false;
            break;
        }
        else
        {
            Console.WriteLine("Please enter y/n.");
        }
    }
} while (loopProgram);