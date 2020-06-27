using api.Data.Collections;
using Api.Models;
using System;
using System.Collections.Generic;

namespace Api.Data.Collections
{
  public class Responsavel
  {
    public Responsavel(
          string nome,
          string sobrenome,
          string email,
          string senha,
          string id,
          IEnumerable<EstudanteDto> estudantes
          )
    {
      this.Id = id;
      this.Nome = nome;
      this.Sobrenome = sobrenome;
      this.Email = email;
      this.Senha = senha;
      this.Estudantes = estudantes;
    }

    public string Id { get; set; }
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }
    public IEnumerable<EstudanteDto> Estudantes { get; set; }
  }

}