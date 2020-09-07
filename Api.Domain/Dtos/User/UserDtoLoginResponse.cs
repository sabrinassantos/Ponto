using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Dtos.User
{
    public class UserDtoLoginResponse
    {
        public string AccessToken { get; set; }
        public double ExpiresIn { get; set; }
        public UserDtoToken UserToken { get; set; }
    }
}
