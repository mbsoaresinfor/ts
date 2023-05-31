using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS
{
    public class ClientesSitesRepositorio
    {
        private readonly string _CONNECTION_STRING = "server=192.168.0.19;user id=cyber;password=cyber#2016;persist security info=False;database=BPE_CENTRAL;Pooling=True;Connection Lifetime=160;Connection Timeout=50;";
        private SqlConnection _conn;
        private SqlDataReader _reader = null;

        public ClientesSitesRepositorio()
        {
            _conn = new SqlConnection(_CONNECTION_STRING);
            _conn.Open();
            Console.WriteLine("Conectado no banco de dados");
        }


        public ClientesSitesEntidade buscarClientesSitesPeloId(int id)
        {
            List<ClientesSitesEntidade> listaClientesSitesEntidade = new List<ClientesSitesEntidade>();
            SqlCommand cmd = new SqlCommand(
                $"SELECT [id],[nome],[cpf],[email] FROM[ECOMMERCE].[dbo].[clientes_site] where id = {id}", _conn);
            try
            {
                _reader = cmd.ExecuteReader();
                while (_reader.Read())
                {
                    ClientesSitesEntidade clientesSitesEntidade =
                        new ClientesSitesEntidade(_reader["nome"].ToString(),
                        _reader["cpf"].ToString(), _reader["email"].ToString());
                    listaClientesSitesEntidade.Add(clientesSitesEntidade);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error na listagem de Clientes " +
                    "Sites " + e.StackTrace);
            }
            finally
            {
                // Fecha o datareader
                if (_reader != null)
                {
                    _reader.Close();
                }
            }

            if( listaClientesSitesEntidade.Count == 0)
            {
                return null;
            }
            else
            {
                return listaClientesSitesEntidade[0];
            }
        }

        public List<ClientesSitesEntidade> listarClientesSites(int limite)
        {
            List<ClientesSitesEntidade> listaClientesSitesEntidade = new List<ClientesSitesEntidade>();
            SqlCommand cmd = new SqlCommand(
                $"SELECT TOP ({limite}) [id],[nome],[cpf],[email] FROM[ECOMMERCE].[dbo].[clientes_site]", _conn);
            try
            {
                _reader = cmd.ExecuteReader();
                while (_reader.Read())
                {   
                    ClientesSitesEntidade clientesSitesEntidade =
                        new ClientesSitesEntidade(_reader["nome"].ToString(), 
                        _reader["cpf"].ToString(), _reader["email"].ToString());
                    listaClientesSitesEntidade.Add(clientesSitesEntidade);
                }
            }catch(Exception e)
            {
                Console.WriteLine("Error na listagem de Clientes " +
                    "Sites " + e.StackTrace);
            }
            finally
            {
                // Fecha o datareader
                if (_reader != null)
                {
                    _reader.Close();
                }
            }

            return listaClientesSitesEntidade;
        }
    

    public void  deletarClientesSites(int id)
    {  
        using (SqlCommand deleteCmd = new SqlCommand($"DELETE FROM [ECOMMERCE].[dbo].[clientes_site] WHERE id = {id}", _conn))
        {   
           deleteCmd.ExecuteNonQuery();           
        }
    }
}

}
