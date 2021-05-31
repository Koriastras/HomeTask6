using CsvHelper;
using Microsoft.VisualBasic.FileIO;
using System.Collections;
using System.IO;

namespace HomeTask6.Framework.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }



        //public User(string username, string password, string firstName, string lastName)
        //{
        //    Username = username;
        //    Password = password;
        //    FirstName = firstName;
        //    LastName = lastName;
        //}

        public static User User1()
        {
            TextFieldParser tfp = new TextFieldParser(@"C:\Users\yulii\Desktop\Test.csv");
            string x;
            tfp.TextFieldType = FieldType.Delimited;
            tfp.SetDelimiters(",");
            string[] fields;
            fields = tfp.ReadFields();
            //while (!tfp.EndOfData)
            //{
            //    fields = tfp.ReadFields();
            //    //foreach (string field in fields)
            //    //{
                    
            //    //}  
            //}
            return new User { Username = fields[0], Password = fields[1], FirstName = fields[2], LastName = fields[3] };




            //public static User User1()
            //{

            //   return new User { Username = "Arkanit", Password = "1234567890", FirstName = "Kori", LastName = "Astrasa" };
            //}

            //public static User User2()
            //{
            //    return new User { Username = "_Demo@", Password = "___3", FirstName = "_Artas#", LastName = "Menetil _" };
            //}
            //public static User User3()
            //{
            //    return new User { Username = "!12345%", Password = "* $ M 2", FirstName = "---", LastName = "   " };
            //}
        }
    }
}

