using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConstructorOverloading
{
    class Student
    {
        String name,enroll_no,branch;
        public Student(String name)
        {
            this.name = name;
        }
        public Student(String name, String enroll_no)
        {
            this.name = name;
            this.enroll_no = enroll_no;
        }
        public Student(String name, String enroll_no, String branch)
        {
            this.name = name;
            this.enroll_no = enroll_no;
            this.branch = branch;
        }
        internal String getName()
        {
            return this.name;
        }
        internal String getEnroll()
       {
            return this.enroll_no;
        }
        internal String getBranch()
        {
            return this.branch;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("abc");
            Console.WriteLine(s1.getName());
            Student s2 = new Student("pqr", "16047010459");
            Console.WriteLine(s2.getName());
            Console.WriteLine(s2.getEnroll());
            Student s3 = new Student("xyz", "1604710236", "computer");
            Console.WriteLine(s3.getName());
            Console.WriteLine(s3.getEnroll());
            Console.WriteLine(s3.getBranch());
            Console.ReadKey();
        }
    }
} 

