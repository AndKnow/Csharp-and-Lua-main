using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Params {
    class Program {

        static void Main() {
            Socket SocketClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPAddress IP = IPAddress.Parse("43.143.55.131");
            int Port = int.Parse("9190");
            IPEndPoint remoteEP = new IPEndPoint(IP, Port);
            SocketClient.Connect(remoteEP);

            byte[] message = new byte[1024];
            Console.WriteLine("Connection succeeded, please enter information");
            string ?mes = Console.ReadLine();
            if(mes != null)
                message = Encoding.ASCII.GetBytes(mes);  //将文本内容转换成字节发送
            else 
                 message = Encoding.ASCII.GetBytes("nothing");
            SocketClient.Send(message);    //调用Send()函数发送数据

            SocketClient.Receive(message);
            mes = Encoding.ASCII.GetString(message);
            Console.WriteLine("message from server : {0}", mes);
            SocketClient.Close();
        }
    }

}