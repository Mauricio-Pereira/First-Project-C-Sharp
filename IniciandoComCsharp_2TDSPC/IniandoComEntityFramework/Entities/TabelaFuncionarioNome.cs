using System;
using System.Collections.Generic;

namespace IniandoComEntityFramework.Entities;

public partial class TabelaFuncionarioNome
{
    public int? EmployeeId { get; set; }

    public string? NomeFuncionario { get; set; }

    public int? ManagerId { get; set; }

    public string? NomeGerente { get; set; }
}
