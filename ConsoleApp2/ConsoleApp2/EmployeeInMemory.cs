namespace ConsoleApp2
{
    public class EmployeeInMemory : EmployeeBase
    {
        public override event ScoreAddedDelegate ScoreAdded;
        private List<float> scores = new List<float>();
        public EmployeeInMemory(string name, string surname, string sex) : base(name, surname, sex)
        {

        }

        public override void AddScore(float score)
        {
            if (score >= 0 && score <= 100)
            {
                this.AddScore(score);
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
            var statistics = new Statistics();
            foreach (var score in this.scores)
            {
                statistics.AddScore(score);
            }


            return statistics;
        }
    }
}


