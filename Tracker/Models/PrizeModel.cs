using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracker.Models
{
    /// <summary>
    /// Represents the prize for the given tournament and place
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// THe unique identifier for the prie
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The place or numeric order of the prize 
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// The name of the prize
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Money paid for the prize - it might be defined via ammount
        /// or Percentage
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Percantage of money paid for the place
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {

        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;

        }
    }
}
