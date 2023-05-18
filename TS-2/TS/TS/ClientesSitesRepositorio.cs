using System;
using System.Collections.Generic;
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
    }
}
