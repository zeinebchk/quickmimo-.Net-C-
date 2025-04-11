using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace quickmimo.Entities
{
    public class MYTask
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string title { get; set; }
        [Required]
        public string description { get; set; }
        public DateTime startdate { get; set; }
        public DateTime deadline { get; set; }
        public int RememeberNotification { get; set; }
        public string status { get; set; }
        [ForeignKey("user")]
        public int userId { get; set; }
        public User user { get; set; }
    }
}
