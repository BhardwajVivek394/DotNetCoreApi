using CoreWebAPIAzure;
using CoreWebAPIAzure.Controllers;
using Xunit;

namespace CoreWebAPIAzure.Test;

public class UnitTest1
{
    ValuesController val=new ValuesController();                //Arrange
    [Fact]                                                      //Arrange, Act and Assert
    public void Test1()
    {
        var test=val.Get(1);                                    //Act
        Assert.Equal("Vivek",test);
    }
}