using System;
using System.Collections.Generic;

namespace Domain;

public partial class PlayerAttribute
{
    public int Id { get; set; }

    public int? PlayerFifaApiId { get; set; }

    public int? PlayerApiId { get; set; }

    public string? Date { get; set; }

    public int? OverallRating { get; set; }

    public int? Potential { get; set; }

    public string? PreferredFoot { get; set; }

    public int? Acceleration { get; set; }

    public int? Agility { get; set; }

    public int? ShotPower { get; set; }

    public int? Penalties { get; set; }

    public int? LongPassing { get; set; }

    public int? ShortPassing { get; set; }

    public int? BallControl { get; set; }

    public int? Positioning { get; set; }
}
