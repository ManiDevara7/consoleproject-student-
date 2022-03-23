using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    class Program
    {
        static void Main(string[] args)
        {
           
            SqlConnection con = new SqlConnection(" Data Source = localhost; Initial Catalog = studentDB; Integrated Security = True");
            SqlCommand cmd;
            //SqlDataAdapter adapt;

            
          
            int age;
            string name,input;
            try
            {

                Console.WriteLine("Enter your name: ");
                name = Console.ReadLine();

                Console.WriteLine("Enter your age: ");
                age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Do you want to save ? Press Y for Yes and N for No");
                input = Console.ReadLine();

                if (input.Equals("Y"))
                {
                    string Fname = name;
                    int _Age = age;


                    cmd = new SqlCommand("insert into Student(name,age) values(@name,@age)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("name", name);
                    cmd.Parameters.AddWithValue("age", age);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Console.WriteLine("Record Inserted Successfully");

                }
                else if (input.Equals("N"))
                {
                    Console.WriteLine("data is not saved");

                }
            }
            catch (Exception x)
            {

                Console.WriteLine($"Program encountered an error. Error is {x.Message}");
            }


           
          

        }

       
           
    }

}
