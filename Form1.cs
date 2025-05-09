using Npgsql;
using System.Data;

namespace PBO_connect_Postgres
{
    public partial class Dekstop : Form
    {
        string InputTodo;
        DatabaseHandler db = new DatabaseHandler();
        public Dekstop()
        {
            InitializeComponent();
            gridToDo.DataSource = db.GetTodo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BoxToDo_TextChanged(object sender, EventArgs e)
        {
            InputTodo = BoxToDo.Text;
        }

        private void Simpan_Click(object sender, EventArgs e)
        {
            db.AddTodo(InputTodo);
            MessageBox.Show("Berhasil");
            BoxToDo.Clear();
            gridToDo.DataSource = db.GetTodo();

        }
    }
}


public class DatabaseHandler
{
    NpgsqlConnection conn;

    public DatabaseHandler()
    {
        conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=1685Fami;Database=pbo");
        conn.Open();
    }

    public DataTable GetTodo()
    {
        DataTable dt = new DataTable();
        using (var cmd = new NpgsqlCommand("SELECT id, teks FROM todo ORDER BY id", conn))
        using (var reader = cmd.ExecuteReader())
        {
            dt.Load(reader);
        }
        return dt;
    }

    public void AddTodo(string teks)
    {
        using (var cmd = new NpgsqlCommand("INSERT INTO todo(teks) VALUES(@teks)", conn))
        {
            cmd.Parameters.AddWithValue("@teks", teks);
            cmd.ExecuteNonQuery();
        }
    }

    public void UpdateTodo(int id, string newText)
    {
        using (var cmd = new NpgsqlCommand("UPDATE todo SET teks = @teks WHERE id = @id", conn))
        {
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@teks", newText);
            cmd.ExecuteNonQuery();
        }
    }


    public void DeleteTodo(int id)
    {
        using (var cmd = new NpgsqlCommand("DELETE FROM todo WHERE id = @id", conn))
        {
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }


    ~DatabaseHandler()
    {
        conn.Close();
    }

}
