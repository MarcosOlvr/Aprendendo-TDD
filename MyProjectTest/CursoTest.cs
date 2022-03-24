using MyProject;
using Xunit;

namespace MyProjectTest
{
    public class CursoTest
    {
        [Fact]
        public void CriarCursoRetornarCurso()
        {
            // Arrange
            var cursoEsperado = new 
            { 
                Nome = "Curso de TDD",
                CargaHoraria = (double)40,
                PublicoAlvo = "Estudante",
                Valor = (decimal)100
            };
            
            var expected = cursoEsperado.Nome;

            // Act
            var curso = new Curso(cursoEsperado.Nome, cursoEsperado.CargaHoraria, cursoEsperado.PublicoAlvo, cursoEsperado.Valor);
            var result = curso.Nome;

            // Assert
            Assert.Equal(expected, result);
        }
        
        [Fact]
        public void CursoParaUniversitarioFalse()
        {
            // Arrange
            var cursoEsperado = new 
            { 
                Nome = "Curso de TDD",
                CargaHoraria = (double)40,
                PublicoAlvo = "Estudante",
                Valor = (decimal)100
            };
            var curso = new Curso(cursoEsperado.Nome, cursoEsperado.CargaHoraria, cursoEsperado.PublicoAlvo, cursoEsperado.Valor);
            var expected = false;

            // Act
            var result = curso.ParaUniversitario();

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CursoParaUniversitarioTrue()
        {
            // Arrange
            var cursoEsperado = new
            {
                Nome = "Curso de TDD",
                CargaHoraria = (double)40,
                PublicoAlvo = "Universitário",
                Valor = (decimal)100
            };
            var curso = new Curso(cursoEsperado.Nome, cursoEsperado.CargaHoraria, cursoEsperado.PublicoAlvo, cursoEsperado.Valor);
            var expected = true;

            // Act
            var result = curso.ParaUniversitario();

            // Assert
            Assert.Equal(expected, result);
        }
    }
}