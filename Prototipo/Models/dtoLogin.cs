using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.data.SqlClient;
using Util;
namespace Prototipo.Models{
    public class Login(){
        string cn = ""
        public Login(Util util){
            cn = "Server=ec2-18-117-244-122.us-east-2.compute.amazonaws.com;Database=db_CompuXPress;User Id=xpress;Password=xpress12345;Trusted_Connection=False;MultipleActiveResultSets=true;";
        }

        public string Login(string usuario, string password){
            using (var connection = new SqlConnection(cn)){
                try{
                    string sql = "SELECT * FROM t_usuario WHERE usuario = @usuario AND pwd = @password";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@usuario", "admin");
                    command.Parameters.AddWithValue("@password", "admin");
                    connection.Open();
                    var reader = command.ExecuteReader();
                    if(reader.HasRows){
                        return "Login Correcto";
                    }
                    else{
                        return "Usuario o Contraseña Incorrecto";
                    }
                }catch(Exception ex){
                    return ex.Message;
                }
            }
        }
        
}
}
