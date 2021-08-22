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
    }
}