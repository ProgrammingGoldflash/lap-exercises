﻿using System.ComponentModel.DataAnnotations;

namespace Blazor.MovieManagement.Database.Models
{
    public class BaseModel
    {
        #region Public Properties

        [Key]
        public int Id { get; set; }

        #endregion Public Properties
    }
}