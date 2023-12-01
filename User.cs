using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// namespace _02_Cars

namespace Helloworlds
{
    public class User
    {
        string _username;
        string _password;
        string _email;
        string _phone;
        DateTime _dateOfBirth;
        int _age;
        float _salary;
        bool _isEmployed;

        // constructor
        public User(string username, string password, string email, string phone, DateTime dateOfBirth, int age, float salary, bool isEmployed)
        {
            _username = username;
            _password = password;
            _email = email;
            _phone = phone;
            _dateOfBirth = dateOfBirth;
            _age = age;
            _salary = salary;
            _isEmployed = isEmployed;
        }

        // TODO get user info
        public string GetUserInformation(){
            return $"Name: {_username}\n Email: {_email}\n Phone: {_phone}\n Date of Birth: {_dateOfBirth}\n Age: {_age}\n Salary: {_salary}\n Is Employed: {_isEmployed}\n";
        }

        // TODO get user age
        public int GetUserAge(){
            return _age;
        }

        // TODO get user salary
        public float GetUserSalary(){
            return _salary;
        }

        // check password length is > 8
        public bool GetHashedPassword(){
            if (_password.Length > 8){
                return true;
            } else {
                return false;
            }
        }

        // get username
        public string GetUsername(){
            return _username;
        }

        // get isEmployed
        public bool GetIsEmployed(){
            return _isEmployed;
        }



        
    }
}
