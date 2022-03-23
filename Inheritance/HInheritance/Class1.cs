﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HInheritance
{
    public class Person
    {
        public string name;
        public int aadhar_id;
        public int age;

        public Person(int aadhar_id, int age, string name)
        {
            this.aadhar_id = aadhar_id;
            this.name = name;
            this.age = age;
        }
    }

    // Derived Class
    class Teacher : Person
    {
        public int teacher_salary;

        public Teacher(int aadhar_id, int salary,
                       string name, int age) : base(aadhar_id,
                                                    age, name)
        {
            teacher_salary = salary;
        }
        public void TeacherDetails()
        {
            Console.WriteLine("teacher ID:      " + aadhar_id);
            Console.WriteLine("teacher Name:    " + name);
            Console.WriteLine("teacher Salary:  " + teacher_salary);
            Console.WriteLine("teacher Age:     " + age);
        }
    }

    // Derived Class
    class Doctor : Person
    {
        public int doctor_fees;

        public Doctor(int aadhar_id, int fees,
                      string name, int age) : base(aadhar_id,
                                                   age, name)
        {
            doctor_fees = fees;
        }
        public void DoctorDetails()
        {
            Console.WriteLine("Doctor ID:      " + aadhar_id);
            Console.WriteLine("Doctor Name:    " + name);
            Console.WriteLine("Doctor Fees:    " + doctor_fees);
            Console.WriteLine("Doctor Age:     " + age);
        }
    }
}

