using System;

namespace MongoDBDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MongoCRUD db = new MongoCRUD("Name");

            /* PersonModel person = new PersonModel
             {
                 FirstName = "Joe",
                 LastName = "Smith",
                 PrimaryAddress = new AddressModel
                 {
                     StreetAddress = "101 Oak Street",
                     City = "Scranton",
                     State = "PA",
                     ZipCode = "18512",
                 }
             };


             db.InsertRecord("Users", person);*/
            var recs = db.LoadRecords<PersonModel>("Users");

            foreach (var rec in recs)
            {
                Console.WriteLine($"{rec.FirstName} {rec.LastName}");
              
            }
            /*
                        var recs = db.LoadRecords<PersonModel>("Users");

                        foreach (var rec in recs)
                        {
                            Console.WriteLine($" {rec.Id}: {rec.FirstName} {rec.LastName}");
                            if (rec.PrimaryAddress != null)
                            {
                                Console.WriteLine($" {rec.PrimaryAddress.City}");

                            }
                        }
            */
            //var oneRec =  db.LoadRecordByID<PersonModel>("Users", new Guid("74e24eea-89d6-4c2f-bb20-a5c8fd5d5924"));
            //oneRec.DateOfBirth = new DateTime(1989, 10, 31, 0, 0, 0, DateTimeKind.Utc);
            //db.UpsertRecord("Users", oneRec.Id, oneRec);
            //Console.WriteLine(oneRec.FirstName);
            //db.DeleteRecord<PersonModel>("Users", oneRec.Id);


            Console.ReadLine();

        }
    }
}
