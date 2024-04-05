using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Ficha2_Server3
{
    internal class Program
    {
        private static string DecifrarComCesar(string message, int shift)
        {
            char[] messageToArray = message.ToCharArray();

            for (int i = 0; i < messageToArray.Length; i++)
            {
                char letter = messageToArray[i];
                if (letter >= 'a' && letter <= 'z')
                {
                    letter = (char)(letter - shift);
                    if (letter < 'a')
                    {
                        letter = (char)(letter + 26);
                    }
                }
                else if (letter >= 'A' && letter <= 'Z')
                {
                    letter = (char)(letter - shift);
                    if (letter < 'A')
                    {
                        letter = (char)(letter + 26);
                    }
                }
                messageToArray[i] = letter;
            }
            return new string(messageToArray);
        }
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
                    string result = Encoding.UTF8.GetString(buffer, 0, bytesRead).ToString();

                    //ESCREVER PARA CONSOLA
                    Console.WriteLine("A decifrar mensagem ...");

                    // resposta para cliente
                    string deCipher = DecifrarComCesar(result, 5);

                    string response = "Mensagem decifrada: " + deCipher;

                    Console.WriteLine("A enviar: Mensagem decifrada é: " + response);

                    byte[] responseBytes = Encoding.UTF8.GetBytes(response);

                    networkStream.Write(responseBytes, 0, responseBytes.Length);

                    #endregion Cálculo
                    //ENVIAR RESPOSTA PARA CLIENTE
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
