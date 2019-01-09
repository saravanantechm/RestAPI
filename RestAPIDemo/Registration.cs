using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPIDemo
{
    public class Registration
    {
        List<Users> UsersList;

        static Registration stdregd = null;
        private Registration()
        {
            UsersList = new List<Users>();
        }
        public static Registration getInstance()
        {
            if (stdregd == null)
            {
                stdregd = new Registration();
                return stdregd;
            }
            else
            {
                return stdregd;
            }
        }
        public void Add(Users _data)
        {
            UsersList.Add(_data);
        }
        public String Remove(String registrationNumber)
        {
            for (int i = 0; i < UsersList.Count; i++)
            {
                Users stdn = UsersList.ElementAt(i);
                if (stdn.RegistrationNumber.Equals(registrationNumber))
                {
                    UsersList.RemoveAt(i);//update the new record
                    return "Delete successful";
                }
            }
            return "Delete un-successful";
        }
        public List<Users> getAllUser()
        {
            if(UsersList.Count==0)
            {
                UsersList.Add(new Users() { FirstName="Manoj", LastName="Kumar", RegistrationNumber="1233232345" });
                UsersList.Add(new Users() { FirstName = "Selva", LastName = "Kumar", RegistrationNumber = "232323" });
                UsersList.Add(new Users() { FirstName = "Mani", LastName = "K", RegistrationNumber = "12334343445" });
            }

            return UsersList;
        }
        public String Updateuser(Users std)
        {
            for (int i = 0; i < UsersList.Count; i++)
            {
                Users stdn = UsersList.ElementAt(i);
                if (stdn.RegistrationNumber.Equals(std.RegistrationNumber))
                {
                    UsersList[i] = std;//update the new record
                    return "Update successful";
                }
            }
            return "Update un-successful";
        }
    }
}
