# WebHamburgueria (Code & C#eese Web)
## 1. Visão Geral
### 1.1 Objetivo
  - Este projeto consiste em um sistema web de administração de pedidos para uma hamburgueria, possibilitando gerenciar produtos, pedidos, usuários e relatórios.
### 1.2 Escopo
  - O sistema contempla o cadastro de produtos, usuários, realização de pedidos e emissão de relatórios básicos de vendas. Funcionalidades como integração com gateways de pagamento ou análise avançada de dados não estão inclusas nesta versão.
### 1.3 Público-alvo
  -	Gerentes de loja, atendentes de balcão e administradores do sistema que precisam controlar e visualizar pedidos em tempo real.
### 1.4 Tecnologias e Ferramentas
  -	ASP.NET MVC 5
  -	Entity Framework
  -	SQL Server
  -	Bootstrap 5.3 (tema Morph)
  -	jQuery 3.6
## 2. Instalação
### 2.1 Pré-requisitos
  -	Visual Studio 2022 ou superior
  -	.NET Framework 4.8
  -	SQL Server 2019 ou Azure SQL
  -	Navegador atualizado (Chrome, Edge, Firefox, etc.)
### 2.2 Passo a Passo de Instalação
  1.	Clone o repositório:
```
bash
git clone https://github.com/SenacPPR-TI51GrupoWebLuiz-Henrique/WebHamburgueria.git
```
  2.	Abra no Visual Studio.
  3.	Configure a string de conexão no ConnectionStrings.config.
  4.	Crie o banco de dados.
  5.	Execute o projeto (F5 ou Ctrl + F5).
## 3. Configuração
  String de Conexão
  -	No arquivo ConnectionStrings.config, seção <connectionStrings>, defina o nome do servidor, banco e credenciais.
## 4. Uso e Funcionalidades
  ### 4.1 Fluxo Principal (Exemplo: Produto)
  1.	Login no sistema.
  2.	Acesse a tela de Produtos (/Produto/Index).
  3.	Crie um novo Produto clicando em “Criar Novo”.
  4.	Adicione as informações do produto (nome do produto, quantidade, preço, etc.).
  5.	Salve o produto. O sistema armazenará no banco e retornará para a listagem de produtos.
<!--
  ### 4.2 Cadastro de Produtos
    -	Explique como acessar e utilizar a tela de produtos (criar, editar, excluir).
-->
## 5. Dicas de Uso e Boas Práticas
  -	Sempre criar um backup do banco antes de atualizações críticas.
  -	Utilizar um ambiente de testes para validar novas funcionalidades antes de subir em produção.
  -	Manter bibliotecas atualizadas para corrigir falhas de segurança e bugs.
  -	Recomenda-se o uso de HTTPS, firewall e antivírus.
## 6. FAQ e Solução de Problemas
  -	Erro de Conexão: Verifique se a string de conexão está correta e o servidor de banco está ativo.
  -	Erro 404 ao acessar páginas: Verifique se as rotas estão configuradas corretamente no RouteConfig (ou MapControllerRoute no .NET Core).
  -	Problemas de Layout: Confirme se as referências ao CSS do Bootstrap e aos scripts estão corretas.
## 7. Contato e Suporte
  -	Responsáveis: 
    -	Luiz H D Alecrim (163210265+Lu1zH3nr1qu3DA@users.noreply.github.com)
    -	HenriqueSF1 (163210265+Lu1zH3nr1qu3DA@users.noreply.github.com)
  -	GitHub Issues: Repositório no GitHub para relatar bugs e enviar sugestões.

<!--
  ## Sobre o projeto
  Este é o Projeto Integrador da turma TI51 do Senac de Presidente Prudente.
  Nosso grupo tem dois integrantes: [Luiz H. D. Alecrim](https://github.com/Lu1zH3nr1qu3DA) e [HenriqueSF1](https://github.com/HenriqueSF1)
  ## Estado atual
  Atualmente, o projeto está em desenvolvimento, então a ocorrência de erros, bugs e features ainda não implementadas é muito alta.
-->
