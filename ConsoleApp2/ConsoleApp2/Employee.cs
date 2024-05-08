using System.ComponentModel.Design;

namespace ConsoleApp2
{
    public class Employee
    {
        private List<float> scores = new List<float>();


        public int score;
        public int number;
        public Employee(string name, string surname, int age)
        {

            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.score = 0;

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

             Statistics GetStatistics()
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
            }
        }
    } }


