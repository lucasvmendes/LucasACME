using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Data;

namespace Lucas
{
    class Database
    {
        public SQLiteConnection myConnection;
        public Database()
        {
            myConnection = new SQLiteConnection("Data Source=acme.sqlite");
            if (!File.Exists("./acme.sqlite"))
            {
                SQLiteConnection.CreateFile("acme.sqlite");
                CriarTabelaSQLite();
            }

        }
        public void OpenConnection()
        {
            if (myConnection.State != System.Data.ConnectionState.Open)
            {
                myConnection.Open();
            }
        }
        public void CloseConnection()
        {
            if (myConnection.State != System.Data.ConnectionState.Closed)
            {
                myConnection.Close();
            }
        }
        public void CriarTabelaSQLite()
        {
            try
            {
                string query = "CREATE TABLE TB_VOO(ID_VOO integer PRIMARY KEY AUTOINCREMENT, DATA_VOO datetime, CUSTO numeric(10,2), DISTANCIA int, CAPTURA char(1),NIVEL_DOR int)";
                SQLiteCommand myCommand = new SQLiteCommand(query, myConnection);
                OpenConnection();
                myCommand.ExecuteNonQuery();
                CloseConnection();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataTable BuscaDados()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT ID_VOO, DATA_VOO, CAPTURA, NIVEL_DOR FROM TB_VOO";
                OpenConnection();
                da = new SQLiteDataAdapter(query, myConnection);
                da.Fill(dt);
                CloseConnection();
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void AdicionarDados(Dados dados)
        {
            try
            {
                string query = "INSERT INTO TB_VOO (data_voo, custo, distancia, captura, nivel_dor) VALUES(@data_voo, @custo, @distancia, char (@captura), @nivel_dor)";
                SQLiteCommand myCommand = new SQLiteCommand(query, myConnection);
                OpenConnection();
                myCommand.Parameters.AddWithValue("@data_voo", dados.DATA_VOO);
                myCommand.Parameters.AddWithValue("@custo", dados.CUSTO);
                myCommand.Parameters.AddWithValue("@distancia", dados.DISTANCIA);
                myCommand.Parameters.AddWithValue("@captura", dados.CAPTURA);
                myCommand.Parameters.AddWithValue("@nivel_dor", dados.NIVEL_DOR);
                myCommand.ExecuteNonQuery();
                CloseConnection();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void ModificarDados(Dados dados, int indiceDoVoo)
        {
            try
            {
                string query = "UPDATE TB_VOO SET data_voo = @data_voo, custo = @custo, distancia = @distancia, captura = char (@captura), nivel_dor = @nivel_dor WHERE ID_VOO = @id_voo";
                SQLiteCommand myCommand = new SQLiteCommand(query, myConnection);
                OpenConnection();
                myCommand.Parameters.AddWithValue("@data_voo", dados.DATA_VOO);
                myCommand.Parameters.AddWithValue("@custo", dados.CUSTO);
                myCommand.Parameters.AddWithValue("@distancia", dados.DISTANCIA);
                myCommand.Parameters.AddWithValue("@captura", dados.CAPTURA);
                myCommand.Parameters.AddWithValue("@nivel_dor", dados.NIVEL_DOR);
                myCommand.Parameters.AddWithValue("@id_voo", indiceDoVoo);
                myCommand.ExecuteNonQuery();
                CloseConnection();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataTable BuscaDadosPorID(int indiceDoVoo)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                string query = $"SELECT * FROM TB_VOO WHERE ID_VOO = {indiceDoVoo}";
                OpenConnection();
                da = new SQLiteDataAdapter(query, myConnection);
                da.Fill(dt);
                CloseConnection();
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void ExcluirDadosPorID(int indiceDoVoo)
        {
            try
            {
                string query = "DELETE FROM TB_VOO WHERE ID_VOO = @id_voo";
                SQLiteCommand myCommand = new SQLiteCommand(query, myConnection);
                OpenConnection();
                myCommand.Parameters.AddWithValue("@id_voo", indiceDoVoo);
                myCommand.ExecuteNonQuery();
                CloseConnection();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
