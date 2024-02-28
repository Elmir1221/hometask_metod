using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class User
    {
        public string name;
        public string surName;
        public int age;
        private string password;

        public User (string name, string surName, int age) 
        {
            this.age = age;
            this.surName = surName;
            this.name = name;
        }
    
         public string GetPassword()
         {
            return password;
         }
         public void SetPassword(string password)
         {
            this.password = password;   
        
         }
      

    }
    
   
}
