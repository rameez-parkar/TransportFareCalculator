using System;

namespace TransportFareCalculator.App
{
    public class Bus : ITransportMode
    {
        private double _stage;
        private double _farePerStage;
        private string _ageBracket;

        public Bus(double stage, double farePerStage, string ageBracket)
        {
            this._stage = stage;
            this._farePerStage = farePerStage;
            this._ageBracket = ageBracket;
        }

        double ITransportMode.CalculateTotalFare()
        {
            double totalFare;
            if (_ageBracket.Equals("adult"))
            {
                totalFare = _stage * _farePerStage;
            }
            else if(_ageBracket.Equals("child"))
            {
                totalFare = (_stage * _farePerStage) * 0.5;
            }
            else
            {
                throw new NotImplementedException();
            }
            return totalFare;
        }
    }
}
