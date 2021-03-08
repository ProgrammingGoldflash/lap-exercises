using System.Collections.Generic;

namespace Blazor.MovieManagement.Database.Models
{
    public class Actor : BaseModel
    {
        #region Public Properties

        public string CountryOfOrigin { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }

        #endregion Public Properties
    }
}