using System;
using System.Collections.Generic;

namespace mvc_erp.Models;

public partial class TbCustomFieldMapping
{
    public int MappingId { get; set; }

    public string? FieldName { get; set; }

    public string? FieldExpression { get; set; }
}
