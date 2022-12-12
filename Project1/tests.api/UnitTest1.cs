using RepoLayer;
using BusinessLayer;
using ModelsLayer;

namespace tests.api;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        IRepoLayerClass i = new MockRepoLayer();
        BusinessLayerClass b1 = new BusinessLayerClass(i);

        List<Register> list = b1.GetEmployeeList();

        Assert.Equal(list[0].FirstName, "Geli");
    }

    [Fact]
    public void Test2()
    {
        IRepoLayerClass i = new MockRepoLayer();
        BusinessLayerClass b1 = new BusinessLayerClass(i);

        List<ReimbursementRequests> list = b1.GetExpensesList();

        Assert.Equal(list[0].Amount, 456);
    }
}