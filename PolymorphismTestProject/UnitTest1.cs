using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Polymorphism;

namespace PolymorphismTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculateWeeklySalaryForEmployeeTest_2200()
        {
			//	Arrange
			int weeklyHours = 55;
			int wage = 70;
			int salary = 40 * wage;
			Employee e = new Employee();

			string expectedResponse = String.Format("This ANGRY EMPLOYEE worked {0} hrs. " +
							"Paid for 40 hrs at $ {1}" +
							"/hr = ${2}", weeklyHours, wage, salary);

			// Act
			string response = e.CalculateWeeklySalary(weeklyHours, wage);
			// Assert
			Assert.AreEqual(response, expectedResponse);
		}

		[TestMethod]
		public void CalculateWeeklySalaryForEmployeeTest_3850()
		{
			//	Arrange
			int weeklyHours = 55;
			int wage = 70;
			int salary = weeklyHours * wage;
			Contractor e = new Contractor();

			string expectedResponse = String.Format("This HAPPY CONTRACTOR worked {0} hrs. " +
							"Paid for {0} hrs at $ {1}" +
							"/hr = ${2} ", weeklyHours, wage, salary);
			// Act
			string response = e.CalculateWeeklySalary(weeklyHours, wage);
			// Assert
			Assert.AreEqual(response, expectedResponse);
		}
		[TestMethod]
		public void CalculateWeeklySalaryForEmployeeTest_22001()
		{
			//	Arrange
			int weeklyHours = 55;
			int wage = 70;
			int salary = 40 * wage;
			Employee e = new Employee();

			string expectedResponse = String.Format("Problem1 This ANGRY EMPLOYEE worked {0} hrs. " +
							"Paid for 40 hrs at $ {1}" +
							"/hr = ${2}", weeklyHours, wage, salary);

			// Act
			string response = e.CalculateWeeklySalary(weeklyHours, wage);
			// Assert
			Assert.AreNotEqual(response, expectedResponse);
		}

		[TestMethod]
		public void CalculateWeeklySalaryForEmployeeTest_38502()
		{
			//	Arrange
			int weeklyHours = 55;
			int wage = 70;
			int salary = 40 * wage;
			Contractor e = new Contractor();

			string expectedResponse = String.Format("Problem2 This HAPPY CONTRACTOR worked {0} hrs. " +
							"Paid for {0} hrs at $ {1}" +
							"/hr = ${2} ", weeklyHours, wage, salary);
			// Act
			string response = e.CalculateWeeklySalary(weeklyHours, wage);
			// Assert
			Assert.AreNotEqual(response, expectedResponse);
		}
	}
}
