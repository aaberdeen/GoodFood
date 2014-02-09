using System;
using System.Data;
using System.Data.SQLite;
using System.Collections.Generic;
using System.IO;

namespace Good_Food_Database
{
    public class SQLITE
    {
        private SQLiteConnection con;
        private SQLiteCommand cmd;
        private SQLiteDataAdapter adapter;

        public SQLITE(string databasename)
        {
            con = new SQLiteConnection(string.Format("Data Source={0}", databasename));
        }
        public int Execute(string sql_statement)
        {
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = sql_statement;
            int row_updated;
            try
            {
                row_updated = cmd.ExecuteNonQuery();
            }
            catch
            {
                con.Close();
                return 0;
            }
            con.Close();
            return row_updated;
        }
        public DataTable GetDataTable(string tablename)
        {DataTable DT = new DataTable();
            if (con.ConnectionString != "")
            {

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                cmd = con.CreateCommand();
                cmd.CommandText = string.Format("SELECT * FROM {0}", tablename);
                // cmd.CommandText = string.Format("select source_name, recipe_name, page_number, author, issue, section_id,Comments,rating from Recipes, source where recipes.source_id = source.source_id");
                adapter = new SQLiteDataAdapter(cmd);
                adapter.AcceptChangesDuringFill = false;
                adapter.Fill(DT);
                con.Close();
                DT.TableName = tablename;
                foreach (DataRow row in DT.Rows)
                {
                    row.AcceptChanges();
                }
            }
            return DT;
        }
        public DataTable GetDataTable(string tablename, string[] where)
        {
            DataTable DT = new DataTable();
            con.Open();
            cmd = con.CreateCommand();

            // select * from recipes where source_id like "3"

            cmd.CommandText = string.Format("SELECT * FROM {0} where {1}", tablename, where[0]);

            for (int i = 1; i < where.Length; i++)
            {
                if (where[i] != null)
                {
                    cmd.CommandText += string.Format(" and {0}", where[i]);
                }
                
            }
            // cmd.CommandText = string.Format("select source_name, recipe_name, page_number, author, issue, section_id,Comments,rating from Recipes, source where recipes.source_id = source.source_id");
            adapter = new SQLiteDataAdapter(cmd);
            adapter.AcceptChangesDuringFill = false;
            adapter.Fill(DT);
            con.Close();
            DT.TableName = tablename;
            foreach (DataRow row in DT.Rows)
            {
                row.AcceptChanges();
            }
            return DT;
        }
        public void SaveDataTable(DataTable DT)
        {
            try
            {
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = string.Format("SELECT * FROM {0}", DT.TableName);
                //cmd.CommandText = string.Format("select source_name, recipe_name, page_number, author, issue, section_id,Comments,rating from Recipes, source where recipes.source_id = source.source_id");
                adapter = new SQLiteDataAdapter(cmd);
                SQLiteCommandBuilder builder = new SQLiteCommandBuilder(adapter);
                adapter.Update(DT);
                con.Close();
            }
            catch (Exception Ex)
            {
               // System.Windows.MessageBox.Show(Ex.Message);
            }
        }

        /// <summary>

        ///     Allows the programmer to easily insert into the DB

        /// </summary>

        /// <param name="tableName">The table into which we insert the data.</param>

        /// <param name="data">A dictionary containing the column names and data for the insert.</param>

        /// <returns>A boolean true or false to signify success or failure.</returns>

        public bool Insert(String tableName, Dictionary<String, String> data)
        {

            String columns = "";

            String values = "";

            Boolean returnCode = true;

            foreach (KeyValuePair<String, String> val in data)
            {

                columns += String.Format(" {0},", val.Key.ToString());

                values += String.Format(" '{0}',", val.Value);

            }

            columns = columns.Substring(0, columns.Length - 1);

            values = values.Substring(0, values.Length - 1);

            try
            {
                string comand = String.Format("insert into {0}({1}) values({2});", tableName, columns, values);
                this.ExecuteNonQuery(comand);

            }

            catch (Exception fail)
            {

               // MessageBox.Show(fail.Message);

                returnCode = false;

            }

            return returnCode;

        }


        public void insertSource(String @source)
        {
            con.Open();
            SQLiteCommand command = con.CreateCommand();
            // http://www.sqlite.org/faq.html#q1
            command.CommandText = "INSERT into source(source_name) VALUES(@source)";
            command.Parameters.Add(new SQLiteParameter("@source", @source));
           
            command.ExecuteNonQuery();
            con.Close();
        }


        /// <summary>

        ///     Allows the programmer to interact with the database for purposes other than a query.

        /// </summary>

        /// <param name="sql">The SQL to be run.</param>

        /// <returns>An Integer containing the number of rows updated.</returns>

        public int ExecuteNonQuery(string sql)
        {

           // SQLiteConnection cnn = new SQLiteConnection(con);

           // cnn.Open();

            con.Open();
            SQLiteCommand mycommand = new SQLiteCommand(con);

            mycommand.CommandText = sql;

            int rowsUpdated = mycommand.ExecuteNonQuery();

            con.Close();

            return rowsUpdated;

        }

      

        /// <summary>

        ///     Allows the programmer to easily update rows in the DB.

        /// </summary>

        /// <param name="tableName">The table to update.</param>

        /// <param name="data">A dictionary containing Column names and their new values.</param>

        /// <param name="where">The where clause for the update statement.</param>

        /// <returns>A boolean true or false to signify success or failure.</returns>

        public bool Update(String tableName, Dictionary<String, String> data, String where)
        {

            String vals = "";

            Boolean returnCode = true;

            if (data.Count >= 1)
            {

                foreach (KeyValuePair<String, String> val in data)
                {

                    vals += String.Format(" {0} = '{1}',", val.Key.ToString(), val.Value.ToString());

                }

                vals = vals.Substring(0, vals.Length - 1);

            }

            try
            {

                this.ExecuteNonQuery(String.Format("update {0} set {1} where {2};", tableName, vals, where));

            }

            catch
            {

                returnCode = false;

            }

            return returnCode;

        }
        /// <summary>

        ///     Allows the programmer to easily delete rows from the DB.

        /// </summary>

        /// <param name="tableName">The table from which to delete.</param>

        /// <param name="where">The where clause for the delete.</param>

        /// <returns>A boolean true or false to signify success or failure.</returns>

        public bool Delete(String tableName, String where)
        {

            Boolean returnCode = true;

            try
            {

                this.ExecuteNonQuery(String.Format("delete from {0} where {1};", tableName, where));

            }

            catch (Exception fail)
            {

                // MessageBox.Show(fail.Message);

                returnCode = false;

            }

            return returnCode;

        }


        /// <summary>
        /// 
        /// 
        /// </summary>
        /// <param name="strConnection"></param>
        public void executeScript(string scriptFile)
        {
            string strCommand = File.ReadAllText(scriptFile); // .sql file path

            using (con)
            {
                using (SQLiteCommand objCommand = con.CreateCommand())
                {
                    con.Open();
                    objCommand.CommandText = strCommand;
                    objCommand.ExecuteNonQuery();
                    con.Close();
                }
            }

        }

    }
}
