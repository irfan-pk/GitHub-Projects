using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Globalization;

namespace WholeSaleApplication
{
    [Serializable]
    public class DatabaseParameters
    {
        public String ProgName;
        public String HostName;
        public String UserName;
        public String UserPassword;
        public String DatabaseName;
    
        public static void ReadWriteDatabaseParameters(String Option)
        {
            DatabaseParameters obj = new DatabaseParameters();
            String Path = Directory.GetCurrentDirectory();
            IFormatter formatter = new BinaryFormatter();

            if (Option == "FW")
            {
                obj.ProgName = "C Sharp .Net 2019";
                obj.HostName = GlobalVariableClass.gblHostName;
                obj.DatabaseName = GlobalVariableClass.gblDatabaseName;
                obj.UserName = GlobalVariableClass.gblUserName;
                obj.UserPassword = GlobalVariableClass.gblPassword;
                Stream stream = new FileStream(Path + "\\DotNetLib.dll", FileMode.Create, FileAccess.Write);
                formatter.Serialize(stream, obj);
                stream.Close();
            }

            if(Option == "FR")
            {
                Stream stream = new FileStream(Path + "\\DotNetLib.dll", FileMode.Open, FileAccess.Read);
                DatabaseParameters objnew = (DatabaseParameters)formatter.Deserialize(stream);

                GlobalVariableClass.gblProgName = objnew.ProgName;
                GlobalVariableClass.gblHostName = objnew.HostName;
                GlobalVariableClass.gblDatabaseName = objnew.DatabaseName;
                GlobalVariableClass.gblUserName = objnew.UserName;
                GlobalVariableClass.gblPassword = objnew.UserPassword;
            }
        }

    }
}
