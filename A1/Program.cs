
class Program {
    

    static void Main(string [] args ) {


        PrepareConsoleLook();
        // Pet 
        Pet thePet = new Pet();
        thePet.Start(); 

        Console.WriteLine("Press Enter to start next part!"); 
        Console.ReadLine(); 


        // TicketSeller 
        TicketSeller theTicketSeller = new TicketSeller();
        theTicketSeller.Start();

        Console.WriteLine("Press Enter to start next part!");
        Console.ReadLine(); 


        // Album
        Album theAlbum = new Album(); 
        theAlbum.Start();
        Console.WriteLine(); 

        Console.WriteLine("Press Enter to start the Computer Quiz!");
        Console.ReadLine(); 

        PrepareConsoleLook(); 


        ComputerInfo theComputer = new ComputerInfo();
        theComputer.Start(); 



    }





    static void PrepareConsoleLook () {
        Console.BackgroundColor = ConsoleColor.White; 
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Black; 
        Console.Title = "KIDS' FAIR"; 
    }
} 