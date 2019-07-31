namespace TransportFareCalculator.App
{
    public class Taxi : ITransportMode
    {
        private double _distance;
        private double _farePerKilometer;

        public Taxi(double distance, double farePerKilometer)
        {
            this._distance = distance;
            this._farePerKilometer = farePerKilometer;
        }

        double ITransportMode.CalculateTotalFare()
        {
            double totalFare = _distance * _farePerKilometer;
            return totalFare;
        }
    }
}
