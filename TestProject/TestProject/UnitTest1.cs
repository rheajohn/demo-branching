namespace TestProject;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.True(true);
    }
    
    [Fact]
    public void FalseIsFalseAndStringIsEmpty()
    {
        Assert.False(!true);
        Assert.Empty("");
        //this was stupid
        Assert.True(!false);
    }
}
