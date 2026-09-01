using ZorksRevenge.Data;
using ZorksRevenge.Utility;

namespace ZorksRevenge.Input
{
    /// <summary>
    /// This class will take in the Player's Input as a string. 
    /// The input will then be converted into a Command object to be stored in GameData
    /// Then the Command is passed onto be used in Process() and Display()
    /// </summary>
    public static class InputManager
    {
        // An array of useless words
        // These words are used naturally in English but are unimportant to the parser
        // These words will be removed from input as to not to confuse the process. 
        private static readonly string[] _uselessWords =
        { 
            "AT",
            "FOR",
            "UP",
            "TOWARDS",
            "DOWN",
            "TO",
            "WITH",
            "THE"
        };

        /// <summary>
        /// The String will be broken apart into it's Verb and Noun. 
        /// The Verb will be what kind of action this command is. 
        /// The Noun will be the subject of the command. 
        /// The method will be flexible to accept of few variations of a single Verb. 
        /// As well as a single letter shortcut   
        ///  
        /// <example>
        /// Move, Go or M 
        /// Take, Grab, Pick, Pick Up or T
        /// Look, Look At, Examine or L
        /// </example>
        ///     
        /// This parser assumes the input is ordered as Verb then Noun
        /// 
        /// <example>
        ///     Water plants 
        ///     Open door
        ///     Eat food
        /// </example>
        ///
        /// So once the verb has been identified, the target Noun should be located after the Verb        /// 
        /// Once input is broken apart the Verb and Noun will be encapsulated into a Command and stored in GameData 
        /// </summary>
        
        public static void ParseInput(GameData gameData, string? input)
        {
            // Validate that input is not null. 
            if (input == null)
            {
                return;
            }

            // Declare the variables to be assigned to the command. 
            Verb newVerb = Verb.NULL;
            string newNoun = "NULL";            

            // Split the input into individual words to easily identify.  
            string[] splitInput = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            // To avoid confusion around capitalisation, all words will be in uppercase
            splitInput = splitInput.Select(s => s.ToUpperInvariant()).ToArray();

            // Remove useless words.
            splitInput = splitInput.Where(word => !_uselessWords.Contains(word)).ToArray();

            // **************************************
            // Identify the Verb. 
            // **************************************
            // Each verb can have multiple versions (for flexible input).

            // Given the nature of a foreach loop
            // The first Verb detected will be the one selected.
            // "Look Grab Rock" the command will be interpreted as "Look, Rock"
            // All Verbs get a shortcut letter other than 'SAVE' and 'QUIT'
            foreach (string word in splitInput)
            {
                switch (word)
                {
                    case "DROP":
                    case "PUT":
                    case "D":
                        newVerb = Verb.Drop;
                        break;

                    case "GIVE":
                    case "G":
                        newVerb = Verb.Give;
                        break;

                    case "HELP":
                    case "H":
                        newVerb = Verb.Help;
                        break;

                    case "INVENTORY":
                    case "I":
                        newVerb = Verb.Inventory;
                        break;

                    case "LOOK":
                    case "Examine":
                    case "L":
                        newVerb = Verb.Look;
                        break;

                    case "MOVE":
                    case "GO":
                    case "M":
                        newVerb = Verb.Move;
                        break;

                    case "OPEN":
                    case "O":
                        newVerb = Verb.Open;
                        break;

                    case "PLAY":
                    case "P":
                        newVerb = Verb.Play;
                        break;

                    case "SAVE":
                        newVerb = Verb.Save;
                        break;

                    case "SPEAK":
                    case "TALK":
                    case "CHAT":
                    case "S":
                        newVerb = Verb.Speak;
                        break;

                    case "QUIT":
                        newVerb = Verb.Quit;
                        break;

                    case "TAKE":
                    case "GRAB":
                    case "NICK":
                    case "PICK":
                    case "T":
                        newVerb = Verb.Take;
                        break;                                            
                }

                //if Verb != Null, that means an actionable Verb has been detected and the loop can end. 
                if (newVerb != Verb.NULL)
                {
                    break;
                }
            }

            // **************************************
            // Identify the Noun. 
            // **************************************
            // Remove the first index,
            // It 'should' be the VERB English is a , which is no longer needed. 
            splitInput = splitInput.Skip(1).ToArray();

            // Join the array back into a string.       
            // What remains 'should' be the target Noun    
            newNoun = String.Join(" ", splitInput);

            // Return the processed Command. 
            gameData.Command = new Command(newVerb, newNoun);
        }
    }
}
