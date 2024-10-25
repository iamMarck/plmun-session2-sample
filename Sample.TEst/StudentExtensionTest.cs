using Sample.Core.Helpers;

namespace Sample.TEst
{
    [TestClass]
    public class StudentExtensionTest
    {
        [TestMethod]
        public void GenerateStudentId_ShouldBe_2410001()
        {
            //ARRAGE
            int userId = 1;
            //ACT
            var studentID = userId.GenerateStudentId();

            //ASSERT
            Assert.AreEqual(2410001, studentID);
        }

        [TestMethod]
        public void GenerateStudentId_ShouldBe_2410099()
        {
            //ARRAGE
            int userId = 99;
            //ACT
            var studentID = userId.GenerateStudentId();

            //ASSERT
            Assert.AreEqual(2410099, studentID);
        }
    }
}