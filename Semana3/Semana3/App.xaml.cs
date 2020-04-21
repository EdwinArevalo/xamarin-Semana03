using Xamarin.Forms;

namespace Semana3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new StackLayoutCode();
            //MainPage = new AbsoluteLayoutExplorationCode();
            //MainPage = new GridDemo();
            //MainPage = new RelativeLayoutDemo();
            MainPage = new ScrollViewDemo();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
