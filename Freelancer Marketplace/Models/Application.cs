using System;
using System.Collections.Generic;

namespace Freelancer_Marketplace.Models;

public partial class Application
{
    public int ApplicationId { get; set; }

    public string? Proposal { get; set; }

    public int FreelancerId { get; set; }

    public int ProjectId { get; set; }

    public DateTime? AppliedOn { get; set; }

    public virtual Freelancer Freelancer { get; set; } = null!;

    public virtual Project Project { get; set; } = null!;
}
