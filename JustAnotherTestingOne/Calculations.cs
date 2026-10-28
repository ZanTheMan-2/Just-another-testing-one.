using System;
using System.Collections.Generic;
using System.Text;

namespace JustAnotherTestingOne
{
    public class Calculations
    {

        String name { get; set; }
        int grade1 { get; set; }
        int grade2 { get; set; }
        int grade3 { get; set; }
        int age { get; set; }

        public Calculations(String name, int grade1, int grade2, int grade3, int age)
        {
            this.name = name;
            this.grade1 = grade1;
            this.grade2 = grade2;
            this.grade3 = grade3;
            this.age = age;
        }

        public double Average()
        {
            return (grade1 + grade2 + grade3) / 3.0;
        }

        public String GetName()
        {
            return name;
        }

        public int score()
        {
            int score = (grade1 + grade2 + grade3)/age;
            return score;
        }
    }
}
