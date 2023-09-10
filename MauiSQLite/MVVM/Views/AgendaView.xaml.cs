using MauiSQLite.MVVM.ViewModels;
using MauiSQLite.Services;

namespace MauiSQLite.MVVM.Views;

public partial class AgendaView : ContentPage
{
    //private readonly IAgendaService _service;
    public AgendaView(IAgendaService service)
	{
		InitializeComponent();
        //_service = service;
        BindingContext = new AgendaViewModel(service);
    }
}