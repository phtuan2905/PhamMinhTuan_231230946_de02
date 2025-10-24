using System;
using System.Collections.Generic;

namespace PhamMinhTuan_231230946_de02.Models;

public partial class PmtCatalog
{
    public int PmtId { get; set; }

    public string PmtCateName { get; set; } = null!;

    public double? PmtCatePrice { get; set; }

    public int? PmtCateQty { get; set; }

    public string? PmtPicture { get; set; }

    public bool? PmtCateActive { get; set; }
}
