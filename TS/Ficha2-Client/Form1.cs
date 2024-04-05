using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ficha2_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //CRIAR MÉTODO
        private string EnviarDados(string message, string ipAddress,
            string ipPorto) { 
            
            //CRIAR UM CLIENTE TCP
            TcpClient tcpClient = null;

            //CRIAR NETWORKSTREAM PARA PODER COMUNICAR COM O SERVIDOR
            /*A classe NetworkStream fornece o fluxo de dados, que se encontram por baixo,
             * para aceder à rede. Fonte: https://bit.ly/3tQq1Wn */
            NetworkStream netStream = null;

            //TRY/CATCH PARA FAZER O TRATAMENTO DE ERROS
            /*A declaração Try/catch consiste num bloco try e numa ou mais cláusulas 
             * catch para tratar excepções (evitar que os softwares “crashem”)*/
            try
            {
                //CRIAR CONJUNTO IP+PORTO DO SERVIDOR REMOTO
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(ipAddress),
                    int.Parse(ipPorto));

                //INSTANCIAR O CLIENTE TCP
                tcpClient = new TcpClient();

                //EFECTUAR A LIGAÇÃO AO SERVIDOR
                tcpClient.Connect(endPoint);

                //OBTER A LIGAÇÃO DO SERVIDOR
                netStream = tcpClient.GetStream();

                //BYTES LIDOS
                int bytesRead = 0;

                //PREPARAR MENSAGEM A ENVIAR
                byte[] msgBytes = Encoding.UTF8.GetBytes(message);

                //ENVIAR A MENSAGEM PELA LIGAÇÃO
                netStream.Write(msgBytes, 0, msgBytes.Length);

                //RECEBER A CONFIRMAÇÃO DO SERVIDOR
                byte[] ack = new byte[tcpClient.ReceiveBufferSize];

                //RECEBER A RESPOSTA DO SERVIDOR
                //bytesRead = netStream.Read(ack, 0, ack.Length);

                //EXTRAIR A MENSAGEM DE RESPOSTARead);
                string response = Encoding.UTF8.GetString(ack, 0, ack.Length);

                //CASO A RESPOSTA ESTEJA VAZIA
                if (response == "") {
                    return "Erro!";
                }

                //DEVOLVE A RESPOSTA RECEBIDA
                return response;
            }
            catch (Exception ex) {
                //SE ALGO DE ESTRANHO SE PASSAR
                return "Erro!";
            }

            /*A declaração Try/finally consiste num bloco try e numa cláusula
             * finally para limpar quaisquer recursos alocados no bloco try.
             * Pode-se inclusivamente executar código, mesmo que ocorram
             * excepções.*/
            finally {
                //FECHAR LIGAÇÃO SE ABERTA
                if (netStream != null) { 
                    netStream.Close();
                }

                //FECHAR COMUNICAÇÃO SE AINDA ESTIVER ABERTA
                if (tcpClient != null){
                    tcpClient.Close();
                }
            }
        }

        //CLICAR NO BOTÃO ENVIAR
        private void buttonServer01_Click(object sender, EventArgs e)
        {
            string response = EnviarDados(textBoxServer01.Text,
                textBoxIPServer01.Text, textBoxPortoServer01.Text); //.ToString(); será redundante
            textBoxConsola.AppendText("Resposta do Server 01: "+ response
                + Environment.NewLine);
        }

        private void buttonServer02_Click(object sender, EventArgs e)
        {
            string response = EnviarDados(textBoxServer02.Text,
                textBoxIPServer02.Text, textBoxPortoServer02.Text); //.ToString(); será redundante
            textBoxConsola.AppendText("Resposta do Server 02: " + response
                + Environment.NewLine);
        }

        private void buttonServer03_Click(object sender, EventArgs e)
        {
            string response = EnviarDados(textBoxServer03.Text,
                textBoxIPServer03.Text, textBoxPortoServer03.Text); //.ToString(); será redundante
            textBoxConsola.AppendText("Resposta do Server 03: " + response
                + Environment.NewLine);
        }
    }
}
