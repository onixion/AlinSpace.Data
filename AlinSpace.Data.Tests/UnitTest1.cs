using Xunit;

namespace AlinSpace.Data.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {


            var a = Entity.Create(object)


            var t = a.MakeSnapshot();


            a.Text = 3;

            a.Commit();

            a.Apply(t);
        }
    }
}