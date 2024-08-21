using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class Promoco
{
    public int? PromotionEmployeeId { get; set; }

    public int EmployeeId { get; set; }

    public DateTime DtPromotion { get; set; }
}
