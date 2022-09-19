using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Webdemo1.Models
{
    /// <summary>
    /// san pham
    /// </summary>
    public class Product
    {
        public int ID { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string Name { get; set; }

        public int Price { get; set; }

        [Required]
        public int CategoryID { get; set; }

        public Category Category { get; set; }
    }
}
