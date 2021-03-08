using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blazor.MovieManagement.Database.Models
{
    public class Movie : BaseModel
    {
        #region Public Properties

        public virtual ICollection<Actor> Actors { get; set; }
        public virtual ProductionCompany ProductionCompany { get; set; }

        public int ProductionCompanyId { get; set; }

        [Column(TypeName = "Date")]
        public DateTime ReleaseDate { get; set; }

        public string Title { get; set; }

        #endregion Public Properties
    }
}