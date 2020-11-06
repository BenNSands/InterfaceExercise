using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class SUV : ICompany, IVehicle
    {

        public int CargoHoldSpace { get; set; }
        public bool RoofRack { get; set; }


        public string Slogan { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CompanyName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int NumOfWheels { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Year { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int GasMileage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int NumOfSeats { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
