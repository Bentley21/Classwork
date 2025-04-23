namespace Day_1_Student_Class_Example;
// internal attribute so we can use the class 
// public - anyone can use this class 
// class - this is the definition of a C# class
// Student - name of the class - Classname are in PacalCase

// A class is a description of an object used in object oriented programming
// A class contains data (class member/ class data and methods (class methods)
// A class is a programmer defined data type (much like in, string, double, List<>)
// Because it is a PROGRAMMER defined data type, the programmer is responsible for:
//
//      the data in the class
//      the methods that manipulate the class data
//
//  class can do whatever a programmer decides it should or shouldn't do
public class Student
{
    // Define the data for our class
    // private indicates only members of the class can access the data
    // private implements the Object-Oriented principle of Encapsulation
    // Encapsulation - class should protect the data from outside access
    //                 only methods in the class can access the data
    //
    //                 Users of the class access the data using methods
    //                 defined in the class
    //
    // Note: the data is defined without an initial value 
    //      class data should be initialized in constructors
    // (data should never be uninitialized - the starting value needs to be known)
    
    // a constructor method is special because:
    //
    // 1. it has no return type; not even void
    // 2. it has the same name as the Class
    // 3. it may or may not receive parameters (initializers)
    //      ( a constructor to initialize our data with values 
    //      specified by the user
    
     public Student(string name, List<int> scores, out string studentName, out List<int> testScores)
     {
         studentName = name;
         testScores = scores;
     }

     //Define methods for the class
    //One special methods for a class is called constructor
    // A constructor is Responsible for initializing the data in a class
    // (data 
    public void ShowStudent()
    {
        Console.WriteLine("Name: " + studentName);
        Console.WriteLine("");
    }
}