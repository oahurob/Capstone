using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace COVID19Alert.Models
{
    public class HouseHold
    {
        [Key]
        public int Id { get; set; }
        public int NumberOfResidents { get; set; }
        public int NumberOfSick { get; set; }
        public int NumberOfConfirmedCOVID19 { get; set; }
        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public Address Address { get; set; }
        [ForeignKey("Age")]
        public int AgeId { get; set; }
        public Age Age { get; set; }
    }
}
