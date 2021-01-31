using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment
{
   public class Program
    {
        
        public double add(double num1, double num2, double num3,double num4)
        {
            return num1 + num2 + num3+ num4;
        }
        public double sub(double num1, double num2, double num3, double num4)
        {
            return num1 - num2 - num3- num4;
        }
        public double multi(double num1, double num2, double num3, double num4)
        {
            return num1 * num2 * num3* num4;
        }
        public double divi(double num1, double num2, double num3, double num4)
        {
            return num1 / num2 / num3/ num4;
        }
        public string writeAsReverse(String str)
        {
            String reverse = "";

            for (int i = str.Length; i > 0; i--)
            {
                reverse = reverse + str[i - 1];
            }

            return reverse;
        }

        public int fac(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            return number * (fac(number - 1));
        }
        static void Main(string[] args)
        {
        }
    }
    public class Academician
    {
        private string UserName;
        private string Password;
        private string UserNameNSurname;
        private string Title;
        private string Mail;
        
        public string getUserName(string userName)
        {
            this.UserName = userName;
            return this.UserName;
        }
        public string getPassword(string password)
        {
            this.Password = password;
            return this.Password;
        }
        public string getUserNameNSurname(string userNameNSurname)
        {
            this.UserNameNSurname = userNameNSurname;
            return this.UserNameNSurname;
        }
        public string getTitle(string title)
        {
            this.Title = title;
            return this.Title;
        }
        public string getMail(string mail)
        {
            this.Mail = mail;
            return this.Mail;
        }
    }
}
