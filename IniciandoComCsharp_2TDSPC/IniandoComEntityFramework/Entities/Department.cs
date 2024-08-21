using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class Department
{
    public byte DepartmentId { get; set; }

    public string DepartmentName { get; set; } = null!;

    public int? ManagerId { get; set; }

    public byte? LocationId { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public virtual ICollection<JobHistory> JobHistories { get; set; } = new List<JobHistory>();

    public virtual Location? Location { get; set; }

    public virtual Employee? Manager { get; set; }
}
