using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using NUnit.Framework; //test classes need to have the using statement

///     REDDIT DAILY PROGRAMMER SOLUTION TEMPLATE 
///                             http://www.reddit.com/r/dailyprogrammer
///     Your Name: 
///     Challenge Name: Acronym Expander
///     Challenge #: 193
///     Challenge URL: https://www.reddit.com/r/dailyprogrammer/comments/2ptrmp/20141219_challenge_193_easy_acronym_expander/
///     
///     Brief Description of Challenge:
///     
///     Takes in an acronym and then returns the real definition of
///     it. For example lol = laugh out loud.
///
/// 
///
///     What was difficult about this challenge?
///     
///     It was difficult figuring out how the regex split worked and
///     why nothing else i was trying did
///
///     
///
///     What was easier than expected about this challenge?
///     
///     Creating a dictionary was way easier than I expected 
///
///
///
///     BE SURE TO CREATE AT LEAST TWO TESTS FOR YOUR CODE IN THE TEST CLASS
///     One test for a valid entry, one test for an invalid entry.

namespace DailyProgrammer_Template
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RealMeaning("lol"));
            Console.WriteLine(RealMeaning("asap"));
            Console.WriteLine(RealMeaning("tbt"));

            Console.ReadKey();
        }
        /// <summary>
        /// dictionary that holds the acronym and then its real definitin
        /// </summary>
        /// defining a dictionary where both the the entry and its defintion are strings
        public static Dictionary<string, string> Acronyms = new Dictionary<string, string>()
        {
            {"g2g", "got to go"},
            {"brb", "be right back"},
            {"omw", "on my way"},
            {"wth", "what the hell"},
            {"ttyl", "talk to you later"},
            {"atm", "at the moment"},
            {"lmao", "laughing my ass off"},
            {"rofl", "rolling on the floor laughing"},
            {"lol", "laugh out loud"},
            {"idk", "I don't know"},
            {"tbt", "throw back Thursday"},
            {"fbf", "flash back Friday"},
            {"wcw", "woman crush Wednesday"},
            {"asap", "as soon as possible"},
            
        };

        /// <summary>
        /// checks if the input is in the dictionary, then find and displays its corresponding definition
        /// </summary>
        /// <param name="shortenDef"></param>
        /// <returns></returns>
        public static string RealMeaning(string shortenDef)
        {
            //empty string to hold info
            string finalString = string.Empty;

            
            string[] splitString = Regex.Split(shortenDef, ",");
            
            //will pring out every index of the new array
            for (int i = 0; i < splitString.Length; i++)
            {

                string temp1 = splitString[i];
                //checking if the dictionary contains the acronym
                if (Acronyms.ContainsKey(temp1))
                {
                    //temp string is equal to the index of the dictionarys defintion
                    temp1 = Acronyms[temp1];
                    //the index is equal to the definition
                    splitString[i] = temp1;
                }
            }
            //puts the array back together and puts a space inbetween the words
            finalString = String.Join("", splitString);
            return finalString;
        }

        /// <summary>
        /// Simple function to illustrate how to use tests
        /// </summary>
        /// <param name="inputInteger"></param>
        /// <returns></returns>
        public static int MyTestFunction(int inputInteger)
        {
            return inputInteger;
        }

        #region " TEST CLASS "

        //We need to use a Data Annotation [ ] to declare that this class is a Test class
        [TestFixture]
        class Test
        {
            //Test classes are declared with a return type of void.  Test classes also need a data annotation to mark them as a Test function
            [Test]
            public void MyValidTest()
            {
                //inside of the test, we can declare any variables that we'll need to test.  Typically, we will reference a function in your main program to test.
                int result = Program.MyTestFunction(15);  // this function should return 15 if it is working correctly
                //now we test for the result.
                Assert.IsTrue(result == 15, "This is the message that displays if it does not pass");
                // The format is:
                // Assert.IsTrue(some boolean condition, "failure message");
            }

            [Test]
            public void MyInvalidTest()
            {
                int result = Program.MyTestFunction(15);
                Assert.IsFalse(result == 14);
            }
        }
        #endregion
    }
}
