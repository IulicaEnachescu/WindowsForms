using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Book
    {
        public Book()
        {
            this.Authors = new HashSet<Author>();
        }
       
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Book title is required")]
        public string Title { get; set; }

        
        public int AuthorId { get; set; }
        [Required]
        [Range(1000, 2050, ErrorMessage = "Here should be given a valid year")]
        public int Year { get; set; }

        public Nullable<decimal> Price { get; set; }

        public virtual Author Author { get; set; }

        public virtual ICollection<Author> Authors { get; set; }

    }
}
