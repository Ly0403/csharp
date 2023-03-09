using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mediator mediator=new Mediator();
            Teacher teacher1 = new Teacher() { Mediator=mediator,Name="Yucel"};

            Student student1 = new Student() { Mediator=mediator,Name="Latifah"};
            Student student2 = new Student() { Mediator = mediator, Name = "Latifah2" };

            mediator.Teacher = teacher1;
            mediator.Students = new List<Student>();

            mediator.Students.Add(student1);
            mediator.Students.Add(student2);

            teacher1.SendNewSlide("Slide1 url");
            student1.SendQuestion("What is the time?");
            Console.ReadLine();

        }
    }

    abstract class Member
    {
        public string Name { get; set; }
        public Mediator Mediator { get; set; }
    }

    class Teacher : Member
    {
        public void SendNewSlide(string url)
        {
            Console.WriteLine("The teacher send a new slide url {0}",url);
            Mediator.UpdateNewSlide(url);            
        }

        public void ReceiveNewQuestion(string question, Student student)
        {
            Console.WriteLine("The teacher receive a question {0} from the student {1}",question,student.Name);
            SendAnswer("Answer found!",student,question);
        }

        public void SendAnswer(string answer, Student student, string question)
        {
            Console.WriteLine("The teacher send answer {0} to student {1} for question {2}", answer, student.Name, question);
            Mediator.SendAnswerToStudent(answer,student,question);            
        }
    }

    class Student : Member
    {
        public void ReceiveNewSlides(string url)
        {
            Console.WriteLine("Student {1} received the new url {0}",url,Name);
        }

        public void SendQuestion(string question)
        {
            Console.WriteLine("Student {0} sent a new question", Name, question);
            Mediator.SendQuestiontoTeacher(question,this);            
        }

        public void ReceiveAnswer(string answer, Student student,string question)
        {
            Console.WriteLine("Student {0} received the asnwer {1} for question {2}",student.Name,answer,question);
        }
    }

    class Mediator
    {
        public Teacher Teacher { get; set; }
        public List<Student> Students { get; set; }

        public void SendQuestiontoTeacher(string question, Student student)
        {
            Teacher.ReceiveNewQuestion(question,student);
        }

        public void SendAnswerToStudent(string answer, Student student,string question)
        {
            student.ReceiveAnswer(answer,student,question);
        }

        public void UpdateNewSlide(string url)
        {
            foreach (var student in Students)
            {
                student.ReceiveNewSlides(url);
            }
        }
    }
}
