using System;
using System.Collections.Generic;

namespace Freelancer_Marketplace.Models;

public partial class Client
{
    public int ClientId { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public virtual ICollection<Project> Projects { get; set; } = new List<Project>();
}
