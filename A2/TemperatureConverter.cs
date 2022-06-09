


class TemperatureConverter {

    public TemperatureConverter () {

        Console.Clear();
        Start(); 

    }


    private double CelsiusToFarenheit (Double celsius) {
        double farenheit = 9/5.0 * celsius + 32;
        return farenheit; 
    }


    private double FarenheitToCelsius (Double farenheit) {
        double celsius = 5/9.0 * (farenheit - 32); 
        return celsius; 
      
    }


    private void ShowMenu () {
        Console.WriteLine("--------------------");
        Console.WriteLine(); 
        Console.WriteLine("TEMPRATURE CONVERTER");
        Console.WriteLine(); 
        Console.WriteLine("--------------------");

        Console.WriteLine(); 
        Console.WriteLine("Celsius to Fahrenheit \t: 1"); 
        Console.WriteLine("Fahrenheit to Celsius \t: 2"); 
        Console.WriteLine("Exit \t\t\t: 0");
        Console.WriteLine(); 
        Console.WriteLine("--------------------");
    }


    private void ShowTableCelsiusToFahrenheight () {

        Console.WriteLine("Your choice: 1");
        const int max = 100;   
        
        for (int i = 0; i <= max; i += 4) {
            Console.WriteLine(i+ " C = " + CelsiusToFarenheit(i).ToString("0.00") + " F");
        }
    }



    private void ShowTableFahrenheightToCelsius () {
        
        Console.WriteLine("Your choice: 2");
        const int max = 212;   
        
        for (int i = 0; i <= max; i += 10) {
            Console.WriteLine(i+ " F = " + FarenheitToCelsius(i).ToString("0.00") + " C");
        }

    }


    public void Start () {

        int input = -1; 

        while (input != 0) {
            ShowMenu(); 
            input = int.Parse(Console.ReadLine());

            switch (input) {

                case 1:
                ShowTableCelsiusToFahrenheight();
                break; 

                case 2:
                ShowTableFahrenheightToCelsius(); 
                break;

                case 0:
                Console.WriteLine("Thanks and welcome back!"); 
                break; 

                default:
                Console.WriteLine("Not a valid input, try again!");
                break;
            }
        }

              Console.WriteLine("Bye!");
    }
}


