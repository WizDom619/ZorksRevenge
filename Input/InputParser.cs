using ZorksRevenge.Input;

namespace ZorksRevenge
{
    /// <summary>
    /// This class will take in the Player's Input as a string. 
    /// The input will then be converted and returned into a Command object to be passed on and actioned.  
    /// </summary>
    internal class InputParser
    {
        /// <summary>
        /// The String will be broken apart into it's Verb and Noun. A
        /// The Verb will be what kind of action this command is. 
        /// The Noun will be the subject of said action. 
        /// The method will be flexible to process of few different words for the single Verb. 
        ///     <example>
        ///     Move or Go 
        ///     Take or Grab or Pick or Pick Up
        ///     Look, Look At, Examine
        ///     </example>
        /// Once input is broken apart the Verb and Noun will be encapsulated into a Command and returned. 
        /// </summary>

        // An array of useless words
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

        public Command Process(string input)
        {
            // Set the variables to be correctly assigned.
            // By default data is NULL unless changed.
            Verb newVerb = Verb.NULL;
            string newNoun = "NULL";

            // Split the input into individual words.  
            string[] splitInput = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            // Remove useless words.
            splitInput = splitInput.Where(word => !_uselessWords.Contains(word.ToUpperInvariant())).ToArray();

            // Identify the verb. 

            // Each verb can have multiple versions (for flexible input).
            // The first Verb detected will be the one selected.  
            foreach (string word in splitInput)
            {
                switch (word.ToUpperInvariant())
                {
                    case "TAKE":
                    case "GRAB":
                    case "NICK":
                    case "PICK":
                    case "T":
                        newVerb = Verb.Take;
                        break;

                    case "MOVE":
                    case "GO":
                    case "M":
                        newVerb = Verb.Move;
                        break;

                    case "LOOK":
                    case "Examine":
                    case "L":
                        newVerb = Verb.Look;
                        break;

                    case "DROP":
                    case "PUT":
                    case "D":
                        newVerb = Verb.Drop;
                        break;

                    case "INVENTORY":
                    case "I":
                        newVerb = Verb.Inventory;
                        break;

                    case "SPEAK":
                    case "TALK":
                    case "CHAT":
                    case "S":
                        newVerb = Verb.Speak;
                        break;

                    case "HELP":
                        newVerb = Verb.Help;
                        break;
                }

                //if Verb != Null, that means an actionable Verb has been detected and the loop can end. 
                if (newVerb != Verb.NULL)
                {
                    break;
                }
            }            

            // Identify the Noun. 

            // Remove the first index,
            // It 'should' be the VERB as assumed earlier, which is no longer needed. 
            splitInput = splitInput.Skip(1).ToArray();

            // Join the array back into a string.             
            // What's left 'should' be the Noun to action. 
            newNoun = String.Join(" ", splitInput);

            // Return the processed Command. 
            return new Command(newVerb, newNoun);
        }
    }
}
