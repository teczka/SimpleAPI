namespace SimpleAPI.Test;
using SimpleAPI.Controllers;

public class UnitTest1
{
    ValuesController controller = new ValuesController();

    [Fact]
    public void GetReturnName()
    {
        var returnValue = controller.Get().Value;
        Assert.Equal("Pawel", returnValue);
    }
}