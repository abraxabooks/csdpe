using System;

namespace Chapter05
{
    public abstract class AbstractVan : AbstractVehicle
    {

        public AbstractVan(IEngine engine)
            : this(engine, VehicleColour.UNPAINTED)
        {
        }

        public AbstractVan(IEngine engine, VehicleColour colour)
            : base(engine, colour)
        {
        }

    }
}
