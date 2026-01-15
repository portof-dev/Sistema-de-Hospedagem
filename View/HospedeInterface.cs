using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SISTEMA_DE_HOSPEDAGEM.Models;
using SISTEMA_DE_HOSPEDAGEM.Services;



namespace SISTEMA_DE_HOSPEDAGEM.View
{
    public class HospedeInterface
    {
        public void MenuInterface()
        {
            HospedeServices hospedeServices = new HospedeServices(); //*** Instanciando o HospedeService Na CLASSE
            bool EstaRodando = true;

            while (EstaRodando)
            {
            System.Console.WriteLine("------------------------------\n Maximus Hotel \n------------------------------");
            System.Console.WriteLine("1 - Cadastrar Hospede");
            System.Console.WriteLine("2 - Listar Hospedes");
            System.Console.WriteLine("3 - Atualizar Hospedes");
            System.Console.WriteLine("4 - Deletar Hospedes");
            System.Console.WriteLine("0 - sair");
            System.Console.WriteLine("--------------------------------------");
            string opcao = Console.ReadLine()!;
            Console.Clear();

            switch (opcao)
            
            {
                
             case "1":
             System.Console.Write("Digite o Nome:");
             string nome = Console.ReadLine()!;
             System.Console.Write("Digite a Profissão:");
             string profissao = Console.ReadLine()!;
             System.Console.Write("Nacionalidade:");
             string nacionalidade = Console.ReadLine()!;
             System.Console.Write("Digite o CPF:");
             string cpf = Console.ReadLine()!;
             System.Console.Write("Digite o RG:");
             string rg = Console.ReadLine()!;
            
            Hospede NovoHospede = new Hospede(nome, profissao, nacionalidade,cpf,rg); // INSTANCIAR O HOSPEDE COM PARAMENTROS 
            hospedeServices.CadastrarHospede(NovoHospede); //** Adiciona na lista do services

             System.Console.WriteLine($"\n {nome}  Seu Cadastro foi Realizado Com Sucesso!!!\n ");
             break;

             case "2":
             System.Console.WriteLine("-------\n Lista de Hospedes ----------");
             {
                List<Hospede> listaHospedes = hospedeServices.ListarHospedes(); //** PEGA A LISTA DO SERVICE
                foreach (Hospede h in listaHospedes)

                System.Console.WriteLine($"Nome: {h.Nome} | CPF: {h.CPF} ");
                
                break;
             }
            case "3":

                {
                System.Console.WriteLine("Digite o  CPF que Deseja Atualizar: ");
                string cpfBusca = Console.ReadLine()!;


                System.Console.WriteLine("----------Insira os novos Dados: ----------");

                System.Console.WriteLine("\nNovo Nome: ");
                string novoNome = Console.ReadLine()!;

                System.Console.WriteLine("\nNova Profissão:");
                string novaProfissao = Console.ReadLine()!;

                System.Console.WriteLine("\nNova Nacionalidade:");
                string novaNacionalidade = Console.ReadLine()!;
                
               
                Hospede dadosNovos = new Hospede(novoNome,novaProfissao, novaNacionalidade, cpfBusca, ""); //*? OBJETO criado temporariamente

                try
                {
                    hospedeServices.AtualizarHospede(cpfBusca, dadosNovos);
                }
                catch (System.Exception excpf)
                {
                    
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"[AVISO]: {excpf.Message}");
                    Console.ResetColor();
                }

                } 
            break;    
            

             case "0":
             EstaRodando = false;
             System.Console.WriteLine("Desligando....");
             break;   
                
            }


     
            }
        }
       
    }
} 