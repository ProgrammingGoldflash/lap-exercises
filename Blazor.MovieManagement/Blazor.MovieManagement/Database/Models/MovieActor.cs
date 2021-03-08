namespace Blazor.MovieManagement.Database.Models
{
    public class MovieActor
    {
        #region Public Properties

        public virtual Actor Actor { get; set; }

        public int ActorId { get; set; }

        public virtual Movie Movie { get; set; }

        public int MovieId { get; set; }

        #endregion Public Properties
    }
}