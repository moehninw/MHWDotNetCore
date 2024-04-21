using MHWDotNetCore.ConsoleApp;
using System.Data;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;

Console.WriteLine("Hello, World!");

// SqlConnection

// F5 => run code
// Ctrl + . => for suggestion
// F10 => step over (for checking each line)
// F11 => step into (for checking details)
// F9 => breakpoint

// => C# => Db

//SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();
//stringBuilder.DataSource = "DESKTOP-1P2O54N"; // server name & can give server name as "."
//stringBuilder.InitialCatalog = "DotNetTrainingBatch4"; // database name
//stringBuilder.UserID = "sa";
//stringBuilder.Password = "sa@123";
//SqlConnection connection = new SqlConnection(stringBuilder.ConnectionString);
////SqlConnection connection = new SqlConnection("Data Source=DESKTOP-1P2O54N;Initial Catalog=DotNetTrainingBatch4;User ID=sa;Password=sa@123");

//connection.Open();
//Console.WriteLine("Connection open.");

//string query = "select * from tbl_blog";
//SqlCommand cmd = new SqlCommand(query, connection);
//SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
//DataTable dt = new DataTable();
//sqlDataAdapter.Fill(dt);

//connection.Close();
//Console.WriteLine("Connection close.");

//// dataset => datatable
//// datatable => datarow
//// datarow => datacolumn

//foreach (DataRow dr in dt.Rows)
//{
//    Console.WriteLine("Blog Id => " + dr["BlogID"]);
//    Console.WriteLine("Blog Title => " + dr["BlogTitle"]);
//    Console.WriteLine("Blog Author => " + dr["BlogAuthor"]);
//    Console.WriteLine("Blog Content => " + dr["BlogContent"]);
//    Console.WriteLine("---------------------------------");
//}


// Ado.Net Read
// CRUD

AdoDotNetExample adoDotNetExample = new AdoDotNetExample();
//adoDotNetExample.Read();
//adoDotNetExample.Create("title", "author", "content");
//adoDotNetExample.Update(12, "test title", "test author", "test content");
//adoDotNetExample.Delete(12);
adoDotNetExample.Edit(12);
adoDotNetExample.Edit(1);

Console.ReadKey();