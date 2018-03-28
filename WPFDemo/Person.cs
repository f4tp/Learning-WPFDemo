using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPFDemo
{
    class Person
    {
        private static List<Person> allPeopleList;
        public string name { get; set; }
        public int age { get; set; }
        public decimal heightInMeters { get; set; }
        public Person(string Name, int Age, decimal HeightInMeters)
        {
            this.name = Name;
            this.age = age;
            this.heightInMeters = HeightInMeters;
            AddPersonToTheList(this);
        }

        private static void AddPersonToTheList(Person personin)
        {
            if (allPeopleList == null)
            {
                allPeopleList = new List<Person>();
                allPeopleList.Add(personin);
            }
            else
            {
                allPeopleList.Add(personin);
            }


        }
        public static List<Person> GetAllPeople()
        {
            if (allPeopleList != null)
            {
                return allPeopleList;
            }
            else
            {
                allPeopleList = new List<Person>();
                return allPeopleList;
            }
        }

        public static void CycleThroughPersonsInList()
        {
            foreach (Person p in allPeopleList)
            {
                String forMSShow  = p.name + ", " + p.age.ToString() + ", " + p.heightInMeters.ToString();
                MessageBox.Show(forMSShow);
            }
        }
       

    }
}
        

