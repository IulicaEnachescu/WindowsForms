using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class UserRepository
    {
       public List<User> GetAll()
        {
           List< User> users = new List <User>();
            try
            {
                string query = "SELECT * FROM [FormsProject].[dbo].[Users]";
                var conn = ConnectionManager.GetConnection();
                if (conn.State == ConnectionState.Closed)
                {
                    conn = ConnectionManager.OpenConnection(conn);
                }
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader read = command.ExecuteReader();
                var lista = ReadReader(read);
                read.Close();
                conn.Close();
                
            }
            catch (SqlException e)
            {

                Console.WriteLine(e.StackTrace);
            }
            return users;
        }
        public bool VerifyUser(string _userName, string _password)
        {
            User user = new User();
            var lista =GetAll();
           // var y=lista.FirstOrDefault(x => (x.UserName == _userName && x.Parola == _password));
            var s= lista.Exists(i => (i.UserName == _userName && i.Parola == _password));
            return s;



        }
        private List<User> ReadReader(SqlDataReader read)
        {
      //      SELECT[Id]
      //,[UserName]
      //,[Nume]
      //,[Prenume]
      //,[Parola]
      //,[UserTypeId]
      //,[AddressId]
      //  FROM[dbo].[Users]
        List<User> users = new List<User>();
            while (read.Read())
            {
                User cr = new User();    
                cr.Id = (int)read["Id"];
                cr.UserName = read["UserName"].ToString();
                cr.Nume = read["Nume"].ToString();
                cr.Prenume = read["Prenume"].ToString();
                cr.Parola = read["Parola"].ToString();
                cr.UserTypeId= (int)read["UserTypeId"];
                cr.AddressId = (int)read["AddressId"];
            }
            read.Close();
            return users;
        }

    }
}
