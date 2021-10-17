using System;
using System.Collections.Generic;

namespace hw3Console
{
    abstract class Student
    {
        public string name;
        public string state;
        public Student(string name)
        {
            this.name = name;
            state = "";
        }
        public void Read()
        {
            state = state.Insert(state.Length, "read ");
        }
        public void Relax()
        {
            state = state.Insert(state.Length, "relax ");
        }
        public void Write()
        {
            state = state.Insert(state.Length, "write ");
        }
        public abstract void Study();
    }
    class BadStudent : Student
    {
        public BadStudent(string name) : base(name)
        {
            state = "bad ";
        }
        public override void Study()
        {
            for (int i = 0; i < 5; i++)
            {
                Relax();
            }
        }
    }

    class GoodStudent : Student
    {
        public GoodStudent(string name) : base(name)
        {
            state = "good ";
        }
        public override void Study()
        {
            Read();
            Write();
            Read();
            Write();
            Relax();
        }
    }

    class Group
    {
        string name;
        List<Student> students = new List<Student>();
        public Group(string name)
        {
            this.name = name;
        }
        public void AddStudent(Student student)
        {
            students.Add(student);
        }
        public string GetInfo()
        {
            string info = name;
            for(int i = 0; i < students.Count; i++)
            {
                info = info.Insert(name.Length, Convert.ToString(students[i].name));
            }
            return info;
        }
        public string GetFullInfo()
        {
            string info = name;
            for (int i = 0; i < students.Count; i++)
            {
                info = info.Insert(name.Length, Convert.ToString(students[i].name)+" "+Convert.ToString(students[i].state));
            }
            return info;
        }
    }
     class Program
        {
         static void Main(string[] args)
         {
            Group group = new Group("K-24");
            GoodStudent Sonya = new GoodStudent(Console.ReadLine());
            Sonya.Study();
            group.AddStudent(Sonya);
            Console.WriteLine(group.GetFullInfo());
         }
        }
    }

