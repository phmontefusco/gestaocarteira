using System;

namespace  gestaocarteira.domain;


public class Produto : Entity
{
    public string descricao { get; set; } = string.Empty;
    public Boolean flagAgenda { get; set; }
}