
class MainProgram {
    

    static void Main(string [] args ) {


        PrepareConsoleLook();
        // Select and Iterate 
        SelectionAndIteration selectionAndIteration = new SelectionAndIteration ();
        Console.WriteLine(); 


        Console.WriteLine("Press Enter to start next part!"); 
        Console.ReadLine(); 


        // MakeMyday 
        MakeMyDaty makeMyDaty = new MakeMyDaty(); 
        Console.WriteLine("Press Enter to start next part!");
        Console.ReadLine(); 


        // Sum of numbers
        SumNumbers sumNumbers = new SumNumbers(); 
        Console.WriteLine(); 



        // Temprature converter
        Console.WriteLine("Press Enter to start the Temprature Converter!");
        Console.ReadLine(); 
        TemperatureConverter temperatureConverter = new TemperatureConverter(); 

        PrepareConsoleLook(); 

    }


    static void PrepareConsoleLook () {
        Console.BackgroundColor = ConsoleColor.White; 
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Black; 
    }
} 