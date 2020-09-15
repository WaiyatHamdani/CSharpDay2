using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Day2ErrorDebuging.model
{
    class Trainer
    {
        private string Name;
        private string Subject;

        public string name
        {
            set { Name = value; }
            get { return name; }
        }

        public string subject
        {

            set { Subject = value; }
            get { return Subject; }
        }

    }
}
