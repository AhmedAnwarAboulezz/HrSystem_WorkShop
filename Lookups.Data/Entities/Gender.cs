using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Lookups.Data.Entities.Base;

namespace Lookups.Data.Entities
{
    public class Gender : BaseModel
    {
        [StringLength(50)]
        public string NameFl { get; set; }
        [StringLength(50)]
        public string NameSl { get; set; }
        public bool IsShown { get; set; }
    }
}
