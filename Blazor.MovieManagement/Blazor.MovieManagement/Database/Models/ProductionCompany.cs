using System.Collections.Generic;

namespace Blazor.MovieManagement.Database.Models
{
    public class ProductionCompany : BaseModel
    {
        #region Public Properties

        public string Name { get; set; }

        public ICollection<Movie> Movies { get; set; }

        #endregion Public Properties
    }
}