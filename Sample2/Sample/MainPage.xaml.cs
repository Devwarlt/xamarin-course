namespace Sample {
    public partial class MainPage : ContentPage {
        private void changeEntryNameTextOnClick (object sender, EventArgs e) {
            entryName.Text = $"Age: {entry.Age.Text}";
        }

        private void TapGestureRecognizer_Tapped (object sender, EventArgs e) {
            var tConfig = new ToastConfig ("Toasting...") { BackgroundColor = Color.FromArgb (12, 131, 193) };
            tConfig.SetDuration (3000);
            UserDialogs.Instance.Toast (toastConfig);
        }
    }
}