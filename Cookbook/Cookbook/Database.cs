using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Security.Principal;
using System.IO;
using System.Security.AccessControl;

namespace Cookbook
{
    class Database
    {
        public bool CreateDatabase(SqlConnection connection, string txtDatabase)
        {
            String CreateDatabase;
            string appPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            GrantAccess(appPath); //Need to assign the permission for current application to allow create database on server (if you are in domain).
            bool IsExits = CheckDatabaseExists(connection, txtDatabase); //Check database exists in sql server.
            if (!IsExits)
            {
                CreateDatabase = "CREATE DATABASE " + txtDatabase + " ; ";
                SqlCommand command = new SqlCommand(CreateDatabase, connection);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (System.Exception)
                {
                    MessageBox.Show("Please Check Server and Database name.Server and Database name are incorrect .", "text",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
                return true;
            }
            return false;
        }

        public static bool GrantAccess(string fullPath)
        {
            DirectoryInfo info = new DirectoryInfo(fullPath);
            WindowsIdentity self = System.Security.Principal.WindowsIdentity.GetCurrent();
            DirectorySecurity ds = info.GetAccessControl();
            ds.AddAccessRule(new FileSystemAccessRule(self.Name,
            FileSystemRights.FullControl,
            InheritanceFlags.ObjectInherit |
            InheritanceFlags.ContainerInherit,
            PropagationFlags.None,
            AccessControlType.Allow));
            info.SetAccessControl(ds);
            return true;
        }

        public static bool CheckDatabaseExists(SqlConnection tmpConn, string databaseName)
        {
            string sqlCreateDBQuery;
            bool result = false;

            try
            {
                sqlCreateDBQuery = string.Format("SELECT database_id FROM sys.databases WHERE Name = '{0}'", databaseName);
                using (SqlCommand sqlCmd = new SqlCommand(sqlCreateDBQuery, tmpConn))
                {
                    tmpConn.Open();
                    object resultObj = sqlCmd.ExecuteScalar();
                    int databaseID = 0;
                    if (resultObj != null)
                    {
                        int.TryParse(resultObj.ToString(), out databaseID);
                    }
                    tmpConn.Close();
                    result = (databaseID > 0);
                }
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }
    }
}
