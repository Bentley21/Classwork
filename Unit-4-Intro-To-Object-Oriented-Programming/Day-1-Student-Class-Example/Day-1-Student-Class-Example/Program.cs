namespace Day_1_Student_Class_Example;

class Program
{
    
    // This is an application program
    // It instantiates and uses objects to perform processing
    // Every application has exactly one method called Main()
    
    
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Student Class Example");
    // Instantiate (define) a Student class object
    // A class is data type
    // Define an object of a class like any other variable with a slight difference
    
    // data-type name = initializer; int sum = 0;
    
    // A class is instantiated with the new keyboard
    //         is initialized using one of its constructors
    // className name = new className(initializers
    
    List<int> scores = new List<int>();
    scores.Add(100);
    scores.Add(90);
    scores.Add(80);
    
    // Instantiate a Student  using the data we want to store in the Student object
    Student aStudent = new Student("Frank", scores);

    //Display the Student 
    Console.WriteLine("Astudent: " + aStudent);

    }
}