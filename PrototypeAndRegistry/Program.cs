using System;

namespace PrototypeAndRegistry
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentRegistry registery = StudentRegistry.getinstance();
            //Create Prototype for the student so that we can use it later to make or add specific student
            fillPrototype(registery);

            //Now we can get that prototype and make a clone 
            Student Harsh = registery.get("Feb 22 LLD").Clone();
            Harsh.setName("Harsh");  //->  if setters is not provided how we can make copy or clone 
            Harsh.setAge(24);        //-> sloution is Copy Constructor

            //Now let's assume in future an Intelligent Student came, then we want to create a prototype and also we want to create
            //a seperate batch and psp for those students
            //Create Prototype for Intelligent Student
            Student Devdutt = registery.get("Feb 22 LLD Intelligent").Clone();
            Devdutt.setName("Devdutt");
            Devdutt.setAge(36);

            //Priting Data of Both Students
            Console.WriteLine("Student Data is here: ");
            Console.WriteLine("Student name is {0}",Harsh.getName());
            Console.WriteLine("Student Age is  {0}", Harsh.getAge());
            Console.WriteLine("Student Batch is {0}",Harsh.BatchName);
            Console.WriteLine("Student AvgPsp is {0}",Harsh.AvgPsp);

            //Intelligent Student data
            Console.WriteLine("Intelligent Student Data is here: ");
            Console.WriteLine("Student name is {0}", Devdutt.getName());
            Console.WriteLine("Student Age is  {0}", Devdutt.getAge());
            Console.WriteLine("Student Batch is {0}", Devdutt.BatchName);
            Console.WriteLine("Student AvgPsp is {0}", Devdutt.AvgPsp);
            //Console.WriteLine("Student IQ is {0}", Devdutt.IQ);
            //IntelligentStudent is = Devdutt;
            //Console.WriteLine("Student IQ is {0}", Devdutt);
        }
        private static void fillPrototype(StudentRegistry studentRegistry)
        {
            //Create Prototype
            Student student = new Student();
            student.AvgPsp = 89;
            student.BatchName = "Feb 22 LLD";
            //Register the [rototype into Registry ->  this will create prototype for student 
            studentRegistry.Regsiter("Feb 22 LLD", student);


            //Create a prototype for Intelligent Student 
            IntelligentStudent intelligentStudent = new IntelligentStudent();
            intelligentStudent.AvgPsp = 95;
            intelligentStudent.BatchName = "Feb 22 LLD Intelligent";
            intelligentStudent.IQ = 180;

            //Register the prototype for Intelligent Student
            studentRegistry.Regsiter("Feb 22 LLD Intelligent",intelligentStudent);
        }
    }
}
