namespace Day_6_Arrays_Lists;

// This program will ask for three numbers
//      add them together and display the total

class Program
{
    static void Main(string[] args)
    {
        // Define an array to hold 3 numbers
        int[] numbers = new int[3]; // numbers.Length=3; 2 is the largest allowable index.
        
        int number1 = 0; // Since we will be doing math it needs to be numeric
        int number2 = 0; // Since we will be doing math it needs to be numeric
        int number3 = 0; // Since we will be doing math it needs to be numeric
        int number4 = 0; // Since we will be doing math it needs to be numeric
        int number5 = 0; // Since we will be doing math it needs to be numeric

        // Define a variable to hold the sum of the numbers
        int sum = 0;

        Console.WriteLine("--- Starting program ---");
        
        //Normally we process an array from beggining to end
        // (from the first element tot last element, one at a time)
        //
        // a for-loop will loop through a process counting as it does so
        // a for-loop is an excellent tool for processing an array from start to end
        //
        // standard syntax: for(i=0; i < arrayName.Length; i++)
        
        //arrayName.Length represents 
        
        // index                    loop as 
        // start                    long as the index         increment the 
        // at 0                     is not outside array     index for eacg loop
        for (int i = 0; i < numbers.Length; i++) // i + 0, 1, 2 inside loop and 3 when exit loop
        {
            Console.WriteLine("Please enter a number:  "); // Asking for the number
            numbers[i] = int.Parse(Console.ReadLine());    // get a string from keyboard
                                                           // convert it to an int
                                                           // store it in numbers[]
        }

         // Verify the array received the numbers correctly
         // Go through the array 
         for (int i=0; i <numbers.Length; i++)// i=0, 1, 2
         {
             Console.WriteLine("Element # "+ i + " is: " + numbers[i]);
             sum = sum + numbers[i]; // add the current number in the array to sum 
         }

        // Add the numbers together create a sum/total
       // sum = number1 + number2 + number3 + number4 + number5;
       
        // Tell the requester the sum/total (display)
        Console.WriteLine("The sum is: " + sum);
        
        // Tell the rquester the average of the numbers
        // divide the sum of the number of elements (arrayname.Length)
        // Note the cast of sum to a double so we can get decimal places in the results
        Console.WriteLine("The average of the numbers is: " + (double) sum / (double) numbers.Length);
        
        // sum / numbers.Length
        // int / int ---> integer arithmetic - divide gives two parts quotient and remainder
        //    int    (quotient 2)                             7  /  3  -  quotient=2 remainder=1
        
        // (double) sum / numbers.Length
        // convert sum 
        // to a double  / int -----> floating point arithmetic
        //
        //              / convert int to double (C# does this automatically)
        //  double      / double -----> floating point arithmetic
        //      double  (2.33333)

        Console.WriteLine("--- Ending program ---");
    }
}