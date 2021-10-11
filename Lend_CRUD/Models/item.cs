using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Lend_CRUD.Models
{
    public class item
    {
        [Key]
        public int id { get; set; }
        public string lender { get; set; }
        public string borrower { get; set; }
        public string itemName { get; set; }
    }
}
