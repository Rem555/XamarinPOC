using System;
using Xamarin.Forms;
using PropertyChanged;
using System.Collections.ObjectModel;
using FreshMvvm;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Windows.Input;

namespace XamarinPOC
{
    [ImplementPropertyChanged]
    public class ActionListPageModel : FreshBasePageModel
    {
        IDatabaseService _databaseService;

        public ActionListPageModel(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public ObservableCollection<Models.Action> Actions { get; set; }

        public ObservableCollection<Models.Action> CarouselActions { get; set; }

        public override void Init (object initData)
        {
            Actions = new ObservableCollection<Models.Action>(_databaseService.GetActions());
            CarouselActions = new ObservableCollection<Models.Action>(_databaseService.GetActions());
        }

        protected override void ViewIsAppearing (object sender, EventArgs e)
        {
            base.ViewIsAppearing(sender, e);
        }

        Models.Action _selectedAction;

        public Models.Action SelectedAction
        {
            get
            {
                return _selectedAction;
            }
            set
            {
                _selectedAction = value;
                if (value != null)
                    ActionSelected.Execute(value);
            }
        }

        public Command<Models.Action> ActionSelected
        {
            get
            {
                return new Command<Models.Action>(async (action) => {
                    await CoreMethods.PushPageModel<ActionPageModel>(action);
                });
            }
        }
    }
}