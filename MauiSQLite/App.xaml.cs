using MauiSQLite.MVVM.Views;
using MauiSQLite.Services;

namespace MauiSQLite
{
    public partial class App : Application
    {
        public App(IAgendaService agendaService)
        {
            InitializeComponent();

            MainPage = new NavigationPage(new AgendaView(agendaService));
        }
    }
}