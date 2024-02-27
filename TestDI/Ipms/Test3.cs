using TestDI.Abstractions;

namespace TestDI.Ipms;

public class Test3 : ITest3
{
    private readonly ITest2 _test2;

    public Test3(ITest2 test2)
    {
        _test2 = test2;
    }
    public Guid NewInstanctId3()
    {
        return _test2.NewInstanceId2();
    }
}