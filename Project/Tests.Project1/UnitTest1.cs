using proj1;

namespace Tests.Project1;

public class UnitTest1
{
    [Theory]
    [InlineData("jdk", -1)]
    [InlineData("MANAGER", 1)]
    [InlineData("STAFF", 2)]
    public void ValidateUserChoiceReturn1ForManagerOr2ForStaff(string str, int returned)
    {
        //test1
        //Arrange

        //Act 
        int result = Proj1Service.ValidateUserChoice(str);

        //Assert
        Assert.Equal(returned, result);

    }
}