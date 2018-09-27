using DataAccess.UserData;
using Shared.DTOs;
using Shared.Exceptions;
using BCrypt.Net;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Logic
{
    public class UserLogic
    {
        private string mySalt = BCrypt.Net.BCrypt.GenerateSalt();
        UserData userData = new UserData();
        public bool Register(UserDTO user)
        {
            try
            {
                user.Password = Hashing.HashPassword(user.Password);
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
        
        public UserDTO Find(string UserName , string Password)
        {
            try
            {

                UserDTO userDTO = new UserDTO()
                {
                    UserName = UserName,
                    Password = Password
                };                
                return Login(userDTO);

            }
            catch
            {
                return null;
            }
        }

        public UserDTO Login(UserDTO user)
        {
            try
            {
                var userFound = userData.FindUser(user.UserName);
                if (userFound!= null)
                {
                    if (Hashing.ValidatePassword(user.Password, userFound.Password))
                    {
                        return userFound;
                    }
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
