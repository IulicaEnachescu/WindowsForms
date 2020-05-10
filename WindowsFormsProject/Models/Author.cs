using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public  class Author
    {
        public Author()
        {
            this.Books = new HashSet<Book>();

        }
   
        public virtual ICollection<Book> Books { get; set; }
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }


    }
}
