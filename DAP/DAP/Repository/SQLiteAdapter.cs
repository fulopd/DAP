using DAP.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Telepítve NuGet: System.Data.SQLite.Core
namespace DAP.Repository
{
    class SQLiteAdapter
    {
        private SQLiteConnection myConnection;

        public SQLiteAdapter()
        {
            myConnection = new SQLiteConnection("Data Source=Archives.sqlite");
        }

        public void insertData(Document insert) {

            myConnection.Open();
            string query = "INSERT INTO ArchivesTable ('Company', 'Category', 'Content', 'Date', 'Description') VALUES (@Company, @Category, @Content, @Date, @Description)";
            SQLiteCommand myCommand = new SQLiteCommand(query, myConnection);
            myCommand.Parameters.AddWithValue("@Company", insert.getCompany());
            myCommand.Parameters.AddWithValue("@Category", insert.getCategory());
            myCommand.Parameters.AddWithValue("@Content", insert.getContent());
            myCommand.Parameters.AddWithValue("@Date", insert.getDate());
            myCommand.Parameters.AddWithValue("@Description", insert.getDescription());          
            myCommand.ExecuteNonQuery();
            myConnection.Close();
        }
               
        public DataTable getData()
        {
            DataTable dt = new DataTable();
            myConnection.Open();
            string query = "SELECT * FROM ArchivesTable";
            SQLiteCommand myCommand = new SQLiteCommand(query, myConnection);

            SQLiteDataReader reader = myCommand.ExecuteReader();

            dt.Load(reader);
           
            myConnection.Close();
            Debug.WriteLine("Lekérted az összes adatot az adatbázistól");
            return dt;
        }

        public List<string> getUnicItemsIntoColumn(string columnName)
        {

            List<string> itemsList = new List<string>();

            myConnection.Open();
            string query = "SELECT DISTINCT "+ columnName + " FROM ArchivesTable";
            SQLiteCommand myCommand = new SQLiteCommand(query, myConnection);

            SQLiteDataReader reader = myCommand.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    itemsList.Add(reader[columnName].ToString());
                }
            }

            myConnection.Close();

