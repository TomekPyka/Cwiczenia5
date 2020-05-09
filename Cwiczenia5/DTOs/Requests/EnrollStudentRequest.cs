using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cwiczenia5.DTOs.Requests
{
    public class EnrollStudentRequest
    {
  
            [RegularExpression("^short[0-9]+$")]
            public string IndexNumber { get; set; }

            //[Range(1, 10)]
            //[Min(10)]
            //public int Age { get; set; }

            ////[Required]
            [MaxLength(10)] //VARCHAR(10)
            public string FirstName { get; set; }

            [Required]
            [MaxLength(255)] //VARCHAR(255)
            public string LastName { get; set; }

            public DateTime BirthDate { get; set; }

            [Required]
            public string Studies { get; set; }
        }
    }

