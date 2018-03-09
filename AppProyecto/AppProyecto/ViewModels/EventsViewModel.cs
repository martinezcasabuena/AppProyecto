using AppProyecto.Models;
using AppProyecto.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppProyecto.ViewModels
{
    public class EventsViewModel : BaseViewModel
    //public class EventsViewModel : INotifyPropertyChanged
    {

        public ObservableCollection<EventPlan> Items { get; set; }
        public Command LoadItemsCommand { get; set; }

       // public event PropertyChangedEventHandler PropertyChanged;

        public EventsViewModel()
        {

            Items = new ObservableCollection<EventPlan>();
            //LoadItemsCommand = new Command(async () => await ExecuteLoadEventsCommand());
            ExecuteLoadEventsCommand();


            // Here you can have your data form db or something else,
            // some data that you already have to put in the list
            /*Items = new ObservableCollection<Event>() {
                new Event()
                {
                    eventId = 1,
                    title = "Tesla Model S",
                    description = "Descripcion de prueba 1!",
                    image = "",
                    date = "04/05/2018"
                },
                  new Event()
                {
                    eventId = 2,
                    title = "Audi R8",
                    description = "Descripcion de prueba 2!",
                    image = "",
                    date = "04/05/2018"
                },

            };*/
        }

        async Task ExecuteLoadEventsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Items.Clear();
                // Web service call to update list with new values
                await MyHTTP.GetAllNewsAsync(list =>
                {
                    foreach (EventPlan item in list)
                        Items.Add(item);
                });
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}