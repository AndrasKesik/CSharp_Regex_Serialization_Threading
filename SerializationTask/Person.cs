using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace SerializationTask
{
    [Serializable]
    class Person
    {
        string name;
        int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Person()
        {
            
        }

        public override string ToString()
        {
            return $"Name: {name}\tAge: {age}";
        }
    }
}
