using Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TodoWebApi.Models;

namespace TodoWebApi.Mapper
{
    public class UserMapper
    {
        public static UserDTO ToDTO( User user)
        {
            return new UserDTO()
            {
                UserName = user.Username,
                Id = user.Id,
                Password = user.Password
            };
           
        }

        public static User ToDTO(UserDTO user)
        {
            return new User()
            {
                Username = user.UserName,
                Id = user.Id,
                Password = user.Password
            };

        }
    }
}