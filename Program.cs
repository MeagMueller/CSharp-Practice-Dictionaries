using System;
using System.Collections.Generic;

namespace dictionary_of_words
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Create a dictionary with key value pairs to represent words (key) and its definition (value)*/
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

            // Add several more words and their definitions
            wordsAndDefinitions.Add("blandishment", "flattery intended to persuade");
            wordsAndDefinitions.Add("conflagration", "a very intense and uncontrolled fire");
            wordsAndDefinitions.Add("diaphanous", "so thin as to transmit light");
            wordsAndDefinitions.Add("ephemeral", "anything short-lived");
            wordsAndDefinitions.Add("fortuitous", "lucky or occurring by happy chance");
            wordsAndDefinitions.Add("grandiloquent", "lofty in style");
            wordsAndDefinitions.Add("intimation", "a slight suggestion or vague understanding");
            wordsAndDefinitions.Add("multifarious", "having many aspects");

            /*
                Use square bracket lookup to get the definition two
                words and output them to the console
            */

            /*
                Loop over dictionary to get the following output:
                    The definition of [WORD] is [DEFINITION]
                    The definition of [WORD] is [DEFINITION]
                    The definition of [WORD] is [DEFINITION]
            */
            foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            {
            }
        }
    }
}
