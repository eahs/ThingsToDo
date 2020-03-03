using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DoingThing.Services;
using DoingThing.Views;
using Plugin.SimpleAudioPlayer;
using System.Reflection;

namespace DoingThing
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        public static void Player()
        {
            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            if (player.IsPlaying == false)
            {
                player.Load("LaDanseMacabre.mp3");
                player.Play();
                player.Loop = true;
            }
            else player.Stop();
        }
        public static bool Toggle(bool current)
        {
            if (current == false)
            {
                return true;
            }
            else return false;
        }

        public static void DarkMode()
        {

        }
        protected override void OnStart()
        {

        }

        private object GetStreamFromFile(string filename)
        {
            var assembly = typeof(App).GetTypeInfo().Assembly;
            var stream = assembly.GetManifestResourceStream("DoingThing" + filename);
            return stream;
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

    }
}
