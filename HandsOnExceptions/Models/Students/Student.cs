using HandsOnExceptions.Models.Students.Exeptions;

namespace HandsOnExceptions.Models.Students
{
    internal class Student
    {
        public string Name { get; set; } = default!;
        public int Age {  get; set; }
        public Student(string name,int age)
        {
            if (name.Length < 5) 
            {
                throw new InvalidStudentNameException(messege: "Student name's lenght "+
                    "must be at least 5.");
            }
            Name = name;
            Age = age;
        }

    }
}
