//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
import Pet.Pet;

import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        System.out.println("Welcome to Pet Management");


        // Instantiate a Pet
        Pet cat1 = new Pet(true, 30, 'M', "Cat", "James");

        cat1.displayPet();

        // Instantiate a Pet from User input - Java use Scanner for keyboard input
        Scanner theKeyboard = new Scanner(System.in); // Create a Scanner for the keyboard

        System.out.println("\nWhat is the namE of your pet?");
        String thePetName = theKeyboard.nextLine(); //nextLine() gets the a line from the keyboard

        System.out.println("\nWhat is the Type of your pet?");
        String thePetType = theKeyboard.nextLine(); //nextLine() gets the a line from the keyboard

        System.out.println("\nWhat is the gender of your pet?");
        String thePetGender = theKeyboard.nextLine(); //nextLine() gets the a line from the keyboard

        System.out.println("\nWhat is the weight of your pet?");
        String thePetWeight = theKeyboard.nextLine(); //nextLine() gets the a line from the keyboard

        System.out.println("\nIs you pet spayed?");
        String thePetSpay = theKeyboard.nextLine(); //nextLine() gets the a line from the keyboard

        // Instantiate a pet from user input
        // Convert the data required that is not a String to the right type
        char petGender = thePetGender.charAt(0);
        int petWeight = Integer.parseInt(thePetWeight);
        boolean petSpayed = false; // Assume pet is not spayed
        if (thePetSpay.equals("Y")) {
                petSpayed = true;
           //Pet pet1 = new Pet(thePetName, thePetType, petGender, petWeight, thePetSpay);
            //pet1.dispayPet();
        }
    }
}