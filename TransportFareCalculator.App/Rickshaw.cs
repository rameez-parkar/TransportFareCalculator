namespace TransportFareCalculator.App
{
    public class Rickshaw : ITransportMode
    {
        private double _distance;
        private double _farePerKilometer;
        private double _defaultFare;

        public Rickshaw(double defaultFare, double distance, double farePerKilometer)
        {
            this._defaultFare = defaultFare;
            this._distance = distance;
            this._farePerKilometer = farePerKilometer;
        }

        double ITransportMode.CalculateTotalFare()
        {
            double totalFare = _defaultFare + (_distance * _farePerKilometer);
            return totalFare;
        }
    }
}
