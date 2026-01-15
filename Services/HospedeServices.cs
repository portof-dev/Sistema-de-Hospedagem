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

        public void RemoverHospede(Hospede hospede)
        {
            hospedes.Remove(hospede);
        }
    }
}