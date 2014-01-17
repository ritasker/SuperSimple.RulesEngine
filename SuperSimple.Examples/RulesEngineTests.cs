using Xunit;
namespace SuperSimple.Examples
{

    public class RulesEngineTests
    {
        [Fact]
        public void TestA()
        {
            var sut = new RulesEngineImpleamentation();

            var result = sut.Run();


        }

    }

    public class RulesEngineImpleamentation
    {
        public void Run()
        {
            var po = new PO { TotalValue = 3000 };

            po.ApplyRule(new PoNeedToBeApprovedRule())
                    .ApplyRule(new PoIsMassiveRule());

            return po;
        }
    }
}
