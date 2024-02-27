using TestDI.Abstractions;

namespace TestDI.Ipms;

public class Test2 : ITest2
{
    private readonly ITest1 _test1;
    public Test2(ITest1 test1)
    {
        _test1 = test1;
    }

    public Guid NewInstanceId2()
    {
        return _test1.NewInstanceId1();
    }
}