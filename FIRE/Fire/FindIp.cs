using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Windows.Forms;

namespace FIRE.Fire
{
    class FindIp
    {
        private string FindIP;
        private string IpResult;
        private string Host;

        public FindIp()
        {
            
        }

        public string GetIpResult(string UserInput)
        {
            if (UserInput.Contains("host"))
            {

                Host = Dns.GetHostName();// gets host name
                IpResult = "\nHost: "+Host +"\nIp Address: "+Dns.GetHostByName(Host).AddressList[0].ToString();// obtains adress
            }
            else
            {
                Host = UserInput;
                IpResult = "\nHost: " + Host + " \nIp Address: " + Dns.GetHostByName(Host).AddressList[0].ToString();
            }
            return IpResult;
        }

    }
}
