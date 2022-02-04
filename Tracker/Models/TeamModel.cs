using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracker.Models
{
    /// <summary>
    /// Defines the team
    /// </summary>
    public class TeamModel
    {
        public int Id { get; set; }
        /// <summary>
        /// List of all team members 
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();        
        /// <summary>
        /// Name of the team 
        /// </summary>
        public string TeamName { get; set; }
    }
}
