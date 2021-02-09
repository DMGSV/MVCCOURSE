using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HundaiService.Models
{
    public class Car
    {
        public string Brand { get; set; }
        [StringLength(15, MinimumLength = 1, ErrorMessage = "Must be max 15 symbols")]
        public string Model { get; set; }
        [StringLength(15, MinimumLength = 1, ErrorMessage = "Must be max 15 symbols")]
        public string BodyModel { get; set; }
    }
}