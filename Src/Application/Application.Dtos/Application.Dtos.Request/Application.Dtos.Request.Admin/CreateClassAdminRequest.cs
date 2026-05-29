using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Dtos.Request.Admin
{
    public class CreateClassAdminRequest
    {
        public string Name { get; set; } = string.Empty;

        public int Max_Users { get; set; }

    }
}


