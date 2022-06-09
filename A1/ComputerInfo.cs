
class ComputerInfo {
    private double points;
    
    private String OSQuest;
    private String Q1 = "Wrong"; 

    private int bitQuest;
    private String Q2 = "Wrong"; 

    private int processorCount; 
    private String Q3 = "Wrong"; 

    private DateTime date = DateTime.UtcNow.Date;


    private void ComputerQuiz () {
        Console.WriteLine("Welcome to the Computer Quiz!");
        Console.WriteLine("How much do you know about your machine? \nHit Enter when you are ready for the first question! "); 
        Console.ReadLine(); 
        
        Console.WriteLine("1. What Operating System do you use? (win/mac)");
        OSQuest = Console.ReadLine(); 

        Console.WriteLine("2. Is your "+OSQuest+ " OS a 32-bit or 64-bit? (32/64)");
        bitQuest = int.Parse(Console.ReadLine()); 

        Console.WriteLine("3. How many processors are there in your computer? (including splits)");
        processorCount = int.Parse(Console.ReadLine()); 
    }


    private void CalculatePoints() {
        
        // Question 1 (OS)
        if (OperatingSystem.IsWindows() && OSQuest=="win"){
            points =+ 1;
            Q1 = "Correct!"; 
        } 
        else if (OperatingSystem.IsMacOS() && OSQuest=="mac") {
            points =+ 1; 
            Q1 = "Correct!"; 
        }

        // Question 2 (OS-bits)
        if (Environment.Is64BitOperatingSystem && bitQuest==64) {
            points += 1;
            Q2 = "Correct!";  
        }
        else if (!Environment.Is64BitOperatingSystem && bitQuest==32) {
            points += 1; 
            Q2 = "Correct!"; 
        } 

        // Question 3 (Processor)
        if (Environment.ProcessorCount == processorCount) {
            points += 1; 
            Q3 = "Correct!";
            }
    }


    private void PrintQuizResults () {
        Console.WriteLine("\n");
        Console.WriteLine("+++ Results on Computer Quiz made "+ date.ToString("d") + "+++");
        Console.WriteLine("Question \tAnswer \tResult");
        Console.WriteLine("1. OS \t\t " +OSQuest + "\t" + Q1 );
        Console.WriteLine("2. Bits \t " +bitQuest + "\t" + Q2 );
        Console.WriteLine("3. Processor \t " +processorCount + "\t" + Q3 );
        Console.WriteLine("Your Scored " + points+"/"+"3\n");
    }


    public void Start() {
        ComputerQuiz();
        CalculatePoints(); 
        PrintQuizResults();
    }

}
