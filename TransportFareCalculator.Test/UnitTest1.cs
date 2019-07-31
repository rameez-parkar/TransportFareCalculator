using System;
using TransportFareCalculator.App;
using Xunit;

namespace TransportFareCalculator.Test
{
    public class FareCalculatorTest
    {
        [Fact]
        public void BusModeAdultTicketTest()
        {
            var bus = new Bus(2, 5, "adult");
            var fareCalculator = new FareCalculator(bus);

            var expected = 10;
            var actual = fareCalculator.CalculateTotalFare();

            Assert.Equal(expected, actual, 2);
        }

        [Fact]
        public void BusModeChildTicketTest()
        {
            var bus = new Bus(2, 5, "child");
            var fareCalculator = new FareCalculator(bus);

            var expected = 5;
            var actual = fareCalculator.CalculateTotalFare();

            Assert.Equal(expected, actual, 2);
        }

        [Fact]
        public void RickshawModeTest()
        {
            var rickshaw = new Rickshaw(18, 10, 7);
            var fareCalculator = new FareCalculator(rickshaw);

            var expected = 88;
            var actual = fareCalculator.CalculateTotalFare();

            Assert.Equal(expected, actual, 2);
        }

        [Fact]
        public void TaxiModeTest()
        {
            var taxi = new Taxi(12, 10);
            var fareCalculator = new FareCalculator(taxi);

            var expected = 120;
            var actual = fareCalculator.CalculateTotalFare();

            Assert.Equal(expected, actual, 2);
        }
    }
}
