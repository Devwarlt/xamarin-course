namespace Sample {
    public partial class MainPage : ContentPage {
        private void changeEntryNameTextOnClick (object sender, EventArgs e) {
            entryName.Text = $"Age: {entry.Age.Text}";
        }

        private async void TapGestureRecognizer_Tapped (object sender, EventArgs e) {
            // var tConfig = new ToastConfig ("Toasting...") { BackgroundColor = Color.FromArgb (12, 131, 193) };
            // tConfig.SetDuration (3000);
            // tConfig.SetPosition (ToastPosition.Top);
            // UserDialogs.Instance.Toast (toastConfig);

            // Suggestiong for synchronous methods or proces ONLY
            // using (UserDialogs.Instance.Loading("Loading")) {
            //     // code goes here
            // }

            // Suggestion for asynchronous / synchornous methods or processes
            // UserDialogs.Instance.ShowLoading ("Loading...", MaskType.Black);
            // await Task.Delay (TimeSpan.FromSeconds (10)); // await for 10 seconds then remove loading
            // UserDialogs.Instance.HideLoading ();

            await UserDialogs.Instance.AlertAsync ("Asynchronous alert.");
        }
    }
}