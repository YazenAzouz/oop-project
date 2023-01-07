using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class DD : NN, ISnore
    {
        public string mdPlay;
        public DD(string myName, string myAncestorName) : base(myName, myAncestorName)
        {
        }
        public void Snore()
        {
            mdPlay = "Assets/Snoring.mp4";   
        }
        public override void Socialize()
        {
            //optional Socialize();
        }
    }
}
