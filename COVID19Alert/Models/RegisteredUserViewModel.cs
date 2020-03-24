using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace COVID19Alert.Models
{
    public class RegisteredUserViewModel
    {
        public MedicalHotline MedicalHotline { get; set; }
        public RegisteredUser RegisteredUser { get; set; }
    }
}
