using System;

namespace TestableClass
{
    public interface IMyDependency
    {
        School GetSchoolByName(string name);
        Student GetStudentById(string id);
        bool AddStudentToSchool(School school, Student student);
    }

    public class MyTestableClass
    {
        private readonly IMyDependency _dependency;
        public MyTestableClass():this(new MyDependency()) { }

        public MyTestableClass(IMyDependency dependency)
        {
            _dependency = dependency;
        }

        public void AssignStudentToSchool(string studentId, string schoolName)
        {
            var student = _dependency.GetStudentById(studentId);
            if(student == null)
                throw new ArgumentException("Student could not be found", studentId);

            var school = _dependency.GetSchoolByName(schoolName);
            if(school == null)
                throw new ArgumentException("School could not be found", schoolName);

            CheckStudentAgeForSchool(school, student);

            if(!_dependency.AddStudentToSchool(school, student))
            {
                throw new Exception("The student could not be assigned, try again later");
            }
        }

        protected virtual void CheckStudentAgeForSchool(School school, Student student)
        {
            if (school.MinAge > student.Age)
            {
                throw new Exception("The student selected is too young");
            }

            if (school.MaxAge < student.Age)
            {
                throw new Exception("The student selected is too old");
            }
        }
    }

    public class MyDependency:IMyDependency
    {
        public School GetSchoolByName(string name)
        {
            throw new NotImplementedException("Get the school from the DB.");
        }

        public Student GetStudentById(string id)
        {
            throw new NotImplementedException("Get the student from the DB.");
        }

        public bool AddStudentToSchool(School school, Student student)
        {
            throw new NotImplementedException("Put logic here to assign the student to the school in the DB.");
        }
    }

    public class School
    {
        public string Name { get; set;}
        public int MinAge { get; set; }
        public int MaxAge { get; set; }
    }

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StudentId { get; set; }
        public int Age { get; set; }
    }
}
