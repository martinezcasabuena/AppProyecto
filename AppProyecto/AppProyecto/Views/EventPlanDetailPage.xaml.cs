using AppProyecto.Models;
using AppProyecto.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppProyecto.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EventPlanDetailPage : ContentPage
	{
        EventPlanDetailViewModel viewModel;

        public EventPlanDetailPage(EventPlanDetailViewModel viewModel)

		{
			InitializeComponent ();

            BindingContext = this.viewModel = viewModel;

        }

        public EventPlanDetailPage()
        {
            InitializeComponent();

            var item = new EventPlan
            {
                title = "Item 1",
                description = "This is an item description."
            };

            viewModel = new EventPlanDetailViewModel(item);
            BindingContext = viewModel;
        }
    }
}