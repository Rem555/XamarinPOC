using PropertyChanged;
using System.Collections.Generic;

namespace XamarinPOC.Models
{
    [ImplementPropertyChanged]
    public class Action
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }
    }
}