using System;
using System.Collections.Generic;

namespace Domain;

public partial class Team
{
    public int Id { get; set; }

    public int? TeamApiId { get; set; }

    public int? TeamFifaApiId { get; set; }

    public string? TeamLongName { get; set; }

    public string? TeamShortName { get; set; }
}
