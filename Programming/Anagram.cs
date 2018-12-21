using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
 public static   class Anagram
    {
//Two words are said to be Anagrams of each other if they share the same set of letters to form the respective words.Remember, it’s just rearranging the existing letter set.For example, Silent and Listen.

//The following example is not an Anagram, since we use one “I” in DIANA and two “a”s whereas INDIA has two “I”s and one “a”.

//For example, INDIA & DIANA.

//Logic

//The following is the logic.

//Convert both strings to character arrays.

//Sort the character arrays in ascending/descending order, but use the same ordering on both of the character sets.

//Create two strings out of the two sorted character set arrays.

//Compare the strings.

//If they are not equal, they are not Anagrams.

        public static void  Anag()
        {
            Console.WriteLine("Enter the Word");
            string firstword = Console.ReadLine();
            Console.WriteLine("Enter the Second Word");
            string secondword = Console.ReadLine();
            char[] char1 = firstword.ToLower().ToCharArray();
            char[] char2 = secondword.ToLower().ToCharArray();
            Array.Sort(char1);
            Array.Sort(char2);

            string NewWord1 = new string(char1);
            string NewWord2 = new string(char2);

            //Step 4  
            //ToLower allows to compare the words in same case, in this case, lower case.  
            //ToUpper will also do exact same thing in this context  
            if (NewWord1 == NewWord2)
            {
                Console.WriteLine("Yes! Words \"{0}\" and \"{1}\" are Anagrams", firstword, secondword);
            }
            else
            {
                Console.WriteLine("No! Words \"{0}\" and \"{1}\" are not Anagrams", firstword,secondword);
            }
            //Hold Console screen alive to view the results.  
            Console.ReadLine();

        }
    }
}
