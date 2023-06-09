using System;
using System.Collections.Generic;

namespace Nagp.UserInfo.Models;

public partial class UserInformation
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? Gender { get; set; }

    public long? Mobile { get; set; }
}
