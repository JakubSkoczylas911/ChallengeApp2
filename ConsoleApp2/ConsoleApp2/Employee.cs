namespace ConsoleApp2
{
    public class Employee
    {
        private string name;
        private string surname;
        public int age;
        public int score;
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

        public void AddScore(int number)
        {
            this.score = this.score + number;

            this.score += number;
        }
    }
}
