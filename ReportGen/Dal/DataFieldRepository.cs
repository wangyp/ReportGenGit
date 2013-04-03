using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using ReportGen.Model;

namespace ReportGen.Dal
{
    public class DataFieldRepository : IDataFieldRepository
    {
        private SQLiteConnection _connection = null;
        private string _connectString = null;

        private const string GET_ALL_SQL = "select * from main";
        private const string GETBYNAME_SQL = "select * from main where Name=@Name";

        private const string INSERT_SQL = "INSERT INTO main( {0} ) values( {1} )"; 

        private const string UPDATE_SQL = "update main set {0} where Name=@Name";

        private const string DELETE_SQL = "delete from main where Name=@Name"; 

        public static string GetInsertSQL()
        {
            string column = string.Join(" , ",typeof(ReportData).GetProperties().Select(o=>o.Name).Where(o=>o != "Id"));
            string value = string.Join(" , ",typeof (ReportData).GetProperties().Where(o => o.Name != "Id").Select(o => "@" + o.Name));
            return string.Format(INSERT_SQL, column, value);
        }

        public static string GetUpdateSQL()
        {
            string value = string.Join(" , ",typeof (ReportData).GetProperties().Where(o => o.Name != "Id").Select(o =>o.Name + " = @" + o.Name));
            return string.Format(UPDATE_SQL, value);
        }

        public ReportData GetByName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ApplicationException("ReportData.Name cannot be null");
            }
            var reader = SqLiteDbHelper.Instance.ExecuteReader(GETBYNAME_SQL, new[]
                                        {
                                            new SQLiteParameter("@Name",name), 
                                        });
            
            try
            {
                if (!reader.HasRows)
                {
                    return null;
                }
                reader.Read();
                return GetCurrentModel(reader);
            }
            finally
            {
                    reader.Close();
            }
        }

        public IList<ReportData> GetAll()
        {
            var all = new List<ReportData>();
            var reader = SqLiteDbHelper.Instance.ExecuteReader(GET_ALL_SQL, null);
            while (reader.Read())
            {
                var model = GetCurrentModel(reader);
                all.Add(model);
            }
            reader.Close();
            return all;
        }

        public void Save(ReportData reportData)
        {
            SQLiteParameter[] parameters = ModelToParameters(reportData);
            string insertSql = GetInsertSQL();
            Debug.WriteLine(insertSql);
            SqLiteDbHelper.Instance.ExecuteNonQuery(insertSql, parameters);
        }

        public void Update(ReportData reportData)
        {
            if (reportData == null)
            {
                throw new NullReferenceException("reportData is null ");
            }
            SQLiteParameter[] parameters = ModelToParameters(reportData);
            string updateSql = GetUpdateSQL();
            Debug.WriteLine(updateSql);
            SqLiteDbHelper.Instance.ExecuteNonQuery(updateSql, parameters.ToArray());
        }

        public void Delete(string name)
        {
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            parameters.Add(new SQLiteParameter("@Name", name));
            SqLiteDbHelper.Instance.ExecuteNonQuery(DELETE_SQL, parameters.ToArray());
        }


        private ReportData GetCurrentModel(IDataReader reader)
        {
            ReportData model = new ReportData();

            foreach (var prop in typeof(ReportData).GetProperties())
            {
                try
                {
                    if (!(reader[prop.Name] is DBNull))
                    {
                        prop.SetValue(model, reader[prop.Name] , null);
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Error: " + ex.Message);
                    continue;
                }
            }
            return model;
        }

        /// <summary>
        /// Convert report data to sqLite parameter
        /// </summary>
        /// <param name="reportData"></param>
        /// <returns></returns>
        private SQLiteParameter[] ModelToParameters(ReportData reportData)
        {
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            if (reportData.Id != 0)
            {
                parameters.Add(new SQLiteParameter("@Id", reportData.Id));
            }
            typeof (ReportData).GetProperties().Where(o => o.Name != "Id").ToList().ForEach(
                o => parameters.Add(ToParameter(reportData, o.Name)));
            return parameters.ToArray();
        }

        private static SQLiteParameter ToParameter(ReportData reportData, string propertyName)
        {
            object v = reportData.GetType().GetProperty(propertyName).GetValue(reportData, null);
            return new SQLiteParameter("@" + propertyName, v);
        }
    }
}
