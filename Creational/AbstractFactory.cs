namespace Patterns.Creational
{
    public abstract class Student
    {
        public Student(int id)
        {
            this.id = id;
        }
        private int id;
        public abstract string Speak();

    }

    public class SpecialStudent : Student
    {

        public SpecialStudent(int id) : base(id)
        {
        }
        public override string Speak()
        {
            return "I am a special student";
        }
    }

    public class NormalStudent : Student
    {
        public NormalStudent(int id) : base(id)
        {
        }

        public override string Speak()
        {
            return "I am a normal student";
        }
    }

    public class StudentFactory : IStudentFactory
    {
        public Student CreateStudent(string studentType)
        {
            Student studentToReturn;
            switch (studentType)
            {
                case "special":
                    studentToReturn = new SpecialStudent(1);
                    break;
                default:
                case "normal":
                    studentToReturn = new NormalStudent(2);
                    break;
            }

            return studentToReturn;
        }
    }

    public interface IStudentFactory
    {
        Student CreateStudent(string studentType);
    }
}