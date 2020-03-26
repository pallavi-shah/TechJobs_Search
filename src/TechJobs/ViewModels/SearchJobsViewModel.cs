using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TechJobs.Models;

namespace TechJobs.ViewModels
{
    public class SearchJobsViewModel : BaseViewModel
    {

        // The search results
        public List<Job> Jobs { get; set; }

        // The search value
        [Display(Name = "Keyword:")]
        public string Value { get; set; } = "";

        // TODO #7.1 - Extract members common to JobFieldsViewModel
        // to BaseViewModel

        //public JobFieldType Column { get; set; } = JobFieldType.All;  ---- MOVED  DECLARATION TO BASEVIEWMODEL CLASS & ASSIGNMENT TO CONSTRUCTOR

        // All columns, for display
        //public List<JobFieldType> Columns { get; set; }                   ---- MOVED TO BASEVIEWMODEL CLASS

        // View title
        //public string Title { get; set; } = "";                           ---- MOVED TO BASEVIEWMODEL CLASS

        public SearchJobsViewModel()
        {
            
            Column= JobFieldType.All;    // The column to search, defaults to all

            // Populate the list of all columns 

            /* Columns = new List<JobFieldType>();                           ---- MOVED TO BASEVIEWMODEL CLASS

             foreach (JobFieldType enumVal in Enum.GetValues(typeof(JobFieldType)))
             {
                 Columns.Add(enumVal);
             }*/
        }

    }
}
