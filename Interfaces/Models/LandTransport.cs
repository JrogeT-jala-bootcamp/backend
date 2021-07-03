using Exersice.Models.Interfaces;

namespace Exercise.Models
{
    class LandTransport : Transport, ILandTransportHabilities
    {
        public byte NumberOfWheels { get; set; }

        public void HandleOnLand()
        {
            // Land transport is handled on land
        }
    }
}
