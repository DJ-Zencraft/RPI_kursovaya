﻿using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace RPI_kursovaya.utils 
{ 
public enum TableFieldTypes
{
    integer,
    nvarchar
}
public class TableField
{
    public string TableFieldValue { get; set; }
    public TableFieldTypes TableFieldType { get; set; }

}

    public class FieldForUpdate
    {
        public string FieldName { get; set; }
        public TableField FieldValue { get; set; }
    }

    public static class DBHelper
{

    public static List<string> SelectValuesFromTable(string tableName, int Id)
    {
        var result = new List<string>();


        var conn = new SqlConnection(Properties.Settings.Default.StorageBDConnectionString);

        var query = $"SELECT * FROM {tableName} WHERE {Constants.FieldsNames.Id} = {Id}";

        var cmd = new SqlCommand(query, conn);

        conn.Open();
        var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            result.Clear();

            for (var i = 0; i < reader.FieldCount; i++)
            {
                result.Add(reader[i].ToString());
            }

        }

        return result;
    }


    public static int InsertEntry(string tableName, Dictionary<string, TableField> fields)
    {
        var res = 0;


        var conn = new SqlConnection(Properties.Settings.Default.StorageBDConnectionString);


        var fieldsNames = string.Join(",", fields.Select(f => f.Key));

        var fieldsValues = string.Join(", ", fields.Select(f =>
        {

            if (f.Value.TableFieldType == TableFieldTypes.integer)
            {
                return f.Value.TableFieldValue;
            }
            return $"'{f.Value.TableFieldValue}'";
        }));

        var query = $"INSERT INTO {tableName} ({fieldsNames}) VALUES ({fieldsValues})";

        var cmd = new SqlCommand(query, conn);

        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();

        var selectLastItemQuery = $"SELECT TOP 1 Id FROM {tableName} ORDER BY Id DESC";

            var selectLastItemCmd = new SqlCommand(selectLastItemQuery, conn);

            conn.Open();
            var reader = selectLastItemCmd.ExecuteReader();

            while (reader.Read())
            {
                int.TryParse(reader[0].ToString(), out res );
            }
            conn.Close();

            return res;
    }

        public static void UpdateEntry(string tableName, int id, Dictionary<string, TableField> fields)
           => UpdateEntry(tableName, new FieldForUpdate
           {
               FieldName = Constants.FieldsNames.Id,
               FieldValue = new TableField
               {
                   TableFieldType = TableFieldTypes.integer,
                   TableFieldValue = id.ToString()
               }
           }, fields);
        public static void UpdateEntry(string tableName, FieldForUpdate fieldForUpdate, Dictionary<string, TableField> fields)
        {

            var conn = new SqlConnection(Properties.Settings.Default.StorageBDConnectionString);

            var updatingFieldsValue = string.Join(", ", fields.Select(f
                      => $"{f.Key}={GetFieldValueByType(f.Value)}"));
            var query
             = $"UPDATE {tableName} SET {updatingFieldsValue} WHERE {fieldForUpdate.FieldName}={GetFieldValueByType(fieldForUpdate.FieldValue)}";

            var cmd = new SqlCommand(query, conn);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public static void DeleteEntry(string tableName, FieldForUpdate fieldForUpdate)
        {

            var conn = new SqlConnection(Properties.Settings.Default.StorageBDConnectionString);
            var query = $"DELETE FROM {tableName} WHERE {fieldForUpdate.FieldName}={GetFieldValueByType(fieldForUpdate.FieldValue)}";
            var cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void DeleteEntry(string tableName, int id)
       => DeleteEntry(tableName, new FieldForUpdate
       {
           FieldName = Constants.FieldsNames.Id,
           FieldValue = new TableField
           {
               TableFieldType = TableFieldTypes.integer,
               TableFieldValue = id.ToString()
           }
       });

        public static void InsertPhoto(string tableName, string photoFieldName, int id, IEnumerable<byte> photo)
        {
            var query = $"UPDATE EmployeePersonalData SET {photoFieldName} = @Photo WHERE Id = @Id";
            var conn = new SqlConnection(Properties.Settings.Default.StorageBDConnectionString);
            conn.Open();
            using (var command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@Photo", photo);
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
            }
            conn.Close();
        }

        private static string GetFieldValueByType(TableField tableField)
          => tableField.TableFieldType == TableFieldTypes.integer
             ? tableField.TableFieldValue : $"'{tableField.TableFieldValue}'";
    }
}


