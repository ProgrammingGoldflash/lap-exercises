using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.DatabaseListing.DTOs
{
    public class TableColumn
    {
        public string Name { get; set; }
        public string DataType { get; set; }
        public string Nullable { get; set; }
    }
}
