namespace ConsoleApp2
{
    public class Supervisor : IEmployee
    {
        private List<float> scores = new List<float>();
        public Supervisor(string name, string surname, string sex)
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

            switch (score)
            {
                case "6":
                    this.AddScore(100);
                    break;
                case "6-":
                case "-6":

                    this.AddScore(95);
                    break;
                case "5+":
                case "+5":
                    this.AddScore(85);
                    break;
                case "5":
                    this.AddScore(80);
                    break;

                case "5-":
                case "-5":
                    this.AddScore(75);
                    break;
                case "4+":
                case "+4":
                    this.AddScore(65);
                    break;
                case "4":
                    this.AddScore(60);
                    break;
                case "4-":
                case "-4":
                    this.AddScore(55);
                    break;
                case "3+":
                case "+3":
                    this.AddScore(45);
                    break;
                case "3":
                    this.AddScore(40);
                    break;
                case "3-":
                case "-3":

                    this.AddScore(35);
                    break;
                case "2+":
                case "+2":
                    this.AddScore(25);
                    break;
                case "2":
                    this.AddScore(20);
                    break;
                case "2-":
                case "-2":

                    this.AddScore(15);
                    break;
                case "1+":
                case "+1":
                    this.AddScore(5);
                    break;
                case "1":
                    this.AddScore(0);
                    break;
            }
        }
        public void AddScore(char score)
        {
            switch ((float)score)
            {
                case 'A':
                case 'a':
                    this.AddScore(100);
                    break;
                case 'B':
                case 'b':
                    this.AddScore(80);
                    break;
                case 'C':
                case 'c':
                    this.AddScore(60);
                    break;
                case 'D':
                case 'd':
                    this.AddScore(40);
                    break;
                case 'E':
                case 'e':
                    this.AddScore(20);
                    break;
                default:
                    throw new Exception("Wrong Letter");
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
