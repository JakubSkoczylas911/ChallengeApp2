﻿namespace ConsoleApp2
{
    public class Employee : IEmployee
    {
        private List<float> scores = new List<float>();
        public Employee(string name, string surname, string sex)

        {
            this.Name = name;
            this.Surname = surname;
            this.Sex = sex;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Sex { get; private set; }



        public void AddScore(float score)
        {
            if (score >= 0 && score <= 100)
            {
                this.scores.Add(score);
            }
            else
            {
                throw new Exception("invalid score value");
            }
        }
        public void AddScore(string score)
        {
            if (float.TryParse(score, out float scoreValue))
            {
                this.AddScore(scoreValue);
            }
            else if (char.TryParse(score, out char charValue))
            {
                this.AddScore(charValue);
            }
            else
            {
                throw new Exception("String is not float");
            }
        }
        public void AddScore(char score)
        {
            switch ((float)score)
            {
                case 'A':
                case 'a':
                    this.scores.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.scores.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.scores.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.scores.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.scores.Add(20);
                    break;
                default:
                    throw new Exception("Wrong letter");


            }
        }
        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            foreach (var score in this.scores)
            {
                statistics.Max = Math.Max(statistics.Max, score);
                statistics.Min = Math.Min(statistics.Min, score);
                statistics.Average += score;
            }
            statistics.Average = statistics.Average /= this.scores.Count;
            switch (statistics.Average)
            {
                case var avererage when avererage >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }


            return statistics;
        }
    }
}










