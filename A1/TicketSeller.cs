class TicketSeller {

    private String name; 
    private int nrbOfAdults; 
    private int nbrOfChildren; 
    private double amountToPay;
    private double price = 100; 




private void TicketInput () {
    Console.WriteLine("Welcome to KIDS' FAIR!" + "\nChildren get always a 75% discount!");

    //Name 
    Console.WriteLine("Your name please");
    name = Console.ReadLine();
    
    // Amount of Adults 
    Console.WriteLine("Number of adults");
    nrbOfAdults = int.Parse(Console.ReadLine());

    // Amount of children
    Console.WriteLine("Number of children"); 
    nbrOfChildren = int.Parse(Console.ReadLine()); 
}


private void CalculateTickets () {
    amountToPay = price * nrbOfAdults + ((price * 0.25) * nbrOfChildren); 
}



private void ReceiptOutput () {
    Console.WriteLine("+++ Your receipt +++");
    Console.WriteLine("+++ Amount to pay = " + amountToPay);
    Console.WriteLine(); 
    Console.WriteLine("+++ Thank you "+name+ " and please come back! +++");
}



public void Start () {
    TicketInput(); 
    CalculateTickets(); 
    ReceiptOutput(); 
}


}