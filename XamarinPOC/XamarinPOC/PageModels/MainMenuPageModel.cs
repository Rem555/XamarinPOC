using Xamarin.Forms;
using FreshMvvm;

namespace XamarinPOC
{
    public class MainMenuPageModel : FreshBasePageModel
    {
        public MainMenuPageModel ()
        {
        }

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
    }
}

