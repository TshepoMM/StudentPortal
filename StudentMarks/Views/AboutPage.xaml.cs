using RestSharp;
using StudentMarks.Models;
using StudentMarks.ViewModels;
using System.Collections.Generic;
using Xamarin.Forms;

namespace StudentMarks.Views
{

    public partial class AboutPage : ContentPage
    {
        bool connectionSuccesful { get; set; }
        UserModel user = null;
        StudentViewModel student = new StudentViewModel();
        List<StudentCourse> Courses = new List<StudentCourse>();

        public AboutPage(UserModel user)
        {
            InitializeComponent();
            this.user = user;
            RequestCourse();
            title.Text = $"Welcome \n{student.studentResponse.Name} {student.studentResponse.Surname} \n{student.studentResponse.StudentNumber}";
            Courses = student.studentResponse.StudentCourseList;

            for (int i = 0; i < Courses.Count; i++)
                Course.Items.Add(Courses[i].courseTitle);
        }

        private void RequestCourse()
        {
            string reqAddress = "http://tlekhila78-001-site1.etempurl.com/api/Students/MyCourses/?studentID=" + user.Id;
            var client = new RestClient(reqAddress);

            var request = new RestRequest();

            var response = client.Execute<StudentViewModel>(request, Method.GET);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                connectionSuccesful = true;
                if (response.IsSuccessful)
                    student = response.Data;
            }
        }

        private void Course_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;

            Navigation.PushAsync(new SubjectPage(Courses[selectedIndex].CourseSubjectList));
        }
    }
}