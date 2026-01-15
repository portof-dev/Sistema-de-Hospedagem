using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SISTEMA_DE_HOSPEDAGEM.Models
{
    public class Hospede
    {
        public string? Nome{get;set;}
        public string? Profissao {get;set;}
        public string? Nacionalidade{get;set;}
        public string? CPF{get;set;}
        public string? RG{get;set;}



        public Hospede(string nome, string profissao, string nacionalidade, string cpf, string rg)
        {
            Nome = nome;
            Profissao = profissao;
            Nacionalidade = nacionalidade;
            CPF = cpf;
            RG = rg;

        }


        public Hospede()
        {
            
        }
    }
}