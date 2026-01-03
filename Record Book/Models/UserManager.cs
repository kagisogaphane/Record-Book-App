using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Record_Book.Models
{
    internal class UserManager
    {
        public static ObservableCollection<User> _DatabaseUsers = new ObservableCollection<User>() { new User() { Email = "Kagiso@github.com", Name = "Kagiso Ghost" } };
        public static ObservableCollection<User> GetUsers()
        {
            return _DatabaseUsers;

        }


        public static void AddUser(User user)
        {
            _DatabaseUsers.Add(user);

        }
    }
}
