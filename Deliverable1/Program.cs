using System;

public class OnHand {
    public static void Main()
    {

        //current stock
        int soda = 100;
        int chips = 40;
        int candy = 60;


        // restock values
        int rsoda = 40;
        int rchips = 20;
        int rcandy = 40;

        //Soda

        Console.WriteLine("How much sodas did you sell today? " + soda + " in stock.");
        int soda_sold = int.Parse(Console.ReadLine());
        if (soda - soda_sold < 0) { Console.WriteLine("Too High! Stock not adjusted." + Environment.NewLine); }
        else
        {
            soda = soda - soda_sold;
            Console.WriteLine("Remaining soda in stock is: " + soda + Environment.NewLine);
        }
        
        

        //Chips

        Console.WriteLine("How many chips did you sell today? " + chips + " in stock." );
        int chips_sold = int.Parse(Console.ReadLine());
        if (chips - chips_sold < 0) { Console.WriteLine("Too High!Stock not adjusted." + Environment.NewLine); }
        else
        {
            chips = chips - chips_sold;
            Console.WriteLine("Remaining chips in stock is: " + chips + Environment.NewLine);
        }
       

        //Candy

        Console.WriteLine("How many candies did you sell today? " + candy + " in stock." );
        int candy_sold = int.Parse(Console.ReadLine());
        if (candy - candy_sold < 0) { Console.WriteLine("Too High!Stock not adjusted." + Environment.NewLine); }
        else
        {
            candy = candy - candy_sold;
            Console.WriteLine("Remaining candy in stock is: " + candy + Environment.NewLine);
        }
        
        //Restock?
        Console.WriteLine("Thank you for filling out the values. Here’s what needs to be restocked:" + Environment.NewLine);
        if (soda <= rsoda) { Console.WriteLine("Soda needs to be restocked."); }
        if (chips <= rchips) { Console.WriteLine("Chips need to be restocked."); }
        if (candy <= rcandy) { Console.WriteLine("Candy needs to be restocked."); }

    }

}