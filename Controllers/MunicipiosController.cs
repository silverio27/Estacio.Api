using System.Data.SqlClient;
using System.Linq;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Estacio.Api.Controllers
{
    [Route("api/municipios")]
    public class MunicipiosController : Controller
    {
        IConfiguration _configuration;
        SqlConnection _connection;

        public MunicipiosController(IConfiguration configuration)
        {
            _configuration = configuration;
            _connection = new SqlConnection(_configuration.GetConnectionString("estacioBd"));
        }

        [HttpGet]
        public ActionResult<dynamic> Get() => _connection.Query("select * from Municipio").ToList();


    }
}