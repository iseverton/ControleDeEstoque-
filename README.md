# Funcionalidades Principais

## 📦 Cadastro e Gerenciamento de Produtos
- Registro de produtos com **nome, descrição, categoria, código de barras, preço, estoque mínimo e data de validade**.
- Associação dos produtos a **fornecedores**.

## 📊 Controle de Estoque e Movimentação de Produtos
- Registro de **entradas e saídas** de produtos.
- Identificação do **tipo de movimentação** (`venda`, `ajuste de estoque`, `devolução`, etc.).
- Controle de **quem realizou a movimentação** e **quando**.
- **Notificações automáticas** para estoque baixo ou produtos vencendo.

## 🏢 Gerenciamento de Fornecedores
- Cadastro de **fornecedores** com dados completos (*razão social, CNPJ, contato, endereço*).
- **Validação de endereço** via API do CEP.
- Associação de **fornecedores aos produtos fornecidos**.

## 🔐 Autenticação e Autorização (Identity)
- Implementação de **login seguro** com Identity e JWT.
- **Controle de acesso baseado em roles** (`Administrador`, `Gerente`, `Funcionário`).
- Registro de **permissões específicas** para cada nível de usuário.


# Registro de Movimentação de Produtos

Quando o usuário adicionar ou retirar um produto do estoque, será gerado um registro único para cada movimentação. Este registro armazena informações essenciais para rastrear e auditar a operação de forma clara e organizada.

## Detalhes do Registro de Movimentação

Cada movimentação de produto será registrada em uma tabela específica com as seguintes informações:

### 1. **ID da Movimentação**
   - **Descrição**: Identificador único da movimentação.
### 2. **Data da Movimentação**
   - **Descrição**: A data e hora exatas em que a movimentação foi realizada.
### 3. **Quantidade Movimentada**
   - **Descrição**: Quantidade de produto que foi adicionada ou retirada do estoque.
### 4. **Tipo da Movimentação**
   - **Descrição**: O tipo da movimentação que ocorreu. Os tipos podem incluir:
     - **Entrada**: Produto adicionado ao estoque.
     - **Saída**: Produto retirado do estoque.
### 5. **Responsável pela Movimentação**
   - **Descrição**: O usuário ou funcionário que realizou a movimentação (adicionou ou retirou o produto).
### 6. **Produto Movimentado**
   - **Descrição**: O produto sobre o qual a movimentação foi realizada, identificando qual item foi alterado.
