using EscolhedorDeJogos.Domain.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EscolhedorDeJogos.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var service = new JogoService();

            var resultado = service.GetJogos();
        }
    }
}
