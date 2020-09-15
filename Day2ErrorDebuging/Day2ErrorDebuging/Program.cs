using System;
using System.Collections.Generic;
using Day2ErrorDebuging.model;
using Util;

namespace Day2ErrorDebuging
{
    enum JobPath
    {
        DEVELOPER =0,
        ITSM = 1,
        BUSINESS =2,
        ERROR=3
    }

    class Program
    {
        
        static void Main(string[] args)
        {
            AskingQuestion ao;
            Trainee newTrainee;
             var fdmt = new List<Trainee>();

            var adding = true;
            while (adding == true)
            {
                     
                    newTrainee = new Trainee();
                    ao = new AskingQuestion();
                    newTrainee.name = ao.asking("new trainee name: ");

                    //trying with enum
                    newTrainee.path =(JobPath)ao.askingint("0)Developer \n1)ITSM \n2)Business \nenter the following number ot hte choice : ");

                   // newTrainee.path = int.Parse(ao.asking("0)Developer \n1)ITSM \n2)Business \nenter the following number ot hte choice : "));
                    newTrainee.grade = ao.askingint("what is the grade: ");
                    fdmt.Add(newTrainee);
                   


                //Trainee newTrainee = new Trainee();
                //AskingQuestion ao = new AskingQuestion();
                //newTrainee.name = ao.asking("new trainee name: ");
                //newTrainee.path = ao.asking("developer or ITSM: ");

                //trying try parse
                //var result= int.TryParse(ao.asking(" what is the grade: "), out int value);

                //if (result == false)
                //{
                //Console.WriteLine(" you need to put the actual number 0-100 ");
                //}
                //else
                //{
                //  newTrainee.setgrade(value);
                //}

                Console.WriteLine("continue y/n");

                var cont = Console.ReadLine();
                if (cont == "n")
                {
                    adding = false;
                }

            }

            Console.WriteLine(fdmt.ToString());

            foreach (Trainee temp in fdmt)
            {
                Console.WriteLine("Name of trainee : {0}", temp.name);

               /* switch (temp.path)
                {
                    case JobPath.DEVELOPER:
                        Console.WriteLine(" you are Developer");
                        break;

                    case JobPath.ITSM:
                        Console.WriteLine(" you are ITSM");
                        break;

                    case JobPath.BUSINESS:
                        Console.WriteLine("you are business");
                        break;
                    case JobPath.ERROR:
                        Console.WriteLine("you need to put the right number 0-3");
                        break;
                    default:
                        Console.WriteLine("you need to put the right number 0-3");
                        break;
                }*/
                Console.WriteLine("grade of trainee : {0}", temp.grade);
            }


            //trying enum
            //foreach (Trainee temp in fdmtrainee)
            //{
            //  Console.WriteLine("Name of trainee : {0}" , temp.name);

            // switch (temp.path)
            // {
            //      case JobPath.DEVELOPER:
            //          Console.WriteLine(" you are Developer");
            //         break;

            //     case JobPath.ITSM:
            //         Console.WriteLine(" you are ITSM");
            //         break;

            //     case JobPath.BUSINESS:
            //        Console.WriteLine(" you are business");
            //         break;
            // }
            //   Console.WriteLine("grade of trainee : {0}", temp.grade);
        }



    }
}
    

