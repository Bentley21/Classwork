// Every class in Java is part of a package
// First thing you do to create a new class is create a new package
//       then create the class inside the package
package Pet;
// This class will represent Pet info for a pet
// Data: Name of the Pet
//       Type of Pet (Dog, Cat, Lizard, etc.)
//       Gender
//       Weight
//       Is it spayed or neutered?
//
//      Behavior (methods)
//
//      1. You should always have at least one constructor to initialize the class
//         (usually you have a default ctor and a ctor that takes arguments)
//         a default ctor ( in case Java needs it; Java uses the default ctor
//                                                 behind the scenes if needed)
//         a least on ctor that takes arguments used to initialize the object
//
//      2. Getters and setters to allow access to private data members (Encapsulation)
//
//     3. Object method overrides to get the behavior you want from the methods:
//
//       toString() - Represent th class data as a String
//       equals()   - To determine if two objects of the class are equal based on their content
//                                 rather than based on their location in memory
//       hashCode() - To generate a hash code based on the content of the object not it's location in memory
//                    The same data members used in equals should be used in hashcode() so objects that are equal
//                    have equal hash code
//     4. Additional methods to support the class (e.g. display method)


import java.util.Objects;

public class Pet {
    //   Member Data - should be private to support Encapsulation
    private String petName;
    private String petType;
    private char   petGender;
    private int    petWeight;
    private boolean isSpayed;

    // Constructors - initialize objects instantiated for a class
    // Default ctor - define an empty object (we don't know default pet info)
    public Pet() {}     // ctor that takes no arguments and doesn't do anything

    // Ctor that initializes using arguments passed to the constructor
    public Pet(boolean isSpayed, int petWeight, char petGender, String petType, String petName) {
        // Why is this. used?
        // Because the parameter names are the same as the data member names
        //  this. is used to reference the data member and not the parameters


        this.isSpayed = isSpayed; // Copy the isSpayed parameter to the isSpayed data member
        this.petWeight = petWeight; // Copy the petWeight parameter to the petWeight data member
        this.petGender = petGender; // Copy the petGender parameter to the petGender data member
        this.petType = petType; // Copy the petType parameter to the petType data member
        this.petName = petName; // Copy the petName parameter to the petName data member
    }

    // Standard getters and setters to allow controlled access to private data members
    //
    // Standard names: getters - getVariableName      setters: setVariableName
    //                     boolean: variableName

    public String getPetName() {
        return petName;
    }

    public void setPetName(String petName) {
        this.petName = petName;
    }

    public String getPetType() {
        return petType;
    }

    public void setPetType(String petType) {
        this.petType = petType;
    }

    public char getPetGender() {
        return petGender;
    }

    public void setPetGender(char petGender) {
        this.petGender = petGender;
    }

    public int getPetWeight() {
        return petWeight;
    }

    public void setPetWeight(int petWeight) {
        this.petWeight = petWeight;
    }

    public boolean isSpayed() {
        return isSpayed;
    }

    public void setSpayed(boolean spayed) {
        isSpayed = spayed;
    }
    // Object method overrides
    //
    //
    //

    @Override // Ask the compiler to check to be sure this is valid override
    public String toString() {
        return "Pet{" +
                "petName='" + petName + '\'' +
                ", petType='" + petType + '\'' +
                ", petGender=" + petGender +
                ", petWeight=" + petWeight +
                ", isSpayed=" + isSpayed +
                '}';
    }

    @Override
    // equals receives a generic object - NOT an object of the class
    // We have to check or cast the generic object to an object of the class
    // Usage: aPet.equals(anotherPet) - in the method aPet  is assumed and o represents the other pet
    public boolean equals(Object o) {
        // An object called pet is instantiated as part of if
        if (o == null || getClass() != o.getClass()) return false;
        Pet pet = (Pet) o;
        return petGender == pet.petGender && petWeight == pet.petWeight && isSpayed == pet.isSpayed && Objects.equals(petName, pet.petName) && Objects.equals(petType, pet.petType);
    }

    @Override
    public int hashCode() { // uses the built-in hash(). method to generate a hash code using all data members
        return Objects.hash(petName, petType, petGender, petWeight, isSpayed);
    }

    // Additional methods to support the class

    public void displayPet(){
        System.out.println("Welcome to Pet Management");
    }


}
