
using System;
using System.Collections.Generic;
using System.Text;


namespace Day2ErrorDebuging.model
{
    class Trainee
    {
       
        private string Name;
        private JobPath Path;
        //private int Path;
        private int Grade;

        public string name
        {
            set { Name = value; }
            get { return name; }
        }

        public JobPath path
        {
            set { Path = value; }
            get { return Path; }
        }

       // public int path
       // {
        //    set { Path = value; }
        //    get { return Path; }
       // }

        public int grade
        {
            set { Grade = value; }
            get { return Grade; }
        }
        //public void setgrade(int value)
        //{
        //    this.Grade = value;
        //}

       // public int getgrade()
        //{
       //     return Grade;
       // }
    }
}
