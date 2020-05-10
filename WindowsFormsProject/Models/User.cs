using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class User
    {
        
        public int Id { get; set; }

       [Required (AllowEmptyStrings = false)]
       [StringLength(10)]
        public string UserName { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Parola { get; set; }
       
        public UserType UserType { get; set; }
        public int UserTypeId { get; set; }
        public Address Address { get; set; }
        public int AddressId { get; set; }
        
        [NotMapped]
        public string LoginErrorMessage { get; set; }

    }
}

