namespace Day_2_For_Each_Example;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to an Example of a For-Each Loop");
        // Ask the user to enter a sentence (series of words seperated by whitespace - space, tab, something you can't see)
        // Display each word in the sentence 
       Console.WriteLine("Please enter a sentence");
       string sentence = Console.ReadLine();  
       // split the sentence into words
       
       // .split() will extract parts of a string into an array based on character inside ()
       //string[] splitSentence = sentence.Split(' '); // split the sentence into words

       List<string> splitSentence = sentence.Split(" ").ToList(); // Convert the array to a list otherwise it will return array
       
       // Display each word in the sentence - arrayName.Length returns the number of elements
       // for (int i = 0; i < splitSentence.Length; i++)
       for (int i = 0; i < splitSentence.Count; i++) // To process a List - use .Count
       {
           // Note: to add 1 to i and use in the string we have to put it in ()
           //        + for a string means concatentate
           //        + for a numeric means add
           //        i+1 in the output for Writeline,
           //            it thinks I want to take the value of i and stick a 1 after it 
           //        (i+1) - () indicate do this first - add 1 to i and then use it in WriteLine output
           Console.WriteLine("Word #: " + (i+1) + " is: " + splitSentence[i]);
           
       }
           Console.WriteLine("----foreach example result follows ----");
       // for-each loop can also process arrays and List
       //
       // Syntax: foreach(datatype variable-name in array-or-List
       //         datatype is the type of data in the array or List
       //         use the variable name inside the foreach loop to access an element in the array
       //
       // Foreach goes through the array or List from start to end assigning each element to the variable
       //
       // for-loop vd for-each loop
       // Both can process an array or List from beginning to end
       // for-loop can start and end at any element by setting in i= and changing the condition
       // for-each loop ALWAYS processes from beginning to end
       // for-loop you know which elements your processing by using the value in i
       // for-each loop you do not know what element number you're processing

       foreach (string aWord in splitSentence)
       {
           Console.WriteLine(aWord);
       }
       
       // Display all the words using a do-while loop
       //
       // do 
       //  {
       //    loop processing
       //  } while(condition)  // loop while the condition is true
       //
       // We always do the loop process at least once
       //    because the condition is checked at the end of the loop process
       
       // Define a variable to keep a track of the element in the aray/List we are processing
       int currentElementNumber = 0; // in a for-loop this is i

       do
       {
         Console.WriteLine("#Word: " + (currentElementNumber) + " is: " + splitSentence[currentElementNumber]);
         currentElementNumber++; // increment our index variable to move through the array or list
       } while (currentElementNumber < splitSentence.Count);
           
       }// End of main
    }
