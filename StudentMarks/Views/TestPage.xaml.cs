using StudentMarks.ViewModels;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StudentMarks.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestPage : ContentPage
    {
        public List<StudentTestDTO> Tests { get; private set; }

        public TestPage(StudentSubjectDTO subject)
        {
            InitializeComponent();
            Tests = subject.SubjectTests;
            BindingContext = this;
        }
    }
}