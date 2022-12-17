using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcWorkspace.Models
{
    public class Expense
    {
        public int Id { get; set; }
        
        [DisplayName("Expense Name")]
        [Required]
        public string ExpenseName { get; set; }
        
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Amount must be greater than 0!")]
        public int Amount { get; set; }
    }
}
