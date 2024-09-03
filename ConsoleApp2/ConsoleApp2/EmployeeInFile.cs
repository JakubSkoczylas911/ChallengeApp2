using System.Runtime.CompilerServices;

namespace ConsoleApp2
{
    public class EmployeeInFile : EmployeeBase
    {
        public override event ScoreAddedDelegate ScoreAdded;
        private const string FileName = "scores.txt";
        public EmployeeInFile(string name, string surname, string sex) : base(name, surname, sex)
        {
        }

        public override void AddScore(float score)
        {
            if (score >= 0 && score <= 100)
            {
                using (var writer = File.AppendText(FileName))
                {
                    writer.WriteLine(score);
                }
                if (ScoreAdded != null)
                {
                    ScoreAdded(this, new EventArgs());
                }

            }
            else
            {
                throw new Exception("invalid score value");
            }
        }

        public override void AddScore(string score)
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

        public override void AddScore(char score)
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
                    throw new Exception("Wrong letter");


            }
        }

        public override Statistics GetStatistics()
        {
            var scoresFromFile = this.ReadScoresFromFile();
            var result = this.CountStatistics(scoresFromFile);
            return result;
        }
        private List<float> ReadScoresFromFile()
        {
            var scores = new List<float>();
            if (File.Exists(FileName))
            {
                using (var reader = File.OpenText(FileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        line = reader.ReadLine();
                    }
                }
            }
            return scores;
        }
        private Statistics CountStatistics(List<float> scores)
        {
            var statistics = new Statistics();
            foreach (var score in scores)
            {
                statistics.AddScore(score);
            }
            return statistics;
        }
    }
}




