using System;
using System.Collections.Generic;

namespace Domain;

public partial class TeamAttribute
{
    public int Id { get; set; }

    public int? TeamFifaApiId { get; set; }

    public int? TeamApiId { get; set; }
}
