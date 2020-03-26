using System;
using System.Collections.Generic;
using TechJobs.Models;

namespace TechJobs.ViewModels
{
    public class JobFieldsViewModel : BaseViewModel
    {
        public IEnumerable<JobField> Fields { get; set; }

        // TODO #7.2 - Extract members common to SearchJobsViewModel
        // to BaseViewModel

        /* The current column
        //public JobFieldType Column { get; set; }    ---- MOVED TO BASEVIEWMODEL CLASS

        // All fields in the given column


        // All columns, for display
        //public List<JobFieldType> Columns { get; set; }     ----- MOVED TO BASEVIEWMODEL CLASS

        // View title
        //public string Title { get; set; } = "";       ---- MOVED TO BASEVIEWMODEL CLASS

        public JobFieldsViewModel()                     ----- MOVED TO BASEVIEWMODEL CLASS
        {
            // Populate the list of all columns

            Columns = new List<JobFieldType>();

            foreach (JobFieldType enumVal in Enum.GetValues(typeof(JobFieldType)))
            {
                Columns.Add(enumVal);
            }
        } */
    }
}
