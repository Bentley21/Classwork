namespace MethodsExamples;

class Program
{
    /*****************************************************************************************
     * Demonstrate the use of Programmer defined methods
     *
     * a method is a program that processes data and usually returns a value
     *
     * a method starts with a method signature identifies the name of the method
     *                                                    what type of data it returns
     *                                                    what data it will accept for processing
     * Method signature:    return-type Name(data-it-will-accept)
     *
     *       return-type - the type of data returned from the method
     *                     use void if the method does not return data
     *
     *        Name() - name of the method - method names are in Pascalcase
     *                                      Pascalcase - the first letter of every word is capitalized
     *
     *        (data-it-will-accept) - data-type and name of any parameters
     *
     *        parameter is a piece of data passed/given to a method for its processing
     ********************************************************************************************************/
    //Every application has one and only one method called Main()
    //
    // Main() method signature
    //
    // static - indicates there can be one of this is an application
    //
    //     return 
    //      type  name(parameters-it-may-accept)
    static void Main(string[] args)  // Main is a method that returns nothing and receives a string [] called args
    {
        Console.WriteLine("Hello, World!");

        int mySum = Addem(4, 5); // Send the numbers 4 and 5 to Addem to get the sum
                                 // Addem() will be executed with the numbers 4 and 5
                                 // it will return the sum
                                 // which will be stored in the variable mysum

        int yoda = 97;
        int obiWon = 420;
                                 
        Console.WriteLine("The sum of 4 + 5 is: " + mySum);
        Console.WriteLine("The sum of 3 + 4 is: " + Addem(3,4));
        Console.WriteLine("The sum of yoda and obiWon is: " + Addem(yoda,obiWon)); // calling with two ints
                                                                                   // Run the Addem that takes two ints
        Console.WriteLine("The sum of 3 + 4 is: " + Addem(3.1,4.5)); // Calling with two doubles
                                                                     // Run the Addem that takes two doubles
        Console.WriteLine("The sum of 67 + 9.9 is: " + Addem(67,9.9)); // Calling the Addem with an int and a double 
                                                                     // We don't have an Addem that takes an int and a double
                                                                     // It ran the Adde that takes two doubles
                                                                     // C# converts the int to a double
                                                                     // so now it can run the Addem that takes doubles
    }   // End of Main()
    
    //    After a method you may define other methods that method can use
    // "Helper Methods' - help a method to do perform a specific task
    
    // Define a method to receive two numbers and return the sum
    //
    //  If a method will be used by a static method it must be static itself
    //  Any method used by Main() must be static because Main() is static
   //   return 
   //   type name(parameters)
   
   // Addem is a method that receives two ints its calling num1 and num2 
   //                    and return the sum of the ints as an int 
   static int Addem(int num1, int num2)
   {
       Console.WriteLine("Addem(int, int) was called with "  + num1 + " " + num2);
       return num1 + num2; // Add the two parameters and return the sum
   }
   static double Addem(double num1, double num2)
   {
       Console.WriteLine("Addem(double, double) was called with "  + num1 + " " + num2);
       return num1 + num2; // Add the two parameters and return the sum
       //   double + double - result is a double 
       //  return type must be a double 
   }


}