/* Improve
	// !Fix Comments https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/documentation-comments
	// !MainMenu hold GameManager
	// !Questions structure, create input handling loop to get a better sense of everything. 
	// !ItemData could be static. 
	// !GameData classes into JSON file. 
	
	//-Game Menu


//TODO 
	Room (name, description, list of items, list of directions). 
	Items can have properties — a door can be locked or unlocked, a torch can be lit or unlit, a chest can be open or closed. The game checks those states when you try to interact.
	Items.Locks 
    Items.Keys
	Item.Torch Lit/Unlit
	Items.Consumables (Kit-Kats, Raw Chicken Breast, Half-Eaten Chicken Parma, Pesto Pasta)
	Item Containers (chests)
	Inventory (hold items); 
	Money
	Item Changing (Mixing, Fire)
	
	NPC
	NPC.Shop
	NPC.Sphinx (Vorthak the Veiled, Nyxarion, Sethoros the Silent Fang, Azraka the Riddle King, Khepraxis
	Sphinx Riddles (Quiz, Minigames)
	Minigames / Puzzles	
	
	Quiz
		Acting is Easy
		Tastes like Regret
		Running is for Dumb People, even though it hurts you keep doing it. 
		Going to the wrong badminton centre
		
	Structure
		You start near a sealed door, it required 7 gems to unlock and fight Zork to escape.
		Each Gem is assoicated with a colour, 
		A Sphinx who has a challenge for you. 
		Each Sphinx will have a quest to complete before attempting their challenge. 
		These quests require you to go out explore the world and obtain a requested item. 
		Quest items will often come from mixing other items found in the world. 
			Such as Pesto pasta is a combo os (pasta, pesto sauce, chicken and cherry tomato). 
		
		-White		Diamond 	Guess the number game 		
		-Blue 		Sapphire 	Dice Roll Game. 
		-Green 		Emerald 	Rock, Paper Scissors game. 
		-Cyan 		Aquamarine 	Circumference of a Circle
		-Red 		Ruby 		Area of a Circle
		-Magenta 	Amethyst 	Hypotenuse Calculator
		-Yellow 	Topaz		Hangman Game 
		
	PlayerInput( go move, take grab pick up , drop, look at examine, use, inventory); 
	Parser: verb nouns,
	
	Pokemon Battle (Bono and Zilla)

	Game Loop...	
	while (player.IsAlive)
	{
		Console.Write("> ");
		string input = Console.ReadLine();
		string output = parser.Process(input, gameState);
		Console.WriteLine(output);
	}
	
	 
	
//Done

	
*/