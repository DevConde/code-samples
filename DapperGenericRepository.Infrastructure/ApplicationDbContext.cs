using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperGenericRepository.Infrastructure
{
    public class ApplicationDbContext
    {
        private readonly IConfiguration _configuration;

        public ApplicationDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IDbConnection CreateConnection(string connectionString = "DefaultConnection")
        {
            string? connection = _configuration.GetConnectionString(connectionString);
            // return new NpgsqlConnection(connection);
            return null;

        }
    }

}
