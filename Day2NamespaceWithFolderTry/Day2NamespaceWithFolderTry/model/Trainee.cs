using System;
using System.Collections.Generic;
using System.Text;
using Day2NamespaceWithFolderTry.model;

namespace Day2NamespaceWithFolderTry.model
{
    class Trainee : Personel
    {
        private String Name;
        private String Path;
        public string getName()
        {
            return Name;
        }

        public void setName(string name)
        {
            this.Name = name;
        }

        public string path
        {
            set { Path = value; }
            get { return Path;  }
        }

    }
}
