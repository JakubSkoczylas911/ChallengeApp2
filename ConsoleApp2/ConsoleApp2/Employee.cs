using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using ConsoleApp2;

namespace ConsoleApp2
{
    public class Employee
    {
        private List<float> scores = new List<float>();



        public Employee(string name, string surname, int age)
        {

            this.Name = name;
            this.Surname = surname;
            this.Age = age;


        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public void AddScore(float score)
        {
            if (score >= 0 && score <= 100)
            {
                this.scores.Add(score);
            }
            else
            {
                Console.WriteLine("invalid score value");
            }
        }
        public void AddScore(string score)
        {
            if (float.TryParse(score, out float scoreValue))
            {
                this.AddScore(scoreValue);
            }
            else
            {
                Console.WriteLine("String is not float");
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
            statistics.Average = statistics.Average / this.scores.Count;

            return statistics;


            public Statistics GetStatisticsWithFor()
            {
                var statistics = new Statistics();
                statistics.Average = 0;
                statistics.Max = float.MinValue;
                statistics.Min = float.MaxValue;
                for (var index = 0; index < this.scores.Count; index++)
                {
                    statistics.Max = Math.Max(statistics.Max, this.scores[index]);
                    statistics.Min = Math.Min(statistics.Min, this.scores[index]);
                    statistics.Average += this.scores[index];
                }
                statistics.Average /= this.scores.Count;
                return statistics;



                public Statistics GetStatisticsWithDoWhile()
                {
                    var statistics = new Statistics();
                    statistics.Average = 0;
                    statistics.Max = float.MinValue;
                    statistics.Min = float.MaxValue;
                    var index = 0;
                    do
                    {
                        statistics.Max = Math.Max(statistics.Max, this.scores[index]);
                        statistics.Min = Math.Min(statistics.Min, this.scores[index]);
                        statistics.Average += this.scores[index];
                        index++;
                    } while (index < this.scores.Count);
                    statistics.Average /= this.scores.Count;

                    return statistics;
                }
                public Statistics GetStatisticsWithWhile()
                {
                    var statistics = new Statistics();
                    statistics.Average = 0;
                    statistics.Max = float.MinValue;
                    statistics.Min = float.MaxValue; ;
                    var index = 0;
                    while (index < this.scores.Count)
                    {
                        statistics.Max = Math.Max(statistics.Max, this.scores[index]);
                        statistics.Min = Math.Min(statistics.Min, this.scores[index]);
                        statistics.Average += this.scores[index];
                        index++;
                    }
                    statistics.Average /= this.scores.Count;
                    return statistics;
                }
            }
        }
    }
}








