using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HundaiService.Models
{
    public class Car : IEnumerable
    {
        public int IDCar { get; set; }
        public string Brand { get; set; }
        [StringLength(15, MinimumLength = 1, ErrorMessage = "Must be max 15 symbols")]
        public string Model { get; set; }
        [StringLength(15, MinimumLength = 1, ErrorMessage = "Must be max 15 symbols")]
        public string BodyModel { get; set; }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}