            return itemsList;
        }
        
        public void deleteItems(HashSet<string> ids)
        {
            SQLiteCommand myCommand;
            SQLiteDataReader reader;
            string query = "DELETE FROM ArchivesTable WHERE";
            StringBuilder sb = new StringBuilder();
            int i = 0;
            myConnection.Open();

            for (i=0; i < ids.Count; i++)
            {   
                if (i % 999 == 9)
                {
                    sb.Append(" ID=" + ids.ElementAt(i) + " OR");
                    query += sb.ToString().Substring(0, sb.ToString().Length - 3);
                    myCommand = new SQLiteCommand(query, myConnection);
                    reader = myCommand.ExecuteReader();
                    query = "DELETE FROM ArchivesTable WHERE";
                    sb.Clear();
                }
                else
                {   
                    sb.Append(" ID=" + ids.ElementAt(i) + " OR");                    
                }


            }
            query += sb.ToString().Substring(0, sb.ToString().Length - 3);
            myCommand = new SQLiteCommand(query, myConnection);
            reader = myCommand.ExecuteReader();

            myConnection.Close();


            
        }
        
        public DataTable searchData(string search, List<string> category)
        {
            DataTable dt = new DataTable();            
            myConnection.Open();
            string query = "SELECT * FROM ArchivesTable WHERE ";

            for (int i = 0; i < category.Count; i++)
            {
                if (i != category.Count - 1)
                {
                    query += category[i] + " LIKE " + "'%" + search + "%' OR ";
                }
                else
                {
                    query += category[i] + " LIKE " + "'%" + search + "%' ";
                }
            }

            SQLiteCommand myCommand = new SQLiteCommand(query, myConnection);
            SQLiteDataReader reader = myCommand.ExecuteReader();

            dt.Load(reader);

            myConnection.Close();
            Debug.WriteLine("Lekérted az adatbázistól " + search +" találatokat");
            return dt;
        }

        /// <summary>
        /// Ducument Listát alakít DataTable -lé
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public DataTable convertToDataTable(List<Document> data)
        {

            DataTable dt = new DataTable();

            dt.Columns.Add("ID");
            dt.Columns.Add("Company");
            dt.Columns.Add("Category");
            dt.Columns.Add("Content");
            dt.Columns.Add("Date");
            dt.Columns.Add("Description");          

            foreach (Document item in data)
            {
                var row = dt.NewRow();

                row["ID"] = item.getID();
                row["Company"] = item.getCompany();
                row["Category"] = item.getCategory();
                row["Content"] = item.getContent();
                row["Date"] = item.getDate();
                row["Description"] = item.getDescription();                

                dt.Rows.Add(row);
            }

            return dt;
        }

        public void modifyItem(Document modItem) {

            myConnection.Open();
            string query = "UPDATE ArchivesTable SET Company = @Company, Category = @Category, Content = @Content, Date = @Date, Description = @Description WHERE ID='" + modItem.getID() + "'";
            SQLiteCommand myCommand = new SQLiteCommand(query, myConnection);
            myCommand.Parameters.AddWithValue("@Company", modItem.getCompany());
            myCommand.Parameters.AddWithValue("@Category", modItem.getCategory());
            myCommand.Parameters.AddWithValue("@Content", modItem.getContent());
            myCommand.Parameters.AddWithValue("@Date", modItem.getDate());
            myCommand.Parameters.AddWithValue("@Description", modItem.getDescription());           
            myCommand.ExecuteNonQuery();
            myConnection.Close();
        }

        public void multiUpdate(HashSet<string> ids, string columnName, string newValue)
        {
            StringBuilder sb = new StringBuilder();
            myConnection.Open();
            string query = "UPDATE ArchivesTable SET " + columnName + " = @" + columnName + " WHERE";
            SQLiteCommand myCommand = new SQLiteCommand(query, myConnection);
            

            int i = 0;
           

            for (i = 0; i < ids.Count; i++)
            {
                if (i % 999 == 9)
                {
                    sb.Append(" ID=" + ids.ElementAt(i) + " OR");
                    query += sb.ToString().Substring(0, sb.ToString().Length - 3);
                    myCommand = new SQLiteCommand(query, myConnection);
                    myCommand.Parameters.AddWithValue("@" + columnName, newValue);
                    myCommand.ExecuteNonQuery();
                    query = "UPDATE ArchivesTable SET " + columnName + " = @" + columnName + " WHERE";
                    sb.Clear();
                }
                else
                {
                    sb.Append(" ID=" + ids.ElementAt(i) + " OR");
                }


            }

            if (sb.ToString().Length > 3)
            {
                query += sb.ToString().Substring(0, sb.ToString().Length - 3);
                myCommand = new SQLiteCommand(query, myConnection);
                myCommand.Parameters.AddWithValue("@" + columnName, newValue);
                myCommand.ExecuteNonQuery();
            }
            
            myConnection.Close();
        }

        public int getLastInserItemID()
        {

            int maxID = 0;
            myConnection.Open();
            string query = "SELECT * FROM ArchivesTable WHERE ID = (SELECT MAX(ID) FROM ArchivesTable)";
            SQLiteCommand myCommand = new SQLiteCommand(query, myConnection);

            SQLiteDataReader reader = myCommand.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    maxID = Convert.ToInt32(reader["ID"]);
                }
            }

            myConnection.Close();

            return maxID;
        }

        public DataSet getSelectedData(HashSet<string> ids)
        {
            DataSet ds = new DataSet();
            DataTable dtFinal = new DataTable();
            DataTable dtSub = new DataTable();
            SQLiteCommand myCommand;
            SQLiteDataReader reader;
            string query = "SELECT * FROM ArchivesTable WHERE";
            StringBuilder sb = new StringBuilder();
            int i = 0;
            myConnection.Open();

            for (i = 0; i < ids.Count; i++)
            {
                if (i % 999 == 9)
                {
                    sb.Append(" ID=" + ids.ElementAt(i) + " OR");
                    query += sb.ToString().Substring(0, sb.ToString().Length - 3);
                    myCommand = new SQLiteCommand(query, myConnection);
                    reader = myCommand.ExecuteReader();
                    dtSub.Load(reader);
                    dtFinal.Merge(dtSub);
                    query = "SELECT * FROM ArchivesTable WHERE";
                    sb.Clear();
                }
                else
                {
                    sb.Append(" ID=" + ids.ElementAt(i) + " OR");
                }

            }
            
            query += sb.ToString().Substring(0, sb.ToString().Length - 3);
            myCommand = new SQLiteCommand(query, myConnection);
            reader = myCommand.ExecuteReader();
            dtSub.Load(reader);
            dtFinal.Merge(dtSub);
            dtFinal.Load(reader);
            ds.Tables.Add(dtFinal);

            myConnection.Close();

            return ds;
            //return dtFinal;
        }










    }
}
