using TestDI.Abstractions;

namespace TestDI.Ipms;

public class Test1 : ITest1
{
    private Guid _instanceId;
    public Test1()
    {
        _instanceId = Guid.NewGuid();
    }
    public Guid NewInstanceId1()
    {
        return _instanceId;
    }
}