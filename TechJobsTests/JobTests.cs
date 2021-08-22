using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            //Each Job object should contain a unique ID number, and these should also be sequential integers.
            Job obj1_test = new Job();
            Job obj2_test = new Job();
            Assert.AreNotEqual(obj1_test.Id, obj2_test.Id);
            Assert.AreEqual(1, obj2_test.Id - obj1_test.Id);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            //The constructor correctly assigns the value of each field.
            Employer ACME = new Employer("ACME");
            Location Desert = new Location("Desert");
            PositionType Quality_control = new PositionType("Quality control");
            CoreCompetency Persistence = new CoreCompetency("Persistence");

            Job obj3_test = new Job("Product tester", ACME, Desert, Quality_control, Persistence);

            Assert.AreEqual("Product tester", obj3_test.Name);
            Assert.AreEqual(ACME, obj3_test.EmployerName);
            Assert.AreEqual(Desert, obj3_test.EmployerLocation);
            Assert.AreEqual(Quality_control, obj3_test.JobType);
            Assert.AreEqual(Persistence, obj3_test.JobCoreCompetency);
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            //Two objects are NOT equal if their id values differ, even if all the other fields are identical.
            Employer ACME = new Employer("ACME");
            Location Desert = new Location("Desert");
            PositionType Quality_control = new PositionType("Quality control");
            CoreCompetency Persistence = new CoreCompetency("Persistence");

            Job obj4_test = new Job("Product tester", ACME, Desert, Quality_control, Persistence);
            Job obj5_test = new Job("Product tester", ACME, Desert, Quality_control, Persistence);

            Assert.IsFalse(Equals(obj4_test, obj5_test));
        }

        [TestMethod]
        public void TestToStringFirstAndLastLines()
        {
            Employer ACME = new Employer("ACME");
            Location Desert = new Location("Desert");
            PositionType Quality_control = new PositionType("Quality control");
            CoreCompetency Persistence = new CoreCompetency("Persistence");
            Job obj6_test = new Job("Product tester", ACME, Desert, Quality_control, Persistence);

            List<string> list1 = obj6_test.ToString().Split("\n").ToList();

            //Should return a string that contains a blank line before the job information.
            Assert.AreEqual("", list1[0]);
            //Should return a string that contains a blank line after the job information.
            Assert.AreEqual("", list1[7]);
            //Only 8 items in the list
            Assert.AreEqual(8, list1.Count);
        }
    }
}