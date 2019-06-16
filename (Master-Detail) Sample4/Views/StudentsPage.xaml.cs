namespace Sample4.Views {
    public class StudentsPage : ContentPage {
        private StudentsViewMode svm;

        public StudentsPage () {
            InitializeComponent ();
            svm = new StudentsViewMode ();
            BindingContext = svm;
            studentsList.ItemSource = svm.LoadStudents ();
        }
    }
}