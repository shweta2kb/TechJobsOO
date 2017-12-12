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

        private string inputValue = "";
        [Display(Name = "Keyword:")]
        public string Value
        {
            get { return inputValue; }
            set
            {
                if (value != null) { inputValue = value; }
            }
        }
    }
}
