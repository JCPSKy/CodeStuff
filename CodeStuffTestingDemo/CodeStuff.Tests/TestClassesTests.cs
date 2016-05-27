
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TestableClass;

namespace CodeStuff.Tests
{
    [TestClass]
    public class MyTestableClassTests
    {
        private List<School> _schools;
        private List<Student> _students;

        [TestInitialize]
        public void InitializeTest()
        {
            _students = new List<Student>
            {
                new Student
                {
                    FirstName = "John",
                    LastName = "Smith",
                    StudentId = "1",
                    Age = 21
                },
                new Student
                {
                    FirstName = "Sally",
                    LastName = "Smith",
                    StudentId = "2",
                    Age = 18
                },
                new Student
                {
                    FirstName = "John",
                    LastName = "Snow",
                    StudentId = "3",
                    Age = 12
                },
                new Student
                {
                    FirstName = "Eddard",
                    LastName = "Stark",
                    StudentId = "4",
                    Age = 5
                },
            };
            _schools = new List<School>
            {
                new School
                {
                    Name = "Elementary",
                    MinAge = 4,
                    MaxAge = 14
                },
                new School
                {
                    Name = "Middle",
                    MinAge = 9,
                    MaxAge = 18
                },
                new School
                {
                    Name = "High",
                    MinAge = 14,
                    MaxAge = 21
                }
            };
        }

        [TestMethod]
        public void AssignStudentToSchool_StudentNotFound()
        {
            var dependence = new Mock<MyDependency>();
            var target = new MyTestableClass();
        }

        [TestMethod]
        public void AssignStudentToSchool_SchoolNotFound()
        {
            var dependence = new Mock<MyDependency>();
            var target = new MyTestableClass();
        }

        [TestMethod]
        public void AssignStudentToSchool_StudentTooYoung()
        {
            var dependence = new Mock<MyDependency>();
            var target = new MyTestableClass();
        }

        [TestMethod]
        public void AssignStudentToSchool_StudentTooOld()
        {
            var dependence = new Mock<MyDependency>();
            var target = new MyTestableClass();
        }

        [TestMethod]
        public void AssignStudentToSchool_StudentUpperAge()
        {
            var dependence = new Mock<MyDependency>();
            var target = new MyTestableClass();
        }

        [TestMethod]
        public void AssignStudentToSchool_StudentLowerAge()
        {
            var dependence = new Mock<MyDependency>();
            var target = new MyTestableClass();
        }
    }
}
