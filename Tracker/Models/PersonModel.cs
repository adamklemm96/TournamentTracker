using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracker.Models
{
    /// <summary>
    /// Represents a single person in a match
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// Represents FirstName of a Person 
        /// </summary>
        /// 
        public int Id { get; set; }
        public string FirstName { get; set; }
        /// <summary>
        /// The Last name of the person
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Email address of the person
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// The primary cell phone number of the person 
        /// </summary>
        public string CellphoneNumber { get; set; }


        public string FullName
        {
            get
            {
                return $"{ FirstName} {LastName}";
            }
        }

    }
}
