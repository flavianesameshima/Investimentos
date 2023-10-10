using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using Xunit;

namespace Investimentos.Infra.Test
{
    public class ContextTest
    {
        [Fact]
        public void TesteConexaoBancoMySQL()
        {
            //Arrange
            var options = new DbContextOptionsBuilder<InvestimentosDbContext>().Options;

            var dbContext = new InvestimentosDbContext(options);

            //Act
            var conectado = dbContext.Database.CanConnect();

            //Assert
            Assert.True(conectado);
        }
    }
}
