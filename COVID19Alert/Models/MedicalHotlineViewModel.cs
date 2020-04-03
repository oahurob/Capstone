using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COVID19Alert.Models
{
    public class MedicalHotlineViewModel
    {
        public MedicalHotline MedicalHotline { get; set; }
        public RegisteredUser RegisteredUser { get; set; }
        public List <MedicalHotline> MedicalHotlines { get; set; }
    }
}
