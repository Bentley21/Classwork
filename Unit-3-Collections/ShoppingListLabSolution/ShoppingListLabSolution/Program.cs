namespace ShoppingList;

class Program
{
    static void Main(string[] args)

    {
        Dictionary<string, decimal> menu = new Dictionary<string, decimal>()
        //Display 8 items names and prices 
        {
            {"apple", 0.99m},
            {"banana", 0.59m},
            {"cauliflower", 1.59m},
            {"dragonfruit", 2.19m},
            {"elderberry", 1.79m},
            {"figs", 2.09m},
            {"grapefruit", 1.99m},
            {"honeydew", 3.49m}
        };
        
        List<string> shoppingList = new List<string>();
        string userResponse;
        
        Console.WriteLine("Welcome to Chirpus Market!");
        
        do
        {

            // ask the user for a menu item
            Console.WriteLine("What item would you like to order?: ");
            string itemName = Console.ReadLine();
            Console.WriteLine("Enter Item Price: ");
            decimal itemPrice = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Do you want to add another? (y,n)");
            userResponse = Console.ReadLine().ToLower();
            if (userResponse == "y" || userResponse == "n") ;
            {
                Console.WriteLine("Sorry we only accept 'y' or 'n'");
                
            }

        } while (userResponse == "y"); // Loop while they are not done 

        foreach (KeyValuePair<string, decimal> item in menu)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }

    }
}
