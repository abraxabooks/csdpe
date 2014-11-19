using System;

namespace Chapter05
{
    public abstract class AbstractCar : AbstractVehicle
    {

        public AbstractCar(IEngine engine)
            : this(engine, VehicleColour.UNPAINTED)
        {
        }

        public AbstractCar(IEngine engine, VehicleColour colour)
            : base(engine, colour)
        {
        }

    }
}
