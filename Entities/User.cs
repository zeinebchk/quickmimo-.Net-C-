using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;


namespace quickmimo.Entities
{
    internal class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string firstName { get; set; }
        [Required]
        public string lastName { get; set; }
        public string email { get; set; }
        public string proffession { get; set; }
        public TimeSpan password { get; set; }

        public ICollection<MYTask> tasks { get; set; }
        public ICollection<Note> notes { get; set; }
        //[ForeignKey("category")]
        //public int? categoryId { get; set; }
        //public Category category { get; set; }
    }
}
