namespace FirstPrinciples.Tests.Features
{
    public class UsuariosServiceTests
    {
        //[Fact]
        //public void ObterTodos_DeveRetornarTodosOsUsuarios()
        //{
        //    // Arrange
        //    IUsuariosService usuariosService = new UsuariosService();

        //    var usuario1 = new UsuarioBuilder()
        //        .WithId(1)
        //        .WithNombre("Usuario 1")
        //        .Build();

        //    usuariosService.RegistrarUsuario(usuario1);

        //    var usuario2 = new UsuarioBuilder()
        //        .WithId(1)
        //        .WithNombre("Usuario 2")
        //        .Build();

        //    usuariosService.RegistrarUsuario(usuario2);
        //    // Act
        //    List<Usuario> usuarios = usuariosService.ObterTodos();

        //    // Assert
        //    usuarios.Should().NotBeNull();
        //    usuarios.Should().HaveCount(2);
        //}

        //[Theory]
        //[InlineData("  ")]
        //[InlineData("        ")]
        //public void RegistrarUsuario_Escenario_Clave_Invalida_Por_Espacios(string clave)
        //{
        //    // Arrange
        //    IUsuariosService usuariosService = new UsuariosService();
        //    var usuario = new UsuarioBuilder()
        //        .WithClave(clave)
        //        .Build();

        //    // Act
        //    usuariosService.Invoking(usuariosService => usuariosService.RegistrarUsuario(usuario))
        //        .Should().Throw<Exception>()
        //        .WithMessage("La clave debe tener al menos 8 caracteres");
        //}

        //[Theory]
        //[InlineData("12345678")]
        //[InlineData("123456789")]
        //[InlineData("1234567890")]
        //public void RegistrarUsuario_Escenario_Clave_Debe_TenerNumeros_Y_Caracteres(string clave)
        //{
        //    // Arrange
        //    IUsuariosService usuariosService = new UsuariosService();
        //    var usuario = new UsuarioBuilder()
        //        .WithClave(clave)
        //        .Build();

        //    // Act
        //    usuariosService.Invoking(usuariosService => usuariosService.RegistrarUsuario(usuario))
        //        .Should().Throw<Exception>()
        //        .WithMessage("La clave debe tener al menos 1 caracter especial, 1 mayuscula y 1 minuscula");
        //}
    }
}
