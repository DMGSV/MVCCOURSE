using System.ComponentModel.DataAnnotations;

namespace HundaiService.Models
{
    public class Filial
    {
        [Key]
        public int IdFilial { get; set; }
        
        public string FilialN { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "Must be max 20 symbols")]

        public string IrmFilial { get; set; }
        [Required]
        [StringLength(10, MinimumLength = 1, ErrorMessage = "Must be max 10 symbols")]

        public string Сhief { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 1, ErrorMessage = "Must be max 60 symbols")] 
        
        public string Phone { get; set; }
        [Required]
        [StringLength(10, MinimumLength = 1, ErrorMessage = "Must be max 10 symbols")] 

        public int Capacity { get; set; }
        [Required]
        [StringLength(3, MinimumLength = 1, ErrorMessage = "Must be max 10 symbols")] 

        public string Adress { get; set; }
    }
}