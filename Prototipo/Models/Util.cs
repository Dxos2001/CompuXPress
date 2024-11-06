using Microsoft.Data.SqlClient;

namespace Prototipo.Models;
using System;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

public class Util
{
    private readonly string _connectionString;

    public Util(IConfiguration configuration)
    {
        // Lee la cadena de conexión desde appsettings.json
        _connectionString = configuration.GetConnectionString("DefaultConnection");
    }

    // Método para obtener la conexión SQL
    public SqlConnection GetConnection()
    {
        return new SqlConnection(_connectionString);
    }

    // Método para probar la conexión a la base de datos
    public bool TestConnection()
    {
        using (var connection = GetConnection())
        {
            try
            {
                connection.Open();
                Console.WriteLine("Conexión exitosa a la base de datos.");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error de conexión: {ex.Message}");
                return false;
            }
        }
    }
    
}