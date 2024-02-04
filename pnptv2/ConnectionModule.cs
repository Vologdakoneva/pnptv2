using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.Odbc;
using System.Data;
using System.Data.SqlClient;

namespace pnptv
{
    public class  ConnectionModule 
    {
        /// <summary>
        ///  Должны быть заполнены до создания коннекта
        /// </summary>
        public String NameProvider = "";
        public string username = "";
        public string password = "";
        public bool needRelogin = true;
        public string[] prm;
        //connectionstring 

        public enum SQLTYPEPROVIDER { NONE, OLEDB, MSSQL, FIREBIRD, ODBC, LCPI};


        public bool _logined;
        public  bool Logined
        {
            get
            {
                
                if (!_logined)
                {
                    var loginForm = new LoginData();
                    loginForm.ConnectionModules = new ConnectionModule();
                    loginForm.prm = prm;
                    loginForm.Login_Load(null,null);
                    if (prm != null && prm.Contains("/SHOW") || loginForm.ShowDialog() != System.Windows.Forms.DialogResult.Cancel ) {
                        this.connection();
                        _connectionstring = loginForm.ConnectionModules.connectionstring;
                        Logined = loginForm.ConnectionModules._logined;
                        if (prm != null && prm.Contains("/SHOW"))
                        {
                            needRelogin = !loginForm.ConnectionModules._logined;
                        }
                        else
                        {
                            needRelogin = loginForm.DialogResult != System.Windows.Forms.DialogResult.Cancel && !loginForm.ConnectionModules._logined;
                        }

                        loginForm.Dispose();
                        if (_logined) { 
                         if (TypeProvider == SQLTYPEPROVIDER.OLEDB & _connectionOleDb != null && this._connectionOleDb.State == ConnectionState.Closed) { this._connectionOleDb.Open();
                           
                            }
                         if (TypeProvider == SQLTYPEPROVIDER.MSSQL & _connectionSQL != null && this._connectionSQL.State== ConnectionState.Closed) { this._connectionSQL.Open(); }
                    }
                    }
                    else { _logined = false;
                           needRelogin = loginForm.DialogResult != System.Windows.Forms.DialogResult.Cancel && !loginForm.ConnectionModules._logined;
                    }
                }
                return _logined;
            }
            set { _logined = value; }
        }

        private string _connectionstring = "";


        public lcpi.data.oledb.OleDbConnection _connectionOleDb = null;
        public SqlConnection _connectionSQL = null;
        public OdbcConnection _connectionODBC = null;

        public SQLTYPEPROVIDER TypeProvider = SQLTYPEPROVIDER.NONE;

        public string connectionstring { get
            { return _connectionstring; }
            set {
                if (value != null) { 
                _connectionstring = value;
                _connectionstring = _connectionstring.ToUpper();
                if (connectionstring.Contains("LCPI") || NameProvider.ToUpper().Contains("FIREBIRD"))
                {
                    if (username.ToUpper() == "АДМИНИСТРАТОР") { username = "SYSDBA"; }
                    username = toIbString(username);
                }

                var builder = new DbConnectionStringBuilder();
                builder.ConnectionString = connectionstring;
                if (builder.ContainsKey("USER ID"))
                {
                    builder["USER ID"] = username;
                };
                if (builder.ContainsKey("PASSWORD"))
                {
                    builder["PASSWORD"] = password;
                };

                _connectionstring = builder.ConnectionString;

                    if (TypeProvider == SQLTYPEPROVIDER.OLEDB & _connectionOleDb != null) { this._connectionOleDb.ConnectionString = _connectionstring;
                        
                    }
                if (TypeProvider == SQLTYPEPROVIDER.MSSQL &_connectionSQL != null) { this._connectionSQL.ConnectionString = _connectionstring; }
                }
            }

        }


        public void connection()
        {


            String Classname = "";
            if (NameProvider.Contains("OleDb"))
            {
                if (_connectionOleDb == null) { 
                    _connectionOleDb =  new lcpi.data.oledb.OleDbConnection();
                    _connectionOleDb.ConnectionString = _connectionstring;
                    Classname = _connectionOleDb.GetType().Name;
                }
                TypeProvider = SQLTYPEPROVIDER.OLEDB;
            }
                    if (NameProvider.Contains("SqlClient"))
                    {
                        _connectionSQL = new System.Data.SqlClient.SqlConnection();
                        _connectionSQL.ConnectionString = _connectionstring;
                        TypeProvider = SQLTYPEPROVIDER.MSSQL;
                        Classname = _connectionSQL.GetType().Name;
                   }
            if (NameProvider.Contains("ODBC"))
                    {
                        _connectionODBC = new System.Data.Odbc.OdbcConnection();
                _connectionODBC.ConnectionString = _connectionstring;
                TypeProvider = SQLTYPEPROVIDER.ODBC;
                Classname = _connectionODBC.GetType().Name;
            }

        }

        public string toIbString(string s)
        {
            int i, j;
            string Result = "";
            const string Eng = @"QWERTYUIOP{}"":LKJHGFDSAZXCVBNM<>?";
            const string Rus = @"ЙЦУКЕНГШЩЗХЪЭЖДЛОРПАВЫФЯЧСМИТЬБЮ,";

            Result = "";
            for (i = 0; i < s.Length; i++)
            {
                s = s.ToUpper();
                j = Rus.IndexOf(s[i]);
                if (j >= 0)
                {
                    Result = Result + Eng[j];
                }
                else { Result = Result + s[i]; }
            }
            return Result;
        }

        public string IbToString(String S)
        {
            int i, j;
            const string Eng = @"QWERTYUIOP{}"":LKJHGFDSAZXCVBNM<>?";
            const string Rus = @"ЙЦУКЕНГШЩЗХЪЭЖДЛОРПАВЫФЯЧСМИТЬБЮ,";
            string Result = "";
            for (i = 0; i < S.Length; i++)
            {
                S = S.ToUpper();
                j = Eng.IndexOf(S[i]);
                if (j >= 0)
                {
                    Result = Result + Rus[j];
                }
                else { Result = Result + S[i]; }
            }
            return Result;
        }


    }
}
