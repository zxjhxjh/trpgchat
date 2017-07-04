using System;
using System.Collections.Generic;
using Lidgren.Network;
using NATUPNPLib;
using System.Net;
using System.Net.Sockets;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPGChat.Connect
{
    
    using Model;
    public class Server
    {
        NetServer s_server;
        NetPeerConfiguration s_npcfg;
        
        IPAddress host;
        string name;
        public string console;
        List<Player> clientConnect;
        List<ChatRoom> rooms;
        bool isUPnP;
        int eport;
        int iport;
        ProtocolType type;
        #region Server
        public Server(string name, int port=1001, ProtocolType protocol = ProtocolType.Udp)
        {
            Server_Init(name,port,protocol);
        }
        public Server(int port,ProtocolType protocol=ProtocolType.Udp)
        {
            Server_Init(name,port,protocol);
        }
        public void AddClient(NetConnection nconnection)
        {
            s_server.Connections.Add(nconnection);
        }
        public void Start()
        {
            s_server.Start();
            console += string.Format("服务端启动\n");
        }
        public void Server_Init(string name,int iport=1001,ProtocolType protocol=ProtocolType.Udp, int eport = 1001)
        {
            this.name = name;
            this.s_npcfg = new NetPeerConfiguration(name);
            s_npcfg.LocalAddress = IPAddress.Any;
            s_npcfg.Port = iport;
            s_server = new NetServer(s_npcfg);
            if(SetUPnP(eport, iport, "trpgChat", protocol))
            {
                console+=string.Format("UPnP设置成功，内部端口：{0}，外部端口：{1} \n",iport,eport);
            }
            else
            {
                console += string.Format("未发现路由器 \n");
            }
            this.clientConnect = new List<Player>();
            this.rooms = new List<ChatRoom>();
        }
        public void Exit()
        {
            if (isUPnP == true)
            {
                CloseUPnP();
                isUPnP = false;
            }
        }
        public bool SetUPnP(int eport,int iport,string description,ProtocolType type)
        {
            IPAddress ip = IPAddress.Any;
            string host = Dns.GetHostName();
            IPAddress ipv4 = Dns.GetHostEntry(host).AddressList.Where(i => i.AddressFamily == AddressFamily.InterNetwork).FirstOrDefault();
            console += string.Format("主机名：{0}，本机IP：{1}\n",host,ipv4);
            var upnp = new UPnPNAT();
            var mapping = upnp.StaticPortMappingCollection;
            if (mapping == null)
            {
                return false;
            }
            mapping.Add(eport, type.ToString().ToUpper(), iport, ipv4.ToString(), true, description);
            return true;
        }
        public void CloseUPnP()
        {
            var upnp = new UPnPNAT();
            var mapping = upnp.StaticPortMappingCollection;
            if (mapping != null)
            {
                mapping.Remove(eport, type.ToString().ToUpper());
            }
        }
        #endregion

        #region Message
        public void SendMessage()
        {

        }
        public void Command()
        {

        }
        public void GetMessage()
        {

        }
        #endregion
    }
}
