using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedClient.ServiceReference1;

namespace MedClient
{
    class Client
    {
        //JsonFxAdapter<Connector>.LoadJson()

        private static Client _client = null;
        public static Client ClientInstance
        {
            get
            {
                if (_client == null) _client = new Client();
                return _client;
            }
        }


        private MedWCFClient _medClient = null;
        public MedWCFClient MedClient
        {
            get
            {
                if (_medClient == null) _medClient = new MedWCFClient();
                return _medClient;
            }
        }


    }
}
