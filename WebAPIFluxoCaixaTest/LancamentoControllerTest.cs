using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using System.Diagnostics.CodeAnalysis;
using WebAPIFluxocaixa.Controllers;
using WebAPIFluxocaixa.Models;

namespace WebAPIFluxoCaixaTest
{
  [ExcludeFromCodeCoverage]
  public class LancamentoControllerTest
  {
    private LancamentoController controller;    

    public LancamentoControllerTest()
    {
      ILogger<LancamentoController> logger = Mock.Of<ILogger<LancamentoController>>();
      controller = new LancamentoController(logger);
    }

    [Theory]
    [InlineData(0)]
    public void GetLancamentosTeste(int id)
    {            
      var resultado = controller.GetLancamentos(id);
      Assert.NotNull(resultado);
    }

    [Fact]
    public void PostLancamentosTeste()
    {
      var resultado = controller.PostLancamentos();
      Assert.NotNull(resultado);
    }

    [Fact]
    public void PutLancamentosTeste()
    {
      Lancamentos lancamentos = Mock.Of<Lancamentos>();
      var resultado = controller.Put(lancamentos);
      Assert.NotNull(resultado);
    }
  }
}