using System;
using Alura.LeilaoOnline.Core;
using Xunit;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.LeilaoOnline.Tests
{
    public class LanceCtor
    {
        [Fact]
        public void LancaArgumentExpectionDadoValorNegativo()
        {
            //Arranje
            var valorNegativo = -100;
            //Assert                                     //Act
            Assert.Throws<System.ArgumentException>(()=> new Lance(null, valorNegativo));
        }
    }
}
