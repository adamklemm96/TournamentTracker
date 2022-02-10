using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracker.Models
{
    public class MatchupEntryModel
    {

        public int Id { get; set; }

        /// <summary>
        /// Represents one team in the matchup
        /// </summary>
       public int TeamCompetingId { get; set; }
        /// <summary>
        /// Represent the score for this particular team.
        /// </summary>
        

        public TeamModel TeamCompeting { get; set; }

        public double Score { get; set; }
        /// <summary>
        /// Represents the matchup that this team came 
        /// from as the winner
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }

        public int ParentMatchupId { get; set; }
    }
}
