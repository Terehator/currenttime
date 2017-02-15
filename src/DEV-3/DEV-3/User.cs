using System;
using System.Collections.Generic;

namespace DEV_3
{
    /// <summary>
    /// Class for user
    /// </summary>
    class User
    {
        private string name;
        private string surname;
        private string gender;
        private int age;
        public void setName(string name) { this.name = name; }
        public string getName() { return name; }
        public void setSurname(string surname) { this.surname = surname; }
        public string getSurname() { return surname; }
        public void setGender(string gender) { this.gender = gender; }
        public string getGender() { return gender; }
        public void setAge(int age) { this.age = age; }
        public int getAge() { return age; }
    }
}
