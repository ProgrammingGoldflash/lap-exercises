namespace Blazor.DoctorsOffice.Database.Models
{
    public class Diagnosis : BaseModel
    {
        #region Public Properties

        public virtual Disease Disease { get; set; }
        public int DiseaseId { get; set; }
        public string Title { get; set; }

        #endregion Public Properties
    }
}