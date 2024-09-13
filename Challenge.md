# Desafio Backend

## Descrição do Projeto

Como dono da empresa Produtos e CIA, preciso de um sistema para controlar o estoque dos meus produtos. Atualmente, tudo é feito em uma planilha Excel. Como trabalho com mais de uma empresa, tenho dificuldades em controlar o estoque em todas as empresas e realizar transferências de produtos entre elas. Por isso, preciso de uma API RESTful para atender às seguintes situações:

## Requisitos do MVP

### Funcionalidades Obrigatórias

1. **Controle de Usuário com Autenticação (JWT)**
2. **API Documentada com Swagger**
   - Incluindo todos os possíveis status codes para cada endpoint.
3. **CRUD de Produtos**
4. **CRUD de Empresas**
5. **Vinculação de Empresas aos Produtos**
6. **Movimentação Individual de Produtos na Empresa**
   - Adição ou remoção de quantidades de produtos em uma empresa.
7. **Movimentação em Lote de Produtos**
   - Movimentação de vários produtos simultaneamente em uma empresa.
8. **Consultas de Estoque**
   - Valor total do estoque.
   - Quantidade total de produtos no estoque.
   - Custo médio de um produto.
   - Custo médio do estoque.

## Regras para o Desafio

- **Banco de Dados:** Utilizar PostgreSQL.
- **Tecnologia:** Utilizar .NET 7 ou .NET 8.
- **Backend:** Desenvolver toda a API.
- **Migrations:** Criar migrations utilizando EF Core 7.
- **Entrega:**
  - Código fonte versionado em um repositório no GitHub.
  - Vídeo de até 20 minutos explicando o projeto, incluindo a construção, arquitetura, códigos e uma demonstração funcional. Utilize o vídeo para promover o produto.
