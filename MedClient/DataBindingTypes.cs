using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MedClient.ServiceReference1;
using System.ServiceModel;
using System.Collections.ObjectModel;

namespace MedClient
{
        public class Pacient
        {
            public Pacient()
            {

            }

            public Pacient(peoples people, string hospitalName, string decease, string doctorFIO)
            {
                this.id = people.id;
                this.hospitalName = hospitalName;
                this.fullname = people.name + " " + people.sourname;
                this.decease = decease;
                this.doctorFIO = doctorFIO;
            }

            public string hospitalName { get; set; }

            public int id { get; set; }

            public string fullname { get; set; }

            public string decease { get; set; }

            public string doctorFIO { get; set; }


            public override string ToString()
            {
                return fullname;
            }
        }

    class Hospital
    {
        public string hospital;
        public string doctor;
    }
}
