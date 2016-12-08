using Xamarin.Forms;
using FreshMvvm;
using PropertyChanged;
using System.Collections.ObjectModel;
using System;

namespace XamarinPOC
{

    public class MainMenuPageModel : FreshBasePageModel
    {
        public Command ShowQuotes {
            get {
                return new Command (async () => {
                    await CoreMethods.PushPageModel<QuoteListPageModel> ();
                });
            }
        }

        public Command ShowContacts {
            get {
                return new Command (async () => {
                    await CoreMethods.PushPageModel<ContactListPageModel> ();
                });
            }
        }

        public Command ShowActions
        {
            get
            {
                return new Command(async () => {
                    await CoreMethods.PushPageModel<ActionListPageModel>();
                });
            }
        }
    }
}

