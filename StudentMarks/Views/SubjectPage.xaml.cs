using StudentMarks.ViewModels;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StudentMarks.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SubjectPage : ContentPage
    {
        public List<StudentSubjectDTO> Subjects { get; private set; }

        public SubjectPage(List<StudentSubjectDTO> subjects)
        {
            InitializeComponent();
            Subjects = subjects;
            BindingContext = this;
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            StudentSubjectDTO selectedSubject = e.Item as StudentSubjectDTO;

            ((ListView)sender).SelectedItem = null;

            Navigation.PushAsync(new TestPage(selectedSubject));
        }
    }
}