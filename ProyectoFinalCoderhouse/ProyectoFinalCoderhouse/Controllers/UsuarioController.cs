using Api_AgustinNapolitano.Model;
using Api_AgustinNapolitano.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using Api_AgustinNapolitano.Controllers.DTO;


namespace Api_AgustinNapolitano.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet(Name = "GetUsuarios")]
        public List<Usuario> GetUsuarios()
        {
            try
            {
                return UsuarioHandler.GetUsuarios();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<Usuario>();
            }

        }

        [HttpPut]
        public bool ModificarUsuario([FromBody] PutUsuario usuario)
        {
            try
            {
                return UsuarioHandler.ModificarUsuario(new Usuario
                {
                    Nombre = usuario.Nombre,
                    Apellido = usuario.Apellido,
                    NombreUsuario = usuario.NombreUsuario,
                    Contrasena = usuario.Contraseña,
                    Mail = usuario.Mail,
                    Id = usuario.Id
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        [HttpDelete]
        public bool EliminarUsuario([FromBody] int id)
        {
            try
            {
                return UsuarioHandler.EliminarUsuario(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }

        [HttpPost]
        public bool CrearUsuario([FromBody] PostUsuario usuario)
        {
            try
            {
                return UsuarioHandler.CrearUsuario(new Usuario
                {
                    Nombre = usuario.Nombre,
                    Apellido = usuario.Apellido,
                    NombreUsuario = usuario.NombreUsuario,
                    Contrasena = usuario.Contraseña,
                    Mail = usuario.Mail
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }
    }
}