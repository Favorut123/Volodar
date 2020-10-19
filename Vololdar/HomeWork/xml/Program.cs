using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Xml 
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read data
            XDocument document = XDocument.Load("input_students.xml");
            XElement studentsElement = document.Element("Students");
            IEnumerable<XElement> studentElements = studentsElement.Elements("Student");
            List<Student> students = new List<Student>();
            foreach (var studentElement in studentElements)
            {
                Student student = new Student();
                student.FirstName = studentElement.Attribute("firstName").Value;
                student.LastName = studentElement.Attribute("lastName").Value;
                student.BirthDate = GetBirthDate(studentElement.Element("BirthDate").Value);
                student.Email = studentElement.Element("Email").Value;
                student.PhoneNumber = studentElement.Element("PhoneNumber").Value;
                var coursesElement = studentElement.Element("Courses");
                student.Courses = ImportCourses(coursesElement);
                student.ExtraData = ImportExtraData(studentElement.Element("ExtraData"));
                students.Add(student);
            }

            //Modify data
            Student newStudent = new Student()
            {
                BirthDate = new DateTime(1980, 2, 2),
                FirstName = "John",
                LastName = "Smith",
                Email = "kohn@gmail.com",
                PhoneNumber = "380675849123",
                Courses = new List<string>() { "Fishing" },
                ExtraData = new Dictionary<string, string>() { { "Instagram", "BrutalMan" } }

            };
            students.Add(newStudent);
            // Save Data
            Export(students);

        }

        private static void Export(List<Student> students)
        {
            XDocument document = new XDocument();
            XElement root = new XElement("Students");
            document.Add(root);

            foreach (var student in students)
            {
                XElement studentElement = new XElement("Student", new XAttribute("firstName", student.FirstName), new XAttribute("lastName", student.LastName));
                XElement birthDateElement = new XElement("BirthDate", student.BirthDate.ToString("dd.MM.yyy", CultureInfo.InvariantCulture));
                studentElement.Add(new XElement("PhoneNumber", student.PhoneNumber));
                studentElement.Add(birthDateElement);
                studentElement.Add(GetExtraDataElement(student.ExtraData));
                root.Add(studentElement);
            }
        }

        private static XElement GetExtraDataElement(Dictionary<string, string> studentExtraData)
        {
            throw new NotImplementedException();
        }

        private static Dictionary<string, string> ImportExtraData(XElement element)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();

            foreach (var extraDataElement in element.Elements("ExtraDataElement"))
            {
                string key = extraDataElement.Attribute("name").Value;
                string value = extraDataElement.Value;
                result.Add(key, value);
            }

            return result;
        }

        private static List<string> ImportCourses(XElement coursesElement)
        {
            List<string> result = new List<string>();
            IEnumerable<XElement> courseElements = coursesElement.Elements("Course");
            foreach (var courseElement in courseElements)
            {
                result.Add(courseElement.Value);
            }

            return result;
        }

        private static DateTime GetBirthDate(string value)
        {
            return DateTime.Parse(value);
        }
    }

    internal class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public List<string> Courses { get; set; }
        public Dictionary<string, string> ExtraData { get; set; }
    }
}
