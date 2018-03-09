using System;

using AppProyecto.Models;

namespace AppProyecto.ViewModels
{
    public class EventPlanDetailViewModel : BaseViewModel
    {
        public EventPlan EventPlan { get; set; }
        public EventPlanDetailViewModel(EventPlan eventPlan = null)
        {
            Title = eventPlan?.title;
            EventPlan = eventPlan;
        }
    }
}
