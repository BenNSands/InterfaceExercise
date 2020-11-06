using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //--TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //--Create 2 Interfaces called IVehicle & ICompany

            //--Create 3 classes called Car , Truck , & SUV

            //--In your IVehicle

            /* --Create 4 members that Car, Truck, & SUV all have in common.
             * --Example: All vehicles have a number of wheels... for now..
             */


            //--In ICompany

            /*--Create 2 members that are specific to each every company
             * --regardless of vehicle type.
             *
             *
             * --Example: public string Logo { get; set; }
             */

            //--In each of your car, truck, and suv classes

            /*--Create 2 members that are specific to each class
             * --Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * --Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //--Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            var porche = new Car() { CompanyName = "Porche", GasMileage = 40, NumOfSeats = 5, NumOfWheels = 4, Slogan = "Somethin bout being fancy IDK", TrailerCapability = false, TrunkSpace = 5, Year = 2018};
            var F250 = new Truck() { CompanyName = "Ford", GasMileage = 20, NumOfSeats = 5, NumOfWheels = 4, Slogan = "Be a BIG MAN TRUCK", Year = 2018, BedSize = 10, CarryWeight = 4000};
            var jeep = new SUV() { CompanyName = "Jeep", GasMileage = 30, NumOfSeats = 4, NumOfWheels = 4, Slogan = "My horn goes'Jeep-Jeep'", Year = 2018, CargoHoldSpace = 3, RoofRack = true};




        }
    }
}
