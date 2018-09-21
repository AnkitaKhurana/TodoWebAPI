using Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using TodoData.Entities;

namespace DataAccess.Mapper
{
    public class UserMapper
    {
        public static User ToDB (UserDTO userDTO)
        {
            User user = new User()
            {
                Id = userDTO.Id,
                UserName = userDTO.UserName,
                Password = userDTO.Password
            };
            return user;
        }

        public static UserDTO ToDTO(User user)
        {
            UserDTO userDTO = new UserDTO()
            {
                Id = user.Id,
                UserName = user.UserName,
                Password = user.Password
            };
            return userDTO;
        }

    }
}
