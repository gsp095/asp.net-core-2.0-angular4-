﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Models
{
   public class User
    {
       
            [Key]
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string AdharNumber { get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }
        
    }
}
