using System;
using System.Linq;

namespace Person
{
    public class Person
    {
        public string name;
        public string id;

        public Person(string name, string id)
        {
            this.name= name;
            this.id= id;
        }


        public void IntroduceYourself()
        {
            Console.WriteLine(

            $"Soy {this.name} y mi cedula es {this.id}");
        }

        public void isValid(){
            if ((IdUtils.IdIsValid(this.id)) && (IdUtils.NameIsValid(this.name))){
                this.IntroduceYourself();
            }
            else {
                Console.WriteLine("Error");
            }
        }
    }
}
