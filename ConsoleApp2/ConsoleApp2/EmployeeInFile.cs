namespace ConsoleApp2
{
    public class EmployeeInFile : EmployeeBase
    {
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
            var result = new Statistics();
            result.Max = float.MinValue;
            result.Min = float.MaxValue;
            result.Average = 0;
            var counter = 0;
            if (File.Exists(FileName))
            {
                using (var reader = File.OpenText(FileName))
                {
                    var line = reader.ReadLine();
                }
            }
            result.Average /= counter;
            switch (result.Average)
            {
                case var avererage when avererage >= 80:
                    result.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    result.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    result.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    result.AverageLetter = 'D';
                    break;
                default:
                    result.AverageLetter = 'E';
                    break;
            }


            return result;
        }
    }
}


