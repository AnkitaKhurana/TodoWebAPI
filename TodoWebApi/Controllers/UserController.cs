
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessLogic.Logic;
using Shared.DTOs;
using Shared.Exceptions;
using TodoWebApi.Mapper;
using TodoWebApi.Models;

namespace TodoWebApi.Controllers
{
    public class UserController : ApiController
    {

        private BusinessLogic.Logic.UserLogic userLogic = new BusinessLogic.Logic.UserLogic();

        [HttpPost]
        public HttpResponseMessage Register(User user)
        {
            try
            {
                UserDTO userDTO = UserMapper.ToDTO(user);
                var userSaved = userLogic.Register(userDTO);
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, user);
                return response;
            }
            catch (UserAlreadyExists e)
            {
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, e.Message);
                return response;
            }
            catch (Exception e)
            {
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.BadRequest, e.Message);
                return response;
            }
        }

        //[Route("login")]
        [HttpPost]
        public HttpResponseMessage Login(User user)
        {
            try
            {
                UserDTO userDTO = UserMapper.ToDTO(user);
                var userSaved = userLogic.Login(userDTO);
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, userSaved); 
                if(userSaved==null)
                {
                    response.StatusCode = HttpStatusCode.OK;
                }
                return response;
            }
            catch (NoSuchUserExists e)
            {
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, e.Message);
                return response;
            }
            catch (Exception e)
            {
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.BadRequest, e.Message);
                return response;
            }

        }
    }
}
