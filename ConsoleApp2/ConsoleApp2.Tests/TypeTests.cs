namespace ConsoleApp2.Tests
{
    public class TypeTests
    {
        [Test]
        public void Test()
        {

            var employee1 = GetEmployee("Renata", "Skoczylas", 57);
            var employee2 = GetEmployee("Marcin", "Skoczylas", 43);



            Assert.AreNotEqual(employee1, employee2);

        }
        private Employee GetEmployee(string name, string surname, int age)
        {
            return new Employee(name, surname, age);
        }
            [Test]
            public void WhenTwoNumbersAreTheSame()
            {
                int number1 = 7;
                int number2 = 7;
                Assert.AreEqual(number1, number2);
            }
                [Test]
                public void WhenTwoNamesAreNotTheSame()
                {
                    string name1 = "Zuzia";
                    string name2 = "Jakub";
                    Assert.AreNotEqual(name1, name2);



                }
            }
        }
    
