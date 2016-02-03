using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{

        // student periytyy person luokasta
        // Student on aliluokka, person on yli/kantaluokka
        // Student saa kaikki person luokan ominaisuudet ja toiminnot
        // riippuen suojamääreistä
        class Student : Person
        {
            public string StudentID { get; set; }

            public Student()
            {

            }

            public Student(string firstname, string lastname, string address, string studentID)
                : base(firstname,lastname,address)
            {
                StudentID = studentID;
            }

            public void StudentMethod()
            {
                Console.WriteLine("Learing OOP");
            }


        // ylikirjoitetaan Person luokassa oleva ToString() metodi, koska siinä ei ole student ID:tä
        public override string ToString()
        {
            //Yli eli person luokasta palautuu
            // Firstname lastname address
            // liitetään siihen vielä studentin oma id
            return base.ToString() + " " + StudentID;
        }



    }

}
