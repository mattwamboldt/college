using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace Database
{
    public class MSAccessDatabase
    {
        #region "Working code"
        private OleDbConnection myConnection;
        private DataSet myDataSet;
        private Dictionary<string,OleDbDataAdapter> myDataAdapters;

        public MSAccessDatabase( string databasePath )
        {
            myConnection = new OleDbConnection("Provider=Microsoft." +
                "Jet.OLEDB.4.0;Data Source=" + databasePath);
            myDataAdapters = new Dictionary<string,OleDbDataAdapter>();
            myDataSet = new DataSet();
        }

        ~MSAccessDatabase()
        {
            if( myConnection != null )
            {
                myConnection.Close();
            }
        }

        public bool LoadTableData(params string[] tablenames)
        {
            try
            {
                foreach (string tablename in tablenames)
                {
                    //create the adapter for the table provided
                    myDataAdapters.Add(tablename, new OleDbDataAdapter("SELECT * FROM " + tablename + ";", myConnection));
                    myDataAdapters[tablename].MissingSchemaAction = MissingSchemaAction.AddWithKey;
                    myDataAdapters[tablename].Fill(myDataSet, tablename);
                    OleDbCommandBuilder builder = new OleDbCommandBuilder(myDataAdapters[tablename]);
                    builder.SetAllValues = false;
                    builder.QuotePrefix = "[";
                    builder.QuoteSuffix = "]";
                    myDataAdapters[tablename].InsertCommand = builder.GetInsertCommand(true);
                    myDataAdapters[tablename].UpdateCommand = builder.GetUpdateCommand(true);
                    myDataAdapters[tablename].DeleteCommand = builder.GetDeleteCommand(true);
                }
                return true;
            }
            catch( Exception )
            {
                return false;
            }
        }

        public bool Save()
        {
            try
            {
                foreach(KeyValuePair<string, OleDbDataAdapter> adapterPair in myDataAdapters)
                {
                    adapterPair.Value.Update(myDataSet, adapterPair.Key);
                    if (myDataSet.HasErrors)
                    {
                        myDataSet.RejectChanges();
                        return false;
                    }
                }
                myDataSet.AcceptChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string ReadSingleValue(string tableName, string columnName, string primaryKeyValue)
        {
            string primaryKey = myDataSet.Tables[tableName].PrimaryKey[0].ColumnName;
            for (int i = 0; i < myDataSet.Tables[tableName].Rows.Count; i++)
            {
                DataRow row = myDataSet.Tables[tableName].Rows[i];
                if (row[primaryKey].ToString() == primaryKeyValue)
                {
                    return row[columnName].ToString();
                }
            }
            return "!";
        }

        public DataRow ReadRow(string tableName, string primaryKeyValue)
        {
            string primaryKey = myDataSet.Tables[tableName].PrimaryKey[0].ColumnName;
            for (int i = 0; i < myDataSet.Tables[tableName].Rows.Count; i++)
            {
                DataRow row = myDataSet.Tables[tableName].Rows[i];
                if (row[primaryKey].ToString() == primaryKeyValue)
                {
                    return row;
                }
            }
            return null;
        }
        #endregion

        public DataTable getTable(string tableName)
        {
            return myDataSet.Tables[tableName];
        }

        public DataSet getDataSet()
        {
            return myDataSet;
        }

        public int findUntakenIndex(string tableName)
        {
            DataTable table = myDataSet.Tables[tableName];
            DataColumn primaryKeyColumn = table.PrimaryKey[0];
            int index = 1;
            foreach (DataRow row in table.Rows)
            {
                if (index == (int)row[primaryKeyColumn])
                {
                    ++index;
                }
                else
                {
                    return index;
                }
            }
            return index;
        }
    }
}
