namespace Peluqueria.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();
            LoadApplication(new Peluqueria.App());
        }
    }
}