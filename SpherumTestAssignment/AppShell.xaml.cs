namespace SpherumTestAssignment
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(Views.ItemDetailPage), typeof(Views.ItemDetailPage));
            Routing.RegisterRoute(nameof(Views.FormPage), typeof(Views.FormPage));
        }
    }
}
