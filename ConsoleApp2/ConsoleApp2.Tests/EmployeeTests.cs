namespace ConsoleApp2.Tests
{
    public class Tests
    {
        [Test]
        public void IfAverageCountedByGivenScoresInNumbersAverageIsCorrectAverageLetter()
        {

            var employee = new Employee();
            employee.AddScore(10);
            employee.AddScore(15);
            employee.AddScore(25);
            employee.AddScore(35);


            var statistics = employee.GetStatistics();
            Assert.AreEqual(statistics.AverageLetter, 'D');
        }
    }
}




