using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;


namespace quickmimo.Entities
{
    public class User
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public int telNumber { get; set; }
        public string proffession { get; set; }
        public string password { get; set; }

        public ICollection<MYTask> tasks { get; set; }
        public ICollection<Note> notes { get; set; }
        //[ForeignKey("category")]
        //public int? categoryId { get; set; }
        //public Category category { get; set; }

        public User() { }
        public User(string firstname, string lastname, int telNumber, string email, string password, string proffession)
        {
            this.firstName = firstname;
            this.lastName = lastname;
            this.telNumber = telNumber;
            this.email = email;
            this.password = password;
            this.proffession = proffession;
        }
    }
}
