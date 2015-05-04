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
///     It was difficult figuring out how to display the correct defition from the dictionary
///     
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
            AcronymCheck("lol");

                Console.ReadKey();
        }

        string input = Console.ReadLine();
        public static string AcronymCheck(string input)
        {
             Dictionary<string, string> acronymnDefinitions = Acronyms();
            
            while (true)
            {
                
                Console.Write("Enter chat phrase: ");
                //allows you to enter the accronym which you want defined


                //splitting and putting into an array
                string[] words = input.Split(' ');

                for (int i = 0; i < words.Length; i++)
                {
                    //checking if the acronym is defined in the dictionary
                    if (acronymnDefinitions.Keys.Contains(words[i]))
                    {
                        //making the acronym equal to the defintion
                        words[i] = acronymnDefinitions[words[i]];
                    }
                    else
                    {
                        return string.Empty;
                    }
                }

                Console.WriteLine(string.Join(" ", words));
                return string.Join(" ", words);
            }

          
        }

        /// <summary>
        /// dictionary that holds the acronym and then its real definitin
        /// </summary>
        /// defining a dictionary where both the the entry and its defintion are strings
        public static Dictionary<string, string> Acronyms()
        {
            var dict = new Dictionary<string, string>
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
            
            return dict;
    }
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
                string result = Program.AcronymCheck("lol");  // this function should return 15 if it is working correctly
                //now we test for the result.
                Assert.IsTrue(result == "laugh out loud", "This is the message that displays if it does not pass");
                // The format is:
                // Assert.IsTrue(some boolean condition, "failure message");
            }

            [Test]
            public void MyInvalidTest()
            {
                string result = Program.AcronymCheck("asd");
                //string result = Program.Acronyms();
                Assert.IsFalse(result == "laugh out loud");
            }
        }
        #endregion
    }
