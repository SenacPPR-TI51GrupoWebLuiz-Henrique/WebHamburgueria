# WebHamburgueria (Code & C#eese Web)

## Sobre o Projeto

Este é o Projeto Integrador da turma TI51 do Senac de Presidente Prudente. Nosso grupo tem dois integrantes: [Luiz H D Alecrim](https://github.com/Lu1zH3nr1qu3DA) e [HenriqueSF1](https://github.com/HenriqueSF1).

## Tecnologias Utilizadas

- **JavaScript**
- **SCSS**
- **HTML**
- **C#**
- **TSQL**
- **CSS**

## Funcionalidades

- **Cadastro de Clientes**: Permite o cadastro de novos clientes.
- **Realização de Pedidos**: Os atendentes realizam os pedidos (futuramente essa função estará disponível aos usuários para que possam realizar seus pedidos online).
- **Acompanhamento dos Pedidos**: Os funcionários podem acompanhar os pedidos que estão na fila e os que já foram concluídos.

<!--
- **Realização de Pedidos**: Os clientes podem realizar pedidos online.
- **Gerenciamento de Pedidos**: Os funcionários podem visualizar e gerenciar os pedidos realizados.
- **Relatórios**: Geração de relatórios de vendas.
-->

## Instalação

### Pré-requisitos

- Visual Studio 2022 ou superior
- .NET Framework 4.8
- SQL Server 2019 ou Azure SQL
- Navegador atualizado (Chrome, Edge, Firefox, etc.)

### Passo a Passo de Instalação

1. Clone o repositório:
   ```bash
   git clone https://github.com/SenacPPR-TI51GrupoWebLuiz-Henrique/WebHamburgueria.git
   ```
2. Abra no Visual Studio.
3. Renomeie `ConnectionStrings-template.config` para `ConnectionStrings.config`.
4. Configure a string de conexão no `ConnectionStrings.config`.
5. Crie o banco de dados.
6. Execute o projeto (`F5` ou `Ctrl + F5`).

## Configuração

### String de Conexão

No arquivo `ConnectionStrings.config`, seção `<connectionStrings>`, defina o nome do servidor, banco e credenciais.

## Uso e Funcionalidades

### Fluxo Principal (Exemplo: Produto)

1. Login no sistema.

   ![image](https://github.com/user-attachments/assets/fd248330-72dd-44f0-a694-54c3bc9c72b4)
   
2. Acesse a tela de Produtos (`/Produto/Index`).

   ![image](https://github.com/user-attachments/assets/358061a4-40be-491e-b007-6f4d3c4e5710)

3. Crie um novo Produto clicando em “`Criar Novo`”.

   ![image](https://github.com/user-attachments/assets/c4258634-8c1f-4a1b-b3fd-80ca63bba16e)
   
4. Adicione as informações do produto (nome do produto, preço, etc.).
5. Salve o produto. O sistema armazenará no banco e retornará para a listagem de produtos.

   ![image](https://github.com/user-attachments/assets/8c18a812-a119-417c-a0ad-932ec6ac7b33)


## Dicas de Uso e Boas Práticas

- Sempre criar um backup do banco antes de atualizações críticas.
- Utilizar um ambiente de testes para validar novas funcionalidades antes de subir em produção.
- Manter bibliotecas atualizadas para corrigir falhas de segurança e bugs.
- Recomenda-se o uso de HTTPS, firewall e antivírus.

## FAQ e Solução de Problemas

- Erro de Conexão: Verifique se a string de conexão está correta e o servidor de banco está ativo.
- Erro 404 ao acessar páginas: Verifique se as rotas estão configuradas corretamente no RouteConfig (ou MapControllerRoute no .NET Core).
- Problemas de Layout: Confirme se as referências ao CSS do Bootstrap e aos scripts estão corretas.

## Contato e Suporte

- Responsáveis:
  - [Luiz H D Alecrim](https://github.com/Lu1zH3nr1qu3DA)
  - [HenriqueSF1](https://github.com/HenriqueSF1)
- GitHub Issues: Para [relatar bugs e enviar sugestões](https://github.com/SenacPPR-TI51GrupoWebLuiz-Henrique/WebHamburgueria/issues/new).

---

Projeto Integrador - Senac Presidente Prudente - TI51

---

**Observação**: Para visualizar todos os commits, acesse [Commits](https://github.com/SenacPPR-TI51GrupoWebLuiz-Henrique/WebHamburgueria/commits/main).
