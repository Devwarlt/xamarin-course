namespace Sample3.ViewModels {
    public partial class LoginViewModel : BaseViewModel {
        private const _email = "test@test.com";
        private const _password = "test";
        public string Email { get; set; }
        public string Password { get; set; }
        public ICommand LoginCmd { get; set; }

        public LoginViewModel () => LoginCmd = new Command (async () => {
            if (Login ().Result)
                await UserDialogs.Interface.AsyncAlert ("'Email' and 'Password' don't match!");
            else
                App.RedirectMain ();
        });

        public Task<bool> Login () {
            var email = Email;
            var password = Password;

            return ValidateFields ();
        }

        private bool ValidateFields () => Email.ToUpperInvariant ().Equals (_email) && Password.ToUpperInvariant ().Equals (_password);
    }
}