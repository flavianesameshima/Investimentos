using Investimentos.API.Controllers;
using Investimentos.Domain.Entities;
using Investimentos.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace Investimentos.Controller.Test
{
    public class ContaControllerTest
    {
        private readonly ContaController _controller;
        private readonly Mock<IContaService> _serviceMock;

        public ContaControllerTest()
        {
            _serviceMock = new Mock<IContaService>();
            _controller = new ContaController(_serviceMock.Object);
        }

        [Fact]
        public void CadastrarConta()
        {
            //Arrange
            var conta = new Conta("Manuel Moreira de Abrel",0, 1);

            //Act
            var resultado = _controller.CadastrarConta(conta);

            //Assert
            Assert.IsType<OkObjectResult>(resultado);
        }
    }
}
