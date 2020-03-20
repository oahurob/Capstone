using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace COVID19Alert.Models
{
    public class MedicalHotline
    {
        [Key]
        public int Id { get; set; }
        public string DoctorsName { get; set; }
        public string NursesName { get; set; }
        public int PhoneNumber { get; set; }
        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public Address Address { get; set; }
    }
}
