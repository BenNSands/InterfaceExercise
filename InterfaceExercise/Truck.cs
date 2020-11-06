using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Truck : ICompany, IVehicle
    {

        public int CarryWeight { get; set; }
        public int BedSize { get; set; }


        public string Slogan { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CompanyName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int NumOfWheels { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Year { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int GasMileage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int NumOfSeats { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
