using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HundaiService.Models
{
    public class Offer
    {
        
        public int ClientId { get; set; }
        
        [Required]
        [StringLength(60, MinimumLength = 1, ErrorMessage = "Must be max 60 symbols")]
        public string ClientInfo { get; set; }
        
        [Required]
        [StringLength(60, MinimumLength = 1, ErrorMessage = "Must be max 60 symbols")]
        public string Bank { get; set; }
        
        [Required]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "Must be max 20 symbols")]
        public string Account { get; set; }
        
        public string Comment { get; set; }
        
        [Required]
        [StringLength(60, MinimumLength = 1, ErrorMessage = "Must be max 60 symbols")]
        public  string Customer { get; set; }
        
        [Required]
        [StringLength(15, MinimumLength = 1, ErrorMessage = "Must be max 15 symbols")]
        public int Price { get; set; }

        public int OfferId { get; set; }

        [Column(TypeName = "StartDate2")]
        [DataType(DataType.Date)]
        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime StartDate { get; set; }

        public bool Sign { get; set; }
    }
}