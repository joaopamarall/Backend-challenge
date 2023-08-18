## Passo a Passo da Aplicação ProdutoDesconto
- C#

### Namespace e Classe Principal

O código começa importando o namespace `System`, que fornece funcionalidades básicas do sistema, como entrada e saída. Ele define um namespace chamado `BlackFridayDiscount` e uma classe chamada `Program`, que contém o método `Main`, o ponto de entrada da aplicação.

### Solicitação do Valor do Produto

O programa exibe uma mensagem no console, pedindo ao usuário para informar o valor do produto. O valor inserido pelo usuário é lido como uma string usando `Console.ReadLine()` e armazenado na variável `input`.

### Conversão do Valor para Decimal

Aqui, o programa tenta converter a string de entrada (`input`) em um valor decimal usando `decimal.TryParse()`. Se a conversão for bem-sucedida, o valor do produto é armazenado na variável `produtoValor`. Se a conversão falhar, uma mensagem de erro é exibida.

### Cálculo do Desconto e Saída Formatada

Se a conversão do valor do produto for bem-sucedida, o programa calcula o valor do desconto (60% do valor do produto) e o valor do produto com o desconto aplicado. Em seguida, ele usa interpolação de string (usando o símbolo `$`) para formatar e exibir as mensagens de saída de acordo com o exemplo fornecido. O `:C` após as variáveis numéricas formata-as como valores monetários.

### Mensagem de Erro de Valor Inválido

Se a conversão do valor de entrada falhar, o programa exibirá uma mensagem de erro, indicando que o valor fornecido não é válido numericamente.

### Finalização do Programa

Ao final do programa, foi adicionado o código `Console.WriteLine("Pressione Enter para sair...");` para exibir uma mensagem para o usuário. Isso é seguido por `Console.ReadLine();` que aguarda o usuário pressionar Enter antes de sair, permitindo que o usuário veja os resultados antes de encerrar a aplicação.
