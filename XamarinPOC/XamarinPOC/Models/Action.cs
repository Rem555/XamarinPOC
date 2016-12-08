using PropertyChanged;

namespace XamarinPOC.Models
{
    [ImplementPropertyChanged]
    public class Action
    {
        public string Title { get; set; }

        public string Description { get; set; }
    }
}