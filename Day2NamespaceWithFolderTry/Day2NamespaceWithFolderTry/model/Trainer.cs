using System;
using System.Collections.Generic;
using System.Text;

namespace Day2NamespaceWithFolderTry.model
{
    class Trainer :Personel
    {
        private String Name;
        private String Subject;
        public string getName()
        {
            return Name;
        }

        public void setName(string name)
        {
            this.Name = name;
        }

        public string subject
        {
            set { Subject = value; }
            get { return Subject; }
        }
    }
}
