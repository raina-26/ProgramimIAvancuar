using Microsoft.Data.SqlClient;

Console.WriteLine($"Environment Version: {Environment.Version}");


string connString = "Data Source=DESKTOP-51LPE9K\\SQLEXPRESS;Initial Catalog=StudentDB;" +
    "Integrated Security=True;Persist Security Info=False;Pooling=False;" +
    "MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=True;" +
    "Application Name=\"SQL Server Management Studio\";Command Timeout=0";

string query = "select count(*) from studentet;";

SqlConnection conn = new SqlConnection(connString);

using (conn) {
    SqlCommand cmd = new SqlCommand(query, conn);
    conn.Open();

    object result = cmd.ExecuteScalar();

    Console.WriteLine($"Tabela Studentet ka {result} rekorde");

}
