﻿namespace ConsoleApp2
{
    public abstract class EmployeeBase : IEmployee
    {
        public delegate void ScoreAddedDelegate(object sender, EventArgs args);
        public abstract event ScoreAddedDelegate ScoreAdded;
        public EmployeeBase(string name, string surname, string sex)
        {
            this.Name = name;
            this.Surname = surname;
            this.Sex = sex;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Sex { get; private set; }
        public abstract void AddScore(float score);
        public abstract void AddScore(string score);
        public abstract void AddScore(char score);
        public abstract Statistics GetStatistics();
    }
}




