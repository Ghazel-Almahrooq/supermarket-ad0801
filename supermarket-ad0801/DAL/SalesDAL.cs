using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using supermarket_ad0801.entities;

namespace supermarket_ad0801
{
   public class SalesDAL
    {
        private static string StringConniction = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\ASH\\OneDrive\\Documents\\supermarket.accdb";
        private static OleDbConnection Connection = new OleDbConnection();
        public static void InsertCommand(Sales sales)
        {
            string commandText = string.Format("Insert into Sales(Product,Quantity,Price)" +
                "values('{0}','{1}','{2}')", sales.Product, sales.Quantity, sales.Price);
            OleDbCommand command = new OleDbCommand(commandText, Connection);
            Connection.Open();
            command.ExecuteNonQuery();
            Connection.Close();

        }
        public static void UpdateCommand(Sales sales)
        {
            string commandText = string.Format("Update Sales set Product='{1}',Quantity='{2}',Price='{3}'" +
                "where Sid={0}",sales.Sid, sales.Product, sales.Quantity, sales.Price);
            OleDbCommand command = new OleDbCommand(commandText, Connection);
            Connection.Open();
            command.ExecuteNonQuery();
            Connection.Close();

        }
        public static void DeleteCommand(Sales sales)
        {
            string commandText = string.Format("Delete from Sales where Sid={0}",sales.Sid);
            OleDbCommand command = new OleDbCommand(commandText, Connection);
            Connection.Open();
            command.ExecuteNonQuery();
            Connection.Close();

        }
        public static DataTable GetAllCommand()
        {
            string commandText = string.Format("Select * from Sales");
            OleDbCommand command = new OleDbCommand(commandText, Connection);
            OleDbDataAdapter Da = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            Da.Fill(dt);
            return dt;

        }

    }
}
