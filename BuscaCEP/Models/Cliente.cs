﻿namespace BuscaCEP.Models;

public class Cliente : Endereco
{
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }
    public string CPF { get; set; }
    public byte? Foto { get; set; }
}
