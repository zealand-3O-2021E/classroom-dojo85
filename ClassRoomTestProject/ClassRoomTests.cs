using System;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassRoom;

namespace ClassRoomTestProject
{
    [TestClass]
    public class ClassRoomTests
    {
        [DataTestMethod]
        [DataRow(12, "Winter")]
        [DataRow(1, "Winter")]
        [DataRow(2, "Winter")]
        [DataRow(3, "Spring")]
        [DataRow(5, "Spring")]
        [DataRow(6, "Summer")]
        [DataRow(9, "Autumn")]

        public void SeasonMethod_Test(int month, string expectedValue)
        {
            var classRoom = new ClassRoom.ClassRoom();

            var actual = classRoom.Season(month);
        }

        [DataTestMethod]
        [DataRow(-1)]
        [DataRow(0)]
        [DataRow(13)]
        public void SeasonMethod_ThrowsException_Test(int month)
        {
            var classRoom = new ClassRoom.ClassRoom();

            Assert.ThrowsException<ArgumentOutOfRangeException>(()=> new Student("Tester", month, 1));
        }
    }
}
