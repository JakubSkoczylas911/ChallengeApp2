namespace ConsoleApp2.Tests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {

            var employee = new Employee("Renata", "Skoczylas", 57);
            employee.AddScore(5);
            employee.AddScore(6);
 var result = employee.Score;
 Assert.AreEqual(11, result);
}
    }
}