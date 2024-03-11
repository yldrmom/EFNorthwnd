using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFNorthwnd.Models.ORM
{
    public class Category:BaseModel
    {
        public string CategoryName { get; set; }
        [MaxLength(15)]
        public string? Description { get; set; }

        public byte[]? Picture { get; set; }
    }
}
