using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lend_CRUD.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }
        public string ExpenseName { get; set; }
        [Required]
        [Range(1,int.MaxValue,ErrorMessage ="Amount must be greater than 0!")]
        public int Amount { get; set; }
    }
}
