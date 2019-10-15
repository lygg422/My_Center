using System;
using System.Collections.Generic;
using System.Text;

namespace MSModels.Tables
{
    public class User
    {
        Guid UserId { get; set; }
        string UserName { get; set; }

        string Password { get; set; }
    }
}
