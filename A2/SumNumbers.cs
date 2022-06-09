
class SumNumbers {


    public SumNumbers () {

        Console.Clear(); 
        Console.WriteLine();
        Console.WriteLine("Hello, it's time for some math!"); 
        Console.WriteLine();

        Sum(); 
        
    }



    public void Sum () {

        int a, b, c = 0;
        String x; 
        
        Console.Write("Give start number: ");

        x = Console.ReadLine();
        if (!x.Equals("")) {
        a = int.Parse(x);
 
        Console.Write("Give end number: ");
        b = int.Parse(Console.ReadLine());

        if (a > b) {
            c = a; 
            a = b;
            b = c;
            c = 0; 
        }
    
        for (int i = a; i <= b; i++) {
            c += i; 
        }

        Console.WriteLine("\nThe sum of numbers between " +a+ " and " +b+ " is " + c);
       
        }

    }
}