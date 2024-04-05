using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

//EXERCÍCIO B
namespace Ficha2_Server1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ESCREVER PARA CONSOLA
            Console.WriteLine("A iniciar o servidor...");

            //CRIAR TCP LISTENER
            TcpListener tcpListener = null;

            //CRIAR TCP CLIENT
            TcpClient tcpClient = null;

            //CRIAR NETWORKSTREAM PARA COMUNICAR COM SERVIDOR
            NetworkStream networkStream = null;

            //CICLO INFINITO PARA ESTAR SEMPRE À ESCUTA
            while (true)
            {
                //TRY/CHAT PARA TRATAMENTOS DOS ERROS   
                try
                {
                    //ESCREVER PARA CONSOLA
                    Console.WriteLine("A activar os portos de ligação...");

                    //CRIAR CONJUNTO IP+PORTO PARA SERVER   
                    IPEndPoint endPoint = new IPEndPoint(IPAddress.Loopback,
                        50001);

                    tcpListener.Start();

                    //ACEITAR CLIENTE
                    tcpClient = tcpListener.AcceptTcpClient();

                    //CRIAR NETWORKSTREAM PARA COMUNICAR COM SERVIDOR
                    networkStream = tcpClient.GetStream();

                    //CRIAR ARRAY DE BYTES PARA RECEBER MENSAGEM
                    int bytesRead = 0;

                    //CRIAR ARRAY DE BYTES PARA RECEBER MENSAGEM
                    byte[] buffer = new byte[tcpClient.ReceiveBufferSize];

                    //LER MENSAGEM
                    bytesRead = networkStream.Read(buffer, 0, buffer.Length);

                    //ESCREVER PARA CONSOLA
                    Console.WriteLine("Informacao Recebida: " + Encoding.UTF8.GetString(buffer, 0, bytesRead));

                    #region Cálculo
                    float result = ((int.Parse(Encoding.UTF8.GetString(buffer, 0, bytesRead)) + 2) * 3);

                    //ESCREVER PARA CONSOLA
                    Console.WriteLine("Resultado (x+2) * 3: " + result);

                    // resposta para cliente
                    byte[] response = Encoding.UTF8.GetBytes("O calculo" + " de (x+2) * 3 é: " + result);

                    #endregion Cálculo
                    //ENVIAR RESPOSTA PARA CLIENTE
                    networkStream.Write(response, 0, response.Length);
                }
                catch (Exception ex)
                {
                    //ESCREVER PARA CONSOLA
                    Console.WriteLine("Erro na comunicação com o cliente: " + ex.ToString());
                }
                finally
                {
                    //FECHAR NETWORKSTREAM
                    networkStream.Close();

                    //FECHAR TCP CLIENT
                    tcpClient.Close();

                    //FECHAR TCP LISTENER
                    tcpListener.Stop();
                }
            }
        }
    }
}
