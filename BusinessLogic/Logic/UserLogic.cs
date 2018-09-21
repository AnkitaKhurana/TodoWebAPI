using DataAccess.UserData;
using Shared.DTOs;
using Shared.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Logic
{
    public class UserLogic
    {
        UserData userData = new UserData();
        public bool Register(UserDTO user)
        {
            try
            {
                return userData.AddUser(user);               
            }
            catch (UserAlreadyExists)
            {
                throw new UserAlreadyExists();
            }
            catch
            {
                return false;
            }
        }

        public UserDTO Login(UserDTO user)
        {
            try
            {
                if (userData.FindUserByCredential(user.UserName, user.Password)!=null)
                {
                    return user;
                }
                return null;
            }
            catch (NoSuchUserExists)
            {
                throw new NoSuchUserExists();
            }
            catch
            {
                return null;
            }
        }
    }
}
