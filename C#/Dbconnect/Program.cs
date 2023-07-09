
using System.Data.SqlClient;
namespace Dbconnect
{


    class Program
    {
        public static void Main(string[] args)
        {
            DB db = new DB();
            db.OpenConn();
            //db.CreateTable();
            db.InsertTable();
            db.CloseConn();
        }
    }
}