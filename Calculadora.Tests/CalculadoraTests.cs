namespace Calculadora.Tests;
using Calculadora.Services;
public class CalculadoraTests
{
    private Calculadora _calc = new Calculadora();

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(4, 5, 9)]
    [InlineData(6, 7, 13)]
    public void TesteResultadoDaSomaDeDoisNumeros(int num1, int num2, int resultado)
    {           
        //Act
        int resultadoCalc = _calc.Somar(num1, num2);

        //Assert
        Assert.Equal(resultado, resultadoCalc);
    }

    [Theory]
    [InlineData(2, 1, 1)]
    [InlineData(6, 3, 3)]
    [InlineData(7, 2, 5)]
    public void TesteResultadoDaSubtracaoDeDoisNumeros(int num1, int num2, int resultado)
    {           
        //Act
        int resultadoCalc = _calc.Subtrair(num1, num2);

        //Assert
        Assert.Equal(resultado, resultadoCalc);
    }

    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(4, 5, 20)]
    [InlineData(6, 7, 42)]
    public void TesteResultadoDaMultiplicacaoDeDoisNumeros(int num1, int num2, int resultado)
    {           
        //Act
        int resultadoCalc = _calc.Multiplicar(num1, num2);

        //Assert
        Assert.Equal(resultado, resultadoCalc);
    }

    [Theory]
    [InlineData(6, 2, 3)]
    [InlineData(5, 5, 1)]
    [InlineData(8, 4, 2)]
    public void TesteResultadoDaDivisaoDeDoisNumeros(int num1, int num2, int resultado)
    {         
        //Act
        int resultadoCalc = _calc.Dividir(num1, num2);

        //Assert
        Assert.Equal(resultado, resultadoCalc);
    }

    [Fact]
    public void TentarDividirPorZero()
    {   

        // Assert
        Assert.Throws<DivideByZeroException>(() => _calc.Dividir(3,0));
    }

    [Fact]
    public void TestarHistorico()
    {   
        //Act
        _calc.Somar(1, 2);
        _calc.Subtrair(2, 1);
        _calc.Multiplicar(2, 3);
        _calc.Dividir(4, 2);
        
        var lista = _calc.Historico();

        //Assert
        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count());
    }
}