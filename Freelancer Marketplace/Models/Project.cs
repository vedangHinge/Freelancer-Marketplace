using System;
using System.Collections.Generic;

namespace Freelancer_Marketplace.Models;

public partial class Project
{
    public int ProjectId { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public decimal? Budget { get; set; }

    public int ClientId { get; set; }

    public virtual ICollection<Application> Applications { get; set; } = new List<Application>();

    public virtual Client Client { get; set; } = null!;
}
