using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ToDoApp_2.Models
{
    [Table("Tasks")]
    public class Tasks
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public int UserID { get; set; }

        [Required]
        public string Task { get; set; }

        [StringLength(100)]
        public string Text { get; set; }
      //  public bool IsCompleted { get; set; }
     //   public DateTime DueDate { get; set; }

        public virtual List<Users> Kisiler { get; set; }
    }
}