using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_5_Student_scores
{
    class Student
    {
        private string name;
        private int year;

        //scores ----------> object of 5 spaces
        private int[] scores = new int[5];

        public Student(string name, int year, int s1, int s2, int s3, int s4, int s5)
        {
            this.name = name;
            this.year = year;
            scores[0] = s1;
            scores[1] = s2;
            scores[2] = s3;
            scores[3] = s4;
            scores[4] = s5;

        }

        public Student(string name, int year, int[] scores)
        {
            this.name = name;
            this.year = year;
            //scores ----------> other obj conatining a num of elements
            this.scores = scores;
        }
        public double GetAverage()
        {
            double total = 0;
            for(int i = 0; i < scores.Length; i++)
            {
                total = total + scores[i];
            }
            double average = total / scores.Length;
            return average;
        }

        public int GetHighest()
        {
            int highest = scores[0];
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] > highest) highest = scores[i];

            }
            return highest;
        }

        public int GetLowest()
        {
            int lowest = scores[0];
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] < lowest) lowest = scores[i];

            }
            return lowest;
        }
    }
}
