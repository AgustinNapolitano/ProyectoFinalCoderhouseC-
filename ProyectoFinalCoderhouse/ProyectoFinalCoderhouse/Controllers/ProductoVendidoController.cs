using Api_AgustinNapolitano.Model;
using Api_AgustinNapolitano.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using Api_AgustinNapolitano.Controllers.DTO;

namespace Api_AgustinNapolitano.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductoVendidoController : ControllerBase
    {
        [HttpGet(Name = "GetProductosVendidos")]
        public List<ProductoVendido> GetProductosVendidos()
        {
            try
            {
                return ProductoVendidoHandler.GetProductosVendidos();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<ProductoVendido>();
            }

        }


        [HttpDelete]
        public bool EliminarProductoVendido([FromBody] int id)
        {
            try
            {
                return ProductoVendidoHandler.EliminarProductoVendido(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }


        [HttpPost]
        public bool CrearProductoVendido([FromBody] PostProductoVendido productoVendido)
        {
            try
            {
                return ProductoVendidoHandler.CrearProductoVendido(new ProductoVendido
                {
                    Stock = productoVendido.Stock,
                    IdProducto = productoVendido.IdProducto
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }


        [HttpPut]
        public bool ModificarProductoVendido([FromBody] PutProductoVendido productoVendido)
        {
            try
            {
                return ProductoVendidoHandler.ModificarProductoVendido(new ProductoVendido
                {
                    Id = productoVendido.Id,
                    Stock = productoVendido.Stock,
                    IdProducto = productoVendido.IdProducto
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