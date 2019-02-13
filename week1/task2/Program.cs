using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {

            Student s1 = new Student("Anar", "18BD777777", 1);              //input Student
            s1.September();                                                     //show name Student with increment the year of study
        }
    }
    class Student                                                               //create new internal type of class
    {
        string Name { get; set; }                                               //name of a Student  
        string ID { get; set; }                                                 //id of a Student
        int Year { get; set; }                                                   //Student year of study
        public Student(string Name, string ID, int Year)                           //create constructor
        {
            this.Name = Name;                                                   //constructor connects: name;
            this.ID = ID;                                                       //                      id;    
            this.Year= Year;                                                     //                      year of study;
        }
        public void September()                                                 //function new year of study - September
        {
            Console.WriteLine("Student: {0}, ID: {1}, Year of study: {2}", Name, ID, Year);
           Year++;
            Console.ReadKey();
        }
    }
}
