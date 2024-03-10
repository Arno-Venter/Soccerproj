using System;
using System.Collections.Generic;

namespace Domain;

public partial class League
{
    public int Id { get; set; }

    public int? CountryId { get; set; }

    public string? Name { get; set; }

    public virtual Country? Country { get; set; }
}
