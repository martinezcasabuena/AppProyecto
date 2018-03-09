using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AppProyecto.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppProyecto.ViewModels;


namespace AppProyecto.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListEventsPage : ContentPage
	{
        EventsViewModel viewModel;

        public ListEventsPage ()
		{
            InitializeComponent();

            // Connecting context of this page to the our View Model class
            //BindingContext = new EventsViewModel();
            BindingContext = viewModel = new EventsViewModel();

        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as EventPlan;
            if (item == null)
                return;

            //await Navigation.PushAsync(new EventDetailPage());
            await Navigation.PushAsync(new EventPlanDetailPage(new EventPlanDetailViewModel(item)));



            // Manually deselect item.
            EventsListView.SelectedItem = null;
            //await DisplayAlert("Item Selected", args.SelectedItem.ToString(), "Ok");

        }

        void OnSelection(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return; //ItemSelected is called on deselection, which results in SelectedItem being set to null
            }
            DisplayAlert("Item Selected", e.SelectedItem.ToString(), "Ok");
            //((ListView)sender).SelectedItem = null; //uncomment line if you want to disable the visual selection state.
        }

    }
}