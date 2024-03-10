using System;
using System.Collections.Generic;

namespace Domain;

public partial class Player
{
    public int Id { get; set; }

    public int? PlayerApiId { get; set; }

    public string? PlayerName { get; set; }

    public int? PlayFifaApiId { get; set; }

    public string? Birthday { get; set; }

    public decimal? Height { get; set; }

    public decimal? Weight { get; set; }
}
