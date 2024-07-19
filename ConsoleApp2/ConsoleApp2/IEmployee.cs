namespace ConsoleApp2
{
    public interface IEmployee
    {
        string Name { get; }
        string Surname { get; }
        string Sex { get; }
        void AddScore(float score);
        void AddScore(string score);
        void AddScore(char score);
        Statistics GetStatistics();
    }
}
