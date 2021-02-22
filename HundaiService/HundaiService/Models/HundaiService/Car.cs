using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HundaiService.Models
{
    public class Car 
    {
        [Key]
        public int IdCar { get; set; }
        
        [Required]
        [StringLength(15, MinimumLength = 1, ErrorMessage = "Must be max 15 symbols")]
        public string Brand { get; set; }
        
        [Required]
        [StringLength(15, MinimumLength = 1, ErrorMessage = "Must be max 15 symbols")]
        public string Model {get; set; }
        
        [Required]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "Must be max 20 symbols")]
        public string BodyModel { get; set; }
        
        [Required]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "Must be max 20 symbols")]
        public string EngineId { get; set; }
        
        [Required]
        [StringLength(5, MinimumLength = 1, ErrorMessage = "Must be max 5 symbols")]
        public int Volume { get; set; }

        [Required]
        [StringLength(3, MinimumLength = 1, ErrorMessage = "Must be max 3 symbols")]
        public int Power { get; set; }

        public bool Helm { get; set; }

        public bool Drive { get; set; }

        public bool New { get; set; }
        
        [Required]        
        [StringLength(4, MinimumLength = 1, ErrorMessage = "Must be max 4 symbols")]
        public int Year { get; set; }
        
        [Required]
        [StringLength(6, MinimumLength = 1, ErrorMessage = "Must be max 6 symbols")]
        public int Distance { get; set; }
        
        [Column(TypeName = "DateStart2")]
        [DataType(DataType.Date)]
        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DateStart { get; set; }
    }
}