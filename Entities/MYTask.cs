using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace quickmimo.Entities
{
    internal class MYTask
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string title { get; set; }
        [Required]
        public string description { get; set; }
        public DateTime ddeadline { get; set; }
        public int RememeberNotification { get; set; }
        public string status { get; set; }
        public int servings { get; set; }
        [ForeignKey("user")]
        public int? userId { get; set; }
        public User user { get; set; }
    }
}
