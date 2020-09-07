using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Dtos.User
{
    public class UserDtoToken
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public IEnumerable<ClaimDto> Claims { get; set; }
    }
}
