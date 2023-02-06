﻿namespace CabInvoiceGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Cab Invoice Generator!");

            while (true)
            {
                Console.WriteLine("Please choose the option :\n1)Calculate Fare\n2)Aggregate Amount for Multiple Rides\n3)Enhanced Invoice");
                int option = Convert.ToInt16(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        InvoiceGenerator uc1 = new();
                        double fare1 = uc1.CalculateFare(10, 30);
                        Console.WriteLine("Total Fare the your Journey is :" + fare1);
                        break;
                    case 2:
                        InvoiceGenerator uc2 = new();
                        MultipleRides[] rides = { new MultipleRides(10, 20), new MultipleRides(15, 25) };
                        double totalfare = uc2.CalculateFare(rides);
                        Console.WriteLine("Aggregate value for Multiple rides is :" + totalfare);
                        break;
                    case 3:
                        InvoiceGenerator uc3 = new();
                        MultipleRides[] rides1 = { new MultipleRides(10, 20), new MultipleRides(15, 25) };
                        double totalFare = uc3.CalculateFare(rides1);
                        int numOfRides = uc3.count;
                        double avg = totalFare / numOfRides;
                        Console.WriteLine("Total Number of rides : " + numOfRides);
                        Console.WriteLine("Aggregate fare Value for day is :" + totalFare);
                        Console.WriteLine("Average of all the rides :" + avg);
                        break;
                    default:
                        Console.WriteLine("Please choose the correct option!");
                        break;
                }
            }
        }
    }
}