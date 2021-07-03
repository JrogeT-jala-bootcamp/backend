using Exersice.Models.Interfaces;

namespace Exercise.Models
{
    class AirTransport : Transport, IAirTransportHabilities
    {
        public short MaximumHeight { get; set; }

        public void Fly()
        {
            // Air transport flies
        }

        public void Land()
        {
            // Air transport lands
        }
    }
}
