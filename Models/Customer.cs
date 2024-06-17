using System;
using System.Collections.Generic;

namespace CoreEntityFrameworkDatabaseFirstApproach.Models;
public class Customer
{
    public int CustomerId { get; set; }
    public string CustomerName { get; set; } = null!;
    public double? CustomerAmount { get; set; }
}
