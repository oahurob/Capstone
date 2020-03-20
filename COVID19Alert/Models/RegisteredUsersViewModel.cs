using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COVID19Alert.Models
{
    public class RegisteredUsersViewModel
    {
        public Age Age { get; set; }
        public Address Address { get; set; }
        public HouseHold HouseHold { get; set; }
        public RegisteredUser RegisteredUser { get; set; }
    }
}
