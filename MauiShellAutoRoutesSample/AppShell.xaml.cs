namespace MauiShellAutoRoutesSample
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(Routes.SomePage, typeof(SomePage));
            Routing.RegisterRoute(Routes.Dashboard, typeof(Dashboard));
        }
    }
}
