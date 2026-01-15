🏨 Maximus Hotel - Sistema de Hospedagem
O Maximus Hotel é um sistema de gestão de hospedagem desenvolvido em C# com o objetivo de aplicar conceitos avançados de Programação Orientada a Objetos (POO). O foco principal deste projeto é a criação de um núcleo de negócio sólido e escalável, preparando o terreno para futuras integrações com APIs e Bancos de Dados SQL.

🚀 Funcionalidades Atuais
Gestão de Hóspedes: Cadastro completo, listagem e remoção (em memória).

Arquitetura em Camadas: Separação clara entre Models, Services (Lógica) e View (Console).

Encapsulamento: Proteção dos dados e estado dos objetos.

Tratamento de Exceções: Validações para garantir a integridade dos dados inseridos.

🛠️ Tecnologias Utilizadas
Linguagem: C# (.NET 8/9)

Paradigma: Programação Orientada a Objetos (POO)

Armazenamento: Listas dinâmicas em memória (Simulação de Repositório).

🏗️ Estrutura do Projeto
O projeto foi desenhado seguindo o padrão de separação de responsabilidades:

Models: Contém as entidades de negócio (Hóspede, Quarto, Reserva).

Services: Onde reside a inteligência do sistema (Regras de negócio e manipulação de dados).

View: Camada de interação com o usuário via Console.

📈 Escalabilidade :
Este sistema foi projetado para ser "plugável". Embora utilize armazenamento em memória atualmente, a estrutura de pastas e classes permite a implementação futura de:

Banco de Dados: Substituição da List<T> por Entity Framework Core.

API: Exposição dos serviços através de endpoints HTTP (ASP.NET Core).

Interface Web: Criação de um frontend moderno consumindo os serviços existentes.