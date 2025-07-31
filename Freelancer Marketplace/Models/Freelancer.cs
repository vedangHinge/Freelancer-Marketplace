using System;
using System.Collections.Generic;

namespace Freelancer_Marketplace.Models;

public partial class Freelancer
{
    public int FreelancerId { get; set; }

    public string Name { get; set; } = null!;

    public string? Skill { get; set; }

    public string Email { get; set; } = null!;

    public virtual ICollection<Application> Applications { get; set; } = new List<Application>();
}
