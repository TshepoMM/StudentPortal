using System.Collections.Generic;

namespace StudentMarks.ViewModels
{
    public class StudentViewModel
    {
        public Student studentResponse { get; set; }
    }

    public class Student
    {
        public int TID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string StudentNumber { get; set; }
        public string Email { get; set; }
        public string Cell { get; set; }
        public int status { get; set; }
        public List<StudentCourse> StudentCourseList { get; set; }

    }
    public class StudentCourse
    {
        public int courseID { get; set; }
        public string courseTitle { get; set; }
        public List<StudentSubjectDTO> CourseSubjectList { get; set; }
    }

    public class StudentSubjectDTO
    {
        public int subjectID { get; set; }
        public string subjectTitle { get; set; }
        public List<StudentTestDTO> SubjectTests { get; set; }
    }
    public class StudentTestDTO
    {
        public int testID { get; set; }
        public string testTitle { get; set; }
        public int testMark { get; set; }
    }

}