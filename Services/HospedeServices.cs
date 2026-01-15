using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SISTEMA_DE_HOSPEDAGEM.Models;

namespace SISTEMA_DE_HOSPEDAGEM.Services
{
    public class HospedeServices
    {
        List<Hospede> hospedes = new List<Hospede>();

        public void CadastrarHospede(Hospede hospede)
        {
            hospedes.Add(hospede);
        }


        public List<Hospede> ListarHospedes() //*** METODO PARA CHAMAR A LISTA E TER O RETORNO
        {
            return hospedes;
        }

        public void AtualizarHospede(string cpf, Hospede hospedeAtualizado) //*** metodo para atualizar o Hospede por cpf
        {
            var hospedeExistente = hospedes.FirstOrDefault(h => h.CPF == cpf);
            //TODO FirstOrDefault basicamente pesquisa na coleçao ou lista o item especifico
            //TODO e retorna o primeiro elemento que satifaz a condição que queremos 
            //** h => h.CPF == cpf expressao lambda que define a condição de busca 

            if (hospedeExistente != null)
            {
                hospedeExistente.Nome = hospedeAtualizado.Nome;
                hospedeExistente.Profissao = hospedeAtualizado.Profissao;
                hospedeExistente.RG = hospedeAtualizado.RG;
            }

            else
            {
                throw new Exception("Hóspede com este CPF não foi encontrado.");
            }
        }


        public void RemoverHospede(Hospede hospede)
        {
            hospedes.Remove(hospede);
        }
    }
}