using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
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
        }
    }
}
public Statistics GetStatisticsWithFor ()
{
    var statistics1 = new Statistics;
    statistics1.Average = 0;
    statistics1.Max = float.MinValue;
    statistics1.Min = float.MaxValue;
    for (var index = 0; index < this.scores.Count; index++)
    {
        statistics1.Max = Math.Max(statistics1.Max, this.scores[index]);
        statistics1.Min = Math.Min(statistics1.Min, this.scores[index]);
        statistics1.Average += this scores[index];
    }
    statistics1.Average /= this.scores.Count;
    return statistics1;


public Statistics GetStatisticsWithForeach ()
{
    var statistics2 = new Statistics();
    statistics2.Average = 0;
    statistics2.Max = float.MinValue;
    statistics2.Min = float.MaxValue;
    foreach (var score in this.scores)
    {
        statistics2.Max = Math.Max(statistics2, score);
        statistics2.Min = Math.Min(statistics2.Min, score);
        statistics2.Average += score;
    }
    statistics2.Average /= this.scores.Count;
    return statistics2;
}
public Statistics GetStatisticsWithDoWhile ()
{
    var statistics3 = new Statistics();
    statistics3.Average = 0;
    statistics3.Max = float.MinValue;
    statistics3.Min = float.MaxValue;
    var index = 0;
    do
    {
        statistics3.Max = Math.Max(statistics3.Max, this.scores[index]);
        statistics3.Min = Math.Min(statistics3.Min, this.scores[index]);
        statistics3.Average/=this.scores.Count:
    return statistics3;
}
public Statistics GetStatisticsWithWhile()
{
    var statistics4 = new Statistics();
    statistics4.Average = 0;
    statistics4.Max = float.MinValue;
    statistics4.Min = float.MaxValue; ;
    var index = 0;
    while (index < this.scores.Count)
    {
        statistics4.Max = Math.Max(statistics4.Max, this.scores[index]);
        statistics4.Min = Math.Min(statistics4.Min, this.scores[index]);
        statistics4.Average += this.scores[index];
        index++;
    }
    statistics4.Average /= this.scores.Count;
    return statistics4;
}
}
}





