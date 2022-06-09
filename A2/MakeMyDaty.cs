

class MakeMyDaty {

    public MakeMyDaty () {

        Console.Clear(); 
        Console.WriteLine();
        Console.WriteLine("Hello and welcome to Make My Daty, or Date? or Day? Anyhow, I can predict a day for you.");
        Console.WriteLine();

        PredictDay();
        Console.WriteLine();

    }


    private void PredictDay () {
        
        String x;
        String y; 
    
        Console.WriteLine("Give me a number between 1 and 7");
        Console.WriteLine();
        

        x = Console.ReadLine();

        if (x != "") {

        switch (Convert.ToInt16(x)) {
  
        case 1:
            Console.WriteLine("Monday: Keep calm! You can fall apart!");
            break;
  
        case 2:
            Console.WriteLine("Thuseday and Wednsday break your heart!");
            break;

        case 3:
            Console.WriteLine("Thuseday and Wednsday break your heart!");
            break;

        case 4:
            Console.WriteLine("Thursday, Uuush, still one day to Friday");
            break;

        case 5:
            Console.WriteLine("It's Friday! You are in love!");
            break;

        case 6:
            Console.WriteLine("Saturday, do nothing and do plenty of it");
            break;  
        
        case 7:
            Console.WriteLine("ANd Sunday always comes too soon!");
            break;  

        case 8:
            Console.WriteLine("case 9");
            break;  

        default:
            Console.WriteLine("Ehm, " + x + "days? Tired today?" );
            break;
        }
        }
    }

}