using System;
using System.Collections.Generic;
using System.Text;

namespace StudentClassDemo
{
    class Student
    {

        private string name;
        private int idNumber;
        private double score1;
        private double score2;
        private double averageScore;


        public Student()
        {

        }

        public static void DoStuff()
        {
            Student molly = new Student();
            molly.name = "Molly";
            molly.idNumber = 42;
            Console.WriteLine(molly.name);
            Console.WriteLine(molly.idNumber);

            Student someStudent = new Student();
            Console.WriteLine("someStudent: {0}", someStudent.name);
            Console.WriteLine("someStudent: {0}", someStudent.idNumber);



        }

        public string GetName()
        {
            return name; 
        }

        public void SetName(string newName)
        {
            name = newName;
        }

        public int GetidNumber()
        {
            return idNumber;
        }

        public void SetidNumber(int newIdNumber)
        {
            idNumber = newIdNumber;
        }

        public double GetScore1()
        {
            return score1; 
        }

        public void SetScore1(double newScore1)
        {
            score1 = newScore1;
            UpdateAverageScore();
        }

        public double GetScore2()
        {
            return score2; 
        }

        public void SetScore2(double newScore2)
        {
            score2 = newScore2;
            UpdateAverageScore();
        }

        public double GetAverageScore()
        {
            return averageScore;
        }

        private void UpdateAverageScore()
        {
            averageScore = (score2 + score1) / 2; 
        }



    }
}
