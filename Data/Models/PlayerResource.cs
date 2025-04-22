using System;
using System.Collections.Generic;

namespace Strategy_Game.Data.Models;

public partial class PlayerResource
{
    public int Id { get; set; }

    public int? PlayerId { get; set; }

    public int? ResourceId { get; set; }

    public int? Amount { get; set; }

    public virtual Player? Player { get; set; }

    public virtual Resource? Resource { get; set; }
}
