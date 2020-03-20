using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COVID19Alert.Models
{
    public class Age
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public int AgeOfSick { get; set; }
        public int AgeOfConfirmedCOVID19 { get; set; }
    }
}
