using Xamarin.Forms;
using PropertyChanged;
using FreshMvvm;
using System;

namespace XamarinPOC
{
    [ImplementPropertyChanged]
    public class ActionPageModel : FreshBasePageModel
    {
        IDatabaseService _dataService;

        public ActionPageModel(IDatabaseService dataService)
        {
            _dataService = dataService;

            this.WhenAny(HandleContactChanged, o => o.Action);
        }

        void HandleContactChanged(string propertyName)
        {
            //handle the property changed, nice
        }

        public Models.Action Action { get; set; }

        public override void Init (object initData)
        {
            if (initData != null) {
                Action = (Models.Action)initData;
            } else {
                Action = new Models.Action();
            }
        }
    }
}
