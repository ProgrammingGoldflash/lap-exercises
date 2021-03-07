using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blazor.DoctorsOffice.Database.Models
{
    public class Patient : BaseModel
    {
        #region Public Properties

        [Column(TypeName = "Date")]
        public DateTime DateTime { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        /// <summary>
        /// social security number
        /// </summary>
        public int SSN { get; set; }

        #endregion Public Properties
    }
}