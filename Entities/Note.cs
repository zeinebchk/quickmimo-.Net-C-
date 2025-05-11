using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quickmimo.Entities
{
    public class Note
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Content { get; set; } = string.Empty;

        public DateTime DateCreated { get; set; } = DateTime.Now;

        public int Rappel { get; set; }

        [Required]
        public byte[] FileData { get; set; } = Array.Empty<byte>();

        // Relation avec User (correctement typée)
        [ForeignKey("UserId")]
        public User? User { get; set; }  // Navigation property PascalCase

        public int? UserId { get; set; }  // Clé étrangère nullable

        // Relation avec Category (corrigée)
        [ForeignKey("CategoryId")]
        public Category? Category { get; set; }  // Type référence

        public int? CategoryId { get; set; }  // Clé étrangère nullable

    }
}
