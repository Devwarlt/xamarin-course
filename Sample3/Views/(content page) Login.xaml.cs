namespace Sample3.Views {
    [XamlCompilation (XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage {
        private LoginViewModel lvm;

        public Login () {
            InitializeComponent ();
            lvm = new LoginViewModel ();
            BindingContext = lvm;
        }
    }
}