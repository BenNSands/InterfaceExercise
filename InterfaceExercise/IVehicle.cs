using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    interface IVehicle
    {

        public int NumOfWheels { get; set; }
        public int Year { get; set; }
        public int GasMileage { get; set; }
        public int NumOfSeats { get; set; }

    }
}
