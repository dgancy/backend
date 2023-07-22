using MySql.Data.MySqlClient;
using Model;

namespace Database;
public class DatabaseContext
{
    private MySqlConnection con;

    private string cs = @"
        server=127.0.0.1:8080;
        uid=root;
        password=root;
        database=dip";
    public DatabaseContext()
    {
        con = new MySqlConnection(cs);
        con.Open();
    }

    public int Registration(AccountModel account)
    {
        return 0;
    }
}
