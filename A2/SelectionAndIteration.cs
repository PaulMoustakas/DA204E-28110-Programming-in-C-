

class SelectionAndIteration {

    public SelectionAndIteration () {

        Console.Clear(); 
        Console.WriteLine();
        Console.WriteLine("My name is: Paul I am a student of the 6th Semester (VT19)");
        Console.WriteLine();

        ShowStringLenght();
    }



    /*
        Method to read and respond
        Take a String input and provides the same string in capital and the amount of characters.
    */
    private void ShowStringLenght () {
        Console.WriteLine("Let me calculate the lenght of strings for you");
        
        String x;
        do {
            
            Console.WriteLine("Give me a text of any lenght, or press Enter to exit!");
            Console.WriteLine();
            x = Console.ReadLine();
           
            if (x != "") {
                Console.WriteLine("\n" + x.ToUpper()); 
                Console.WriteLine("Number of chars = " + x.Length + "\n");
            }

        } while (x != ""); 

        Console.WriteLine("OK. You pressed Enter. See you again!"); 
    }
}