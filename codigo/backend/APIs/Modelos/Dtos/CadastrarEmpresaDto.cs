﻿namespace APIs.Modelos.Dtos;

public class CadastrarEmpresaDto
{
    public string Nome { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Senha { get; set; } = string.Empty;
    public string CNPJ { get; set; } = string.Empty;
}
