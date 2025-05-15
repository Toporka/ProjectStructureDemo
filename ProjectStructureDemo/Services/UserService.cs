using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class UserService
{
    // Список пользователей
    List<User> users;

    // Конструктор класса с выделением памяти для списка
    public UserService() => users = new List<User>();

    // Метод добавления нового объекта
    public void AddUser(User user) => users.Add(user);

    // Метод нахождения объекта по свойству Id
    public User GetUser(int Id)
    {
        foreach (var user in users)
            if (user.Id == Id) 
                return user;

        return null;
    }
}
