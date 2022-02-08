using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracker.Models
{
    /// <summary>
    /// Defines the structure of the tournamet
    /// </summary>
    public class TournamentModel
    {
        /// <summary>
        /// The unique id 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Tournament name 
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// The price that is paid for the entrance into the tournament 
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        ///  List of teams in the tournament
        /// </summary>
        public List<TeamModel> Enteredteams { get; set; }
        /// <summary>
        /// List of prizes for given tournament
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// The skeleton of the tournament
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
