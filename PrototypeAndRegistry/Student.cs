using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeAndRegistry
{
    class Student
    {
        //Specific attribute to Student 
        private string Name;
        private int Age;
        //Common attribute for all student is there averagePSP of the batch and batchname
        public double AvgPsp { get; set; }
        public string BatchName { get; set; }

        //getter and setters for Name, Age, PhoneNumber
        public string getName()
        {
            return this.Name;
        }
        public int getAge()
        {
            return this.Age;
        }
        //setters for Name, Age if lets day setter are not provided means fields are private we can't access for copy the object
        //from program or client so we have to use copy constructor
        public void setName(string name)
        {
            this.Name = name;
        }
        public void setAge(int age)
        {
            this.Age = age;
        }

        // To make a clone we have to use Copy Constructor
        public Student()
        {

        }
        public Student(Student student)
        {
            //this.Name = student.Name;
            //this.Age = student.Age;
            this.AvgPsp = student.AvgPsp; //this is the common attribute for all student means common value in it.
            this.BatchName = student.BatchName; //this is the common attribute for all student means common value in it.
        }
        //For Clone the student , we have a method clone inside every class so that we can make a copy of it
        public virtual Student Clone()
        {
            /*Student s = new Student();
            s.AvgPsp = this.AvgPsp;
            s.BatchName = this.BatchName;*/
            return new Student(this); // returning copy contsructor Object through Clone Method so that client will not directly
                                      // depends on Concrete Object of Student or Intelligent Student
        }
    }
}
