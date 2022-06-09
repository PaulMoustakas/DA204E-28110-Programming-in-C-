class Pet {

    private String name;
    private int age;
    private bool isFemale = false;
    private String gender = "boy"; 


    private void PetInput () {
        //Name 
        Console.WriteLine("What is the name of your pet?");
        name  = Console.ReadLine();
        
        // Age
        Console.WriteLine("What is " + name + " age?");
        age =  int.Parse(Console.ReadLine());

        Console.WriteLine("Is your pet a female (y/n)?");
        String temp = Console.ReadLine(); 
        if (temp == "y") {
            isFemale = true;
        }

    }


    private void PrintPetInformation () {
        Console.WriteLine(); 
        Console.WriteLine("++++++++++++++++++++++++");
        Console.WriteLine("Name: " + name + " Age: " + age);
        
        if (isFemale) {
            gender = "girl"; 
        }
        Console.WriteLine(name + " is a good " + gender + "!"); 
        Console.WriteLine("++++++++++++++++++++++++"); 
    }


    public void Start () {
        PetInput(); 
        PrintPetInformation(); 
    }


}