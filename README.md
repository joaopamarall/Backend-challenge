## Passo a Passo da Aplicação ProdutoDesconto
- C#

### Namespace e Classe Principal

O código começa importando o namespace `System`, que fornece funcionalidades básicas do sistema, como entrada e saída. Ele define um namespace chamado `ProdutoDesconto` e uma classe chamada `Program`, que contém o método `Main`, o ponto de entrada da aplicação.

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

### Como Acessar e Rodar a Aplicação

Para acessar e rodar a aplicação ProdutoDesconto em sua máquina, siga os passos abaixo:

1. **Clone o Repositório:**
   Abra o terminal ou prompt de comando e navegue até o diretório onde deseja clonar o repositório. Em seguida, execute o seguinte comando:

Substitua `URL_DO_REPOSITORIO` pela URL do seu repositório no GitHub.

2. **Abra a Solução no Visual Studio:**
- Abra o Visual Studio.
- Selecione "Arquivo" > "Abrir" > "Projeto/Solução".
- Navegue até a pasta onde o repositório foi clonado e abra o arquivo da solução (.sln).

3. **Execute a Aplicação:**
- Com a solução aberta no Visual Studio, pressione F5 ou clique no botão "Iniciar" para compilar e executar a aplicação.
- O console do Visual Studio exibirá as instruções para inserir o valor do produto e mostrará os resultados do desconto.

4. **Interaja com a Aplicação:**
- Siga as instruções no console para inserir o valor do produto.
- A aplicação calculará e exibirá o valor do desconto, o valor com desconto aplicado e o valor do produto com formatação de moeda.

5. **Visualize os Resultados:**
- Após a interação com a aplicação, você verá os resultados no console.
- A aplicação também aguardará que você pressione Enter antes de encerrar, permitindo que você visualize os resultados antes de sair.

Agora você está pronto para acessar e rodar a aplicação ProdutoDesconto em sua máquina local.

---
