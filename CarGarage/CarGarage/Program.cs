using System;

namespace CarGarage
{
    class Program
    {
        static void Main(string[] args)
        {

            Garage my = new Garage();
            my.AddCar("Ford", "Focus");
            my.AddCar("Chevy", "Silverado");
            my.AddCar("Audi", "R8");
            bool flag = true;
            Console.WriteLine("\t\t\t3 To create a car");
            Console.WriteLine("\t\t\t2 To print list of cars");
            Console.WriteLine("\t\t\t1 To select a car with ID");
            while (flag)
            {
                String input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("Type ID to select a car, press 2 to print all cars");
                        int index = Convert.ToInt32(Console.ReadLine());
                        Submenu(my.Select_Car(index));
                        break;
                    case "2":

                        my.ListAllCars();
                        Console.WriteLine("\t\t\t1 To select a car with ID");
                        break;
                    case "3":
                        Console.WriteLine("Please type Make and Model of your car");
                        string make = Console.ReadLine();
                        string model = Console.ReadLine();
                        
                        my.AddCar(make, model);

                        break;
                   

                    case "0":
                        flag = false;

                        break;
                    default:
                        Console.WriteLine("Something went wrong");
                        break;
                }

            }




        }
        static void Submenu(Car mycar)
        {
            bool flag = true;
            Console.WriteLine("\t\t\t 1 To start your car");
            while (flag)
            {
                
                Console.WriteLine("\t\t\t 2 To accelerate your car");
                Console.WriteLine(" \t\t\t3 To add fuel to your car ");
                Console.WriteLine(" \t\t\t4 To slow down your car");
                String input = Console.ReadLine();
                switch (input)
                {
                    case "1":  //start
                        Console.WriteLine("\t\t\t You started your car");
                        if (mycar.CarStarted)
                        { mycar.ToggleEngine(); }

                        else
                        {
                            mycar.ToggleEngine();
                        }
                        
                        break;
                    case "2": //accelerates
                        if (mycar.CarStarted == false)
                        {
                            Console.WriteLine("Hey your car is not running, press 1 to start your car");
                        }
                        else
                        { 
                        mycar.Accelerate();
                        Console.WriteLine("{0}  Current speed is  => {1}   Tank level is {2} ",mycar.Make ,mycar.Speed,mycar.GasLevel);
                        }
                        break;
                    case "3": //addes fuel
                        if (mycar.CarStarted == false)
                        {
                            Console.WriteLine("Hey your car is not running, press 1 to start your car");
                        }
                        else
                        {
                            Console.WriteLine(" You added fuel to your car");
                            mycar.AddFuel();
                            Console.WriteLine(" Gas level is {0}  ", mycar.GasLevel);
                        }
                        break;
                    case "4": //brake
                        if (mycar.CarStarted == false)
                        {
                            Console.WriteLine("Hey your car is not running press 1 to start your car");
                        }
                        else
                        {
                            Console.WriteLine(" You slowed down your car");
                            mycar.Brake();
                            Console.WriteLine("  Current  Speed  is {0} MPH => ",mycar.Speed);
                        }
                        break;
                    case "0":
                        flag = false;

                        break;
                    default:
                        Console.WriteLine("Something went wrong");
                        break;
                }

            }
        }
    }
}
