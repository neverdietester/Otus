using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Dapper.Contrib;
using Npgsql;

namespace Homework_16
{
   public class Dapper
    {
        public static IEnumerable<Customers> GetCustomers()
        {
            using (var conn = new NpgsqlConnection(Config.SqlConnectionString))
            {
                string sql = @"select id, firstname,lastname, age from customers";
                return conn.Query<Customers>(sql);
            }
        }

        public static IEnumerable<Customers> GetCustomers(string pattern)
        {
            using (var conn = new NpgsqlConnection(Config.SqlConnectionString))
            {
                string sql = $"select id, firstname,lastname, age from customers where firstname like '%@pattern%'";
                return conn.Query<Customers>(sql, new { pattern });
            }
        }

        public static Customers GetCustomerById(int id)
        {
            using (var conn = new NpgsqlConnection(Config.SqlConnectionString))
            {
                string sql = $"select id, firstname,lastname, age from customers where id = @id";
                return conn.QueryFirstOrDefault<Customers>(sql, new { id });
            }
        }

        public static void Insert(Customers customer)
        {
            using (var conn = new NpgsqlConnection(Config.SqlConnectionString))
            {
                string sql = $"insert into customers (id, firstname,lastname, age) values (@id,@firstname,@lastname,@age )";
                conn.Execute(sql, new { id = customer.Id, firstname = customer.FirstName, lastname = customer.LastName, age = customer.Age });
            }
        }
    }
}
