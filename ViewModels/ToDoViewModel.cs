using MVVM_API_SampleProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_API_SampleProject.ViewModels
{
    public class ToDoViewModel
    {
        public ToDo ToDo { get; set; }

        public ToDoViewModel()
        {
            ToDo = new ToDo()
            {
                UserId = 1,
                Id = 2,
                Title = "delectus aut autem",
                Completed = true
            };
        }
    }
}
