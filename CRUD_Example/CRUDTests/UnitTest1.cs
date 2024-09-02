namespace CRUDTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            MyMath mm = new MyMath();
            int arg1 = 10, arg2 = 20;
            int expected = 30;

            //Act
            int actual = mm.Add(arg1, arg2);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}