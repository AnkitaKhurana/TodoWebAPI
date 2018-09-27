using Shared.DTOs;
using Shared.Exceptions;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using TodoData.Entities;
using Map = DataAccess.Mapper;

namespace DataAccess.UserData
{
    public class UserData
    {
        private TodoContext db = new TodoContext();

        public bool AddUser(UserDTO user)
        {
            try
            {
                if (db.Users.Where(x => x.UserName == user.UserName).FirstOrDefault()!= null)
                {
                    throw new UserAlreadyExists();
                }
                User userDB = Map.UserMapper.ToDB(user);
                userDB.Id = Guid.NewGuid();
                db.Users.Add(userDB);
                db.SaveChanges();
                return true;                
            }
            catch(UserAlreadyExists){
                throw new UserAlreadyExists();
            }
            catch 
            {
                return false;
            }
        }

        public UserDTO FindUserByID(Guid userId)
        {
            try
            {
                User user = db.Users.Find(userId);
                if (user == null)
                {
                    throw new NoSuchUserExists();
                }
                UserDTO userDTO = Map.UserMapper.ToDTO(user);
                return userDTO;
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

        public UserDTO FindUser ( string Username)
        {
            try
            {
                User user = db.Users.Where(x => x.UserName == Username).FirstOrDefault();
                UserDTO userDTO = Map.UserMapper.ToDTO(user);
                return userDTO;
            }
            catch
            {
                return null;
            }

        }

        public UserDTO FindUserByCredential(string Username, string Password)
        {
            try
            {
                User user = db.Users.Where(x => x.UserName == Username && x.Password == Password).FirstOrDefault();
                if (user == null)
                {
                    throw new NoSuchUserExists();
                }
                UserDTO userDTO = Map.UserMapper.ToDTO(user);
                return userDTO;
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
