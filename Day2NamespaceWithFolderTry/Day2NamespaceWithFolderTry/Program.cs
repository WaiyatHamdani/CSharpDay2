using System;
using Day2NamespaceWithFolderTry.model;

namespace Day2NamespaceWithFolderTry
{
    class Program
    {
        static void Main(string[] args)
        {
            Trainee trainee = new Trainee();
            Trainer trainer = new Trainer();

            trainee.setName("Waiyat");
            trainee.path = "developer";
            trainer.setName("Karl");
            trainer.subject = "C sharp";

            Console.WriteLine("Trainee name: {0}", trainee.getName());
            Console.WriteLine("Trainee path: {0}",trainee.path);
            Console.WriteLine("traineer : {0} , subject : {1} ", trainer.getName(), trainer.subject);
        }
    }
}
