using X_si_0;
namespace Teste_X_si_0
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1, 1);
        }


    }

    [TestClass]
    public class TablaTest
    {
        [TestMethod]
        public void TablaTest1()
        {
            Tabla t = new Tabla();
            Assert.IsTrue(t.EstePozitiaLibera(0, 0));
        }
    }
}
