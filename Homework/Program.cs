using System;
using System.Collections;
using System.Collections.Generic;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            #region List
            //List<int> nums = new List<int>();

            //nums.Add(5);
            //nums.Add(55);
            //nums.Add(53);
            //nums.Add(9);

            //List<string> words = new List<string>();
            //words.Add("hello");
            //words.Add("by");
            //words.Add("Welcome");
            //foreach (var item in words)
            //{
            //    Console.WriteLine(item);
            //}




            //foreach (var item in nums)
            //{
            //    //Console.WriteLine(item);
            //}
            //for (int i = 0; i < nums.Count; i++)
            //{

            //}
            //if (nums.Count == 4)
            //{
            //    Console.WriteLine("List Count is {0} ", nums.Count);
            //}

            //List<Person> people = new List<Person>();

            //Person person = new Person();
            //person.Id = 123;
            //person.Name = "Seid";
            //person.Email = "Seidsn@Code.edu.az";

            //people.Add(person);


            //Person person1 = new Person
            //{
            //    Id = 124,
            //    Name = "Eli",
            //    Email = "Elisn@Code.edu.az"
            //};

            //people.Add(person1);


            //people.Add(new Person { Id = 128, Name = "Alim", Email = "aliksn@Code.edu.az" });
            //people.Add(new Person { Id = 125, Name = "Alim", Email = "Alimsn@Code.edu.az" });
            //people.Add(new Person { Id = 126, Name = "Elsen", Email = "Elsensn@Code.edu.az" });
            //people.Add(new Person { Id = 127, Name = "Arif", Email = "Arifsn@Code.edu.az" });


            //GetStudents(people);
            //GetNumbers(nums);

            //var result = GetPersonbyName(people, "Elsen");
            //Console.WriteLine(result.Id + "-" + result.Name + "-" + result.Email);

            //var result = GetPeoplebyName(people, "Alim");
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Id + "-" + item.Name + "-" + item.Email);
            //}
            #endregion

            #region Collection
            //Hashtable datas = new Hashtable();
            //datas.Add(1, "Seid");
            //datas.Add(2, "Nuraliyev");

            //foreach (DictionaryEntry item in datas)
            //{
            //    Console.WriteLine(item.Key + "-" + item.Value);
            //}

            //SortedList datas = new SortedList();

            //datas.Add(1, "Seid");
            //datas.Add(2, "Nuraliyev");
            //datas.Add(3, "Emil");
            //datas.Add(4, "Orxan");

            //foreach (DictionaryEntry item in datas)
            //{
            //    Console.WriteLine(item.Key + "-" + item.Value);
            //}

            //SortedList<int, string> datas = new SortedList<int, string>();
            //datas.Add(6, "Azer");
            //datas.Add(7, "Seid");

            //foreach (KeyValuePair<int, string> item in datas)
            //{
            //    Console.WriteLine(item.Key + "-" + item.Value);
            //}

            //ArrayList datas = new ArrayList();

            //datas.Add(3);
            //datas.Add("hello");
            //datas.Add(3.14);
            //datas.Add(-1);
            //foreach (var item in datas)
            //{
            //    Console.WriteLine(item);
            //}

            //HashSet<int> datas = new HashSet<int>();
            //datas.Add(1);
            //datas.Add(3);
            //datas.Add(4);
            //datas.Add(3);

            //foreach (var item in datas)
            //{
            //    Console.WriteLine(item);
            //}

            //Stack<int> datas = new Stack<int>();
            //datas.Push(23);
            //datas.Push(24);
            //datas.Push(27);

            //foreach (var item in datas)
            //{
            //    Console.WriteLine(item);
            //}

            //Queue<string> datas1 = new Queue<string>();

            //datas1.Enqueue("hello");
            //datas1.Enqueue("Welcome");
            //datas1.Enqueue("Bye");

            //foreach (var item in datas1)
            //{
            //    Console.WriteLine(item);
            //}

            //Dictionary<string, string> datas = new Dictionary<string, string>();

            //datas.Add("Admin1", "Orxan");
            //datas.Add("Admin2", "Emil");
            //datas.Add("Member", "Mirsamir");
            //datas.Add("SuperAdmin", "Cavid");

            ////foreach (KeyValuePair<string,string> item in datas)
            ////{
            ////    Console.WriteLine($"Role: {item.Key}    Name: {item.Value}");
            ////}

            //foreach (KeyValuePair<string, string> item in datas)
            //{
            //    if (item.Key == "Admin2")
            //    {
            //        Console.WriteLine($"Role: {item.Key}    Name: {item.Value}");
            //        break;
            //    }
            //}
            #endregion

        }

        #region List
        //public static void GetStudents(List<Person> students)
        //{
        //    foreach (var stu in students)
        //    {
        //        Console.WriteLine("students: Id - {0},Name - {1},Email - {2}" ,stu.Id,stu.Name,stu.Email);
        //    }
        //}
        //public static void GetNumbers(List<int> numbers)
        //{
        //    foreach (var item in numbers)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

        //public static Person GetPersonbyName(List<Person> people,string name)
        //{
        //    var person =people.Find(m=> m.Name == name);
        //     return person;   
        //}
        //public static List<Person> GetPeoplebyName(List<Person> people, string name)
        //{
        //    var person = people.FindAll(m => m.Name == name);
        //    return person;
        //}
        #endregion
    }

    #region List
    //public class Person
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public string Email { get; set; }
    //}
    #endregion

}
