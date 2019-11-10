using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ToDoApp_2.Models
{
    [Table("Users")]
    public class Users
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [StringLength(50),Required]
        public string Name { get; set; }

        [StringLength(50), Required]
        public string Surname { get; set; }

        [StringLength(50), Required]
        public string Username { get; set; }

        [Required]
        public string Eposta { get; set; }

        [Required]
        public string Password { get; set; }

        public virtual List<Tasks> Gorevler { get; set; }
    }
}