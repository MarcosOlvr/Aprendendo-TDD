using MyProject;
using Xunit;

namespace MyProjectTest
{
    public class UserTest
    {
        [Fact]
        public void UsuarioMaiorDeIdade()
        {
            // Arrange
            var user = new User("José", 45);
            var expected = true;

            // Act
            var result = user.MaiorDeIdade();

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void UsuarioMenorDeIdade()
        {
            // Arrange
            var user = new User("João", 17);
            var expected = false;

            // Act
            var result = user.MaiorDeIdade();

            // Assert
            Assert.Equal(expected, result);
        }
    }
}