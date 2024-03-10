using System;
using System.Collections.Generic;

namespace Domain;

public partial class Player
{
    public int Id { get; set; }

    public int? PlayerApiId { get; set; }

    public string? PlayerName { get; set; }

    public int? PlayerFifaApiId { get; set; }

    public string? Birthday { get; set; }

    public int? Height { get; set; }

    public int? Weight { get; set; }
}
