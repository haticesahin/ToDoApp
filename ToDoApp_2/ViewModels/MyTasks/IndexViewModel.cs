using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToDoApp_2.Models;

namespace ToDoApp_2.ViewModels.MyTasks
{
    public class IndexViewModel
    {
        public List<Users> Kisiler { get; set; }
        public List<Tasks> Gorevler { get; set; }
    }
}