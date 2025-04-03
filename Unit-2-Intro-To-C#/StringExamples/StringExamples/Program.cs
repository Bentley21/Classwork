namespace StringExamples;

class Program
{
    static void Main(string[] args)
    {
        /*******************************************************
         * Strings in C# are a special data type - they don't work like you think they should
         *
         * String literals are enclosed in " "
         *
         * A literal is something that says what it is: 1 1.24 "Bob"
         *
         * string variables sometimes require special processing
         *        you can't use < > to compare strings
         *        Beware; Early versions of C# do not allow use of == with strings
         *
         * C# provides severa methods to operate on strings:
         *
         *      .Equals(string) -compare the string to the left of the . to the string inside ()
         *      .CompareTo(string) - return a number indicating how the first string relates to the second
         *                           return a negative number if the first string is less than a second
         *                           return a zero of the first string is equal to the second
         *                           return a positve number if the string is greater than the second
         *******************************************************/
        // if (condition) {
        //    What to do if condition is true
        // }
        // else {
        // What to do if condition is true
        // }
        string string1 = "a";
        string string2 = "b";
        if (string1.CompareTo(string2) < 0) // if these are equal
        {
            Console.WriteLine("string1 is less than string2");
        }
        else
        {
            Console.WriteLine("string1 is no less than string2");
        }
        
        
    } // End of Main()
}