using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace SerializationTask
{
    [Serializable]
    class Person2 : ISerializable


    {
        string name;
        [NonSerialized]
        int age;
        int dateOfBirth;

        public Person2(string name, int age, int dateOfBirth)
        {
            this.name = name;
            this.age = age;
            this.dateOfBirth = dateOfBirth;
        }

        public Person2()
        {

        }

        public override string ToString()
        {
            return $"Name: {name}\tAge: {age}";
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
        }

    }
}
