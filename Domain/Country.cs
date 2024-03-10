using System;
using System.Collections.Generic;

namespace Domain;

public partial class Country
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<League> Leagues { get; set; } = new List<League>();

    public virtual ICollection<Match> Matches { get; set; } = new List<Match>();
}
