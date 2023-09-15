using System;
using System.Collections.Generic;
using System.Text;
using PDC60.Model;

namespace PDC60.ViewModel
{
    internal class TaskViewModel
    {
        public TaskModel TaskModelSet { get; set; }

        public TaskViewModel()
        {
            TaskModelSet = new TaskModel
            {
                Subjectcode = "PDC06",
                SubjectTitle = "Xamarin Mobile Programming",
                Unit = 3,
            };
        }
    }
}
