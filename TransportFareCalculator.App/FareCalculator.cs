namespace TransportFareCalculator.App
{
    public class FareCalculator
    {
        private ITransportMode _transportMode;

        public FareCalculator(ITransportMode transportMode)
        {
            this._transportMode = transportMode;
        }

        public double CalculateTotalFare()
        {
            return _transportMode.CalculateTotalFare();
        }
    }
}
