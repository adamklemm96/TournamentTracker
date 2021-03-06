using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracker.Models
{
    /// <summary>
    /// Represents one match in the tournament
    /// </summary>
    public class MatchupModel
    {
        public int Id { get; set; }

        /// <summary>
        /// The set of team that were involved in this match
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        public int WinnerId { get; set; }

        /// <summary>
        /// The winner of the match
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Whcich round this match is part of 
        /// </summary>
        public int MatchupRound { get; set; }

    }
}
