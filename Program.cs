#nullable disable

// Welcome
Console.Clear();
Console.WriteLine("WELCOME TO THE HEART QUIZ");

// Correct answers counter
int correct = 0;

// Question 1
Console.Write("\nWhich structure is considered the pacemaker of the heart? ");
string answer1 = Console.ReadLine().ToLower();
if (answer1 == "sinoatrial node" || answer1 == "sa node" || answer1 == "the sinoatrial node" || answer1 == "the sa node")
{
    Console.WriteLine("Correct");
    correct++;
}
else
{
    Console.WriteLine("Incorrect\nThe correct answer was the sinoatrial node");
}

// Question 2
Console.Write("\nHow many ventricles are there? ");
string answer2 = Console.ReadLine().ToLower();
if (answer2 == "2" || answer2 == "two")
{
    Console.WriteLine("Correct");
    correct++;
}
else
{
    Console.WriteLine("Incorrect\nThe correct answer was two");
}

// Question 3
Console.Write("\nTo which organ does the right ventricle go to? ");
string answer3 = Console.ReadLine().ToLower();
if (answer3 == "lungs" || answer3 == "the lungs")
{
    Console.WriteLine("Correct");
    correct++;
}
else
{
    Console.WriteLine("Incorrect\nThe correct answer was the lungs");
}

// Question 4
Console.Write("\nWhat is the name of the main artery that carries blood from your heart to the rest of your body? ");
string answer4 = Console.ReadLine().ToLower();
if (answer4 == "aorta" || answer4 == "the aorta")
{
    Console.WriteLine("Correct");
    correct++;
}
else
{
    Console.WriteLine("Incorrect\nThe correct answer was the aorta");
}

// Results
int percentage = correct / 4 * 100;
Console.WriteLine($"\nYOUR RESULTS:\n{correct} / 4 ({percentage}%)");

string feedback;
if (correct == 0)
{
    feedback = "You are definitely going to fail your bio exam";
}
else if (correct == 1)
{
    feedback = "At least you got one";
}
else if (correct == 2)
{
    feedback = "Only 50%? You can do better";
}
else if (correct == 3)
{
    feedback = "That's a pretty decent mark";
}
else
{
    feedback = "Wow, you aced this test!";
}

Console.WriteLine(feedback);