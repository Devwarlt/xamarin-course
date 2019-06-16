namespace Sample4.ViewModels {
    public class StudentModel {
        public long Id { get set; }
        public string Name { get; set; }
        public string Shift { get; set; }
        public bool Status { get; set; }
    }

    public class StudentViewModel : BaseViewModel {
        public ObservableCollection<StudentModel> Students;

        public ObservableCollection<StudentModel> LoadStudents () {
            Students = new ObservableCollection<StudentModel> ();
            Students.Add (new StudentModel () {
                Name = "Name 1",
                    Shift = "Morning"
            });
            Students.Add (new StudentModel () {
                Name = "Name 2",
                    Shift = "Afternoon"
            });
            Students.Add (new StudentModel () {
                Name = "Name 3",
                    Shift = "Night"
            });

            return Students;
        }
    }
}