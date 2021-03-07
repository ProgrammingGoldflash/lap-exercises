using System;

namespace Blazor.DoctorsOffice.Database.Models
{
    public class PatientDiagnosis : BaseModel
    {
        #region Public Properties

        public virtual Diagnosis Diagnosis { get; set; }
        public int DiagnosisId { get; set; }
        public virtual Patient Patient { get; set; }
        public int PatientId { get; set; }
        public DateTime Visit { get; set; }

        #endregion Public Properties
    }
}