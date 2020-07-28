using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CW8
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = @"task.txt";
                List<Person> persons = new List<Person>
                {
                    new Staff("Yurii", "300"),
                    new Staff("Sasha", "200"),
                    new Staff("Dasha", "1000"),
                    new Staff("Masha", "550"),
                    new Developer("Masha", "550", "JS"),
                    new Teacher("Masha", "550", "Liheratura")
                };


                foreach (var person in persons)
                {
                    person.Print();
                }

                Console.WriteLine("Please enter name: ");
                string name = Console.ReadLine();

                foreach (var person in persons)
                {
                    if (name == person.Name)
                    {
                        person.Print();
                    }
                    else
                    {
                        Console.WriteLine("Name not found!!");
                    }
                }


                var newList = persons.OrderBy(x => x.Name).ToList();
                foreach (var item in newList)
                {

                    using (StreamWriter sw = new StreamWriter(path: path, append: false, encoding: System.Text.Encoding.Default))
                    {
                        sw.WriteLine(item.Name);
                    }
                }

                List<Staff> list = new List<Staff>();

                foreach (var person1 in persons)
                {
                    var person = (Staff) person1;
                    if (person.GetType() == typeof(Teacher) || person.GetType() == typeof(Developer))
                    {
                        list.Add(person);
                    }
                }

                var newListList = list.OrderBy(x => x.Salary).ToList();
                foreach (var i in newListList)
                {
                    i.Print();   
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e);
            }
            catch (IOException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
