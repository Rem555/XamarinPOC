using System;
using Xamarin.Forms;
using System.ComponentModel;

namespace XamarinPOC
{
    public class BasePage : ContentPage
    {
        protected override void OnAppearing ()
        {
            base.OnAppearing ();

            var basePageModel = this.BindingContext as FreshMvvm.FreshBasePageModel;
            if (basePageModel != null) {
                if (basePageModel.IsModalAndHasPreviousNavigationStack ()) {
                    if (ToolbarItems.Count < 2)
                    {
                        var closeModal = new ToolbarItem ("Close Modal", "", () => {                
                            basePageModel.CoreMethods.PopModalNavigationService(); 
                        });

                        ToolbarItems.Add (closeModal);
                    }
                }
            }
        }
    }
}

