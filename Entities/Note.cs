using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quickmimo.Entities
{
    internal class Note
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string title { get; set; }
        [Required]
        public string description { get; set; }
        public DateOnly dateEvent { get; set; }
        public int Rappel { get; set; }
        public byte[] FileData { get; set; }

        [ForeignKey("user")]
        public int? userId { get; set; }
        public User user { get; set; }
        [ForeignKey("category")]
        public int? categotyId { get; set; }
        public Category category { get; set; }

    }
}
