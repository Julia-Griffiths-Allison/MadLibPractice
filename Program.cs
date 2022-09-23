//Making a mad lib! Our story will be... adpoting our first pet!

Console.WriteLine("Hello! We are going to play a madlib game. I am going to ask you for a series of words and then I will plug them into a story, are you ready? (y/n)");
string yn= Console.ReadLine();
if (yn == "yes" ||  yn == "Yes" || yn == "y")
{
    Console.WriteLine("Perfect! Alright so first question...");
}
else
{
    Console.WriteLine("What a shame, come back another time!");
    System.Environment.Exit(-1);
}

Console.WriteLine("Go ahead and give me an animal.");
var animal = Console.ReadLine();

Console.WriteLine("Now give me a name, any name.");
var employee = Console.ReadLine();

Console.WriteLine("I need an adjective now.");
var adj1 = Console.ReadLine();

Console.WriteLine("Another very descriptive adjective please");
var adj2 = Console.ReadLine();

Console.WriteLine("Give me a color");
var eyes = Console.ReadLine();

Console.WriteLine("Could you give me another name?");
var name1 = Console.ReadLine();

Console.WriteLine("I need an adverb, without an ending of -ly please.");
var adv1 = Console.ReadLine();

Console.WriteLine("I'll need an ingredient or food item - singular.");
var food = Console.ReadLine();

Console.WriteLine("Now give me a noun.");
var noun1 = Console.ReadLine();

Console.WriteLine("I'd like you to give me a household piece of furniture - singular.");
var bed = Console.ReadLine();

Console.WriteLine("Give me a job title.");
var job = Console.ReadLine();

Console.WriteLine("Give me a number! Big or small, but make use of a comma when appropriate (ex. 12,000.)");
var income = Console.ReadLine();

Console.WriteLine("Now I need you to give me a time frame, hours, seconds, weeks, centuries whatever you decide.");
var time = Console.ReadLine();

Console.WriteLine("Give me an adjective!");
var adj3 = Console.ReadLine();
Console.WriteLine("Another large number!");
var bigNum = Console.ReadLine();

Console.WriteLine("I'll need another number please");
var age = Console.ReadLine();

Console.WriteLine("Alright, I'll neeed a prefix to a name (ex: sir, mrs. king, chief)");
var prefix = Console.ReadLine();

Console.WriteLine("And another name please");
var name2 = Console.ReadLine();

Console.WriteLine("One more adjective...");
var adj4 = Console.ReadLine();


Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");

Console.WriteLine("    There has been a gap in your life recently and you've thought of an amazing way to solve your problem!");
Console.WriteLine($"It's time to adopt a {animal}! You run down to the nearest {animal} shop and begin to peruse their selection.");
Console.WriteLine("");
Console.WriteLine($"    ''Hello! my name is {employee}! Let me know if you need any assistance here!'' {employee} says, and you nod.");
Console.WriteLine($"You finally find the perfect {animal} for you. It's a {adj1}, {adj2} {animal} with bright {eyes} eyes.");
Console.WriteLine($"You're in awe at the beauty of this {animal} and you will surely not be able to function without it. You call {employee} over");
Console.WriteLine("");
Console.WriteLine($"    ''Ahh I see, you've taken a liking to {name1}. That's great! We've been looking for a responsible owner to take {name1} in!''");
Console.WriteLine($"It suddenly dawns on you, you've never owned a {animal} before, you don't know the first thing about caring for a {animal}!");
Console.WriteLine($"You give the worker a {adv1} smile, and they nod at you. ''Don't worry, if you're a first time handler we have all the resources you'll need here''");
Console.WriteLine($"A heavy weight lifts off of you, you follow {employee} around the store to get everything in order");
Console.WriteLine("");
Console.WriteLine($"    You gather some {food}, a couple {noun1}s to play with, and a {bed} to sleep comfortably.");
Console.WriteLine($"''Now we have the basics, time to get {name1} out for you!''");
Console.WriteLine("");
Console.WriteLine($"    Youve never been more excited, this {animal} is going to solve all your problems!");
Console.WriteLine($"You've hated your {job} possition for so long now, but you need the ${income} per {time} to survive.");
Console.WriteLine($"Unfortunatly, since you are unable to quit your {job} job, bringing a {adj3} {animal} into your life will bring joy back to you!");
Console.WriteLine($"But anyway, as you're checking out your total comes to {bigNum}, wow! Not what you expected at all.");
Console.WriteLine($"Luckily, you've saved bithday money up for the past {age} years! Were covered, nice!");
Console.WriteLine("");
Console.WriteLine($"     ''Alright, we are all good to go! One last question, what your new {animal}'s name?''");
Console.WriteLine($"'' ...{prefix} {name2}, what a {adj4} name!'' {employee} says while waving the two of you off.");
Console.WriteLine($"Now all that's left to do is... Enjoy each other's company! You and {prefix} {name2} live many, long, happy years together!");
Console.WriteLine("");
Console.WriteLine($"And now I leave you contemplating, would a {animal} make a good pet? only one way to find out...");





