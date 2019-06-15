namespace Sample3 {
    public partial class App : Application {
        public void Start () {
            // MainPage = new MainPage();
            MainPage = new Login ();
        }

        public static void RedirectMain () => Current.MainPage = new MainPage ();
    }
}