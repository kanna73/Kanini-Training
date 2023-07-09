using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class College
    {
        private string collegename;
        string address;
        int pincode;

        public College(string collegename, string address, int pincode)
        {
            this.Pincode = pincode;
            this.collegename = collegename;
            this.address = address;
        }

        public string Collegename { get => collegename; set => collegename = value; }
        public string Address { get => address; set => address = value; }
        public int Pincode { get => pincode; set => pincode = value; }
    }
}