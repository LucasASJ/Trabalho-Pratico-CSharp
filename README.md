# Trabalho-Pratico-CSharp
Trabalho Tópicos Especiais de Sistemas

## Alunos:
- Lucas Antonio Salomão Jarek
- Vinicius da Costa Silva
- Wallacy Gabriel Alves Bandeira
---

## Questões Resolvidas

### * Exercício 1: Validação de Senha Forte
Este exercício solicita ao usuário que insira uma senha e verifica se ela é forte, considerando os seguintes critérios:
  - Deve ter pelo menos 8 caracteres.
  - Deve conter pelo menos uma letra maiúscula.
  - Deve conter pelo menos um número.
  - Deve conter pelo menos um caractere especial dos seguintes: `!@#$%¨&*()_-+=`.

A senha só será considerada forte quando atender todos esses requisitos.

### * Exercício 2: Tabuada Completa
Neste exercício, o programa solicita ao usuário um número e exibe a tabuada desse número de 1 a 10, utilizando um laço `for`.

### * Exercício 3: Cálculo de Fatorial
O programa solicita um número inteiro positivo ao usuário e calcula o fatorial desse número utilizando um laço `while`. O fatorial de um número `n` é o produto de todos os números inteiros de 1 até `n`.

### * Exercício 4: Conversor de Temperaturas
Este exercício cria um menu interativo para conversão de temperaturas:
1. Celsius para Fahrenheit.
2. Fahrenheit para Celsius.
O menu continua ativo até o usuário escolher a opção de sair (opção 3).

---

### * Exercício 5: Verificação de Palíndromo
Este exercício solicita ao usuário que insira uma palavra ou frase e verifica se ela é um palíndromo, ou seja, se pode ser lida da mesma forma de trás para frente (ignorando espaços e acentos).

### * Exercício 6: Cadastro de Produtos
Solicita ao usuário o cadastro de 3 produtos, cada um com:
- Nome
- Preço
- Quantidade em estoque

Ao final, exibe o valor total em estoque de cada produto.

### * Exercício 7: Soma de Números Pares
Solicita ao usuário que digite 10 números inteiros e soma todos os números pares digitados.

### * Exercício 8: Cálculo de IMC
Solicita ao usuário o peso e a altura, calcula o IMC (Índice de Massa Corporal) e classifica o resultado como:
- Abaixo do peso
- Peso normal
- Sobrepeso
- Obesidade

---

# Explicação Detalhada dos Exercícios 9 e 10

## Exercício 9: Jogo da Adivinhação

**Descrição Funcional:**  
Implementa um jogo onde o usuário tenta adivinhar um número aleatório entre 1 e 100, recebendo dicas ("MAIOR" ou "MENOR") a cada tentativa.

### Passo a Passo Lógico

### 1️. Inicialização

- Gera um número aleatório entre 1 e 100 usando `Random.Next(1, 101)`.
- Inicializa o contador de tentativas (`tentativas = 0`).

### 2️. Loop Principal (`do-while`)

- Solicita um palpite ao usuário e valida o input com `int.TryParse`.
- Incrementa o contador `tentativas`.
- Fornece feedback instantâneo:  
  - Se o palpite for menor: exibe `"MAIOR"`.  
  - Se o palpite for maior: exibe `"MENOR"`.

### 3️. Finalização

- Quando o palpite coincide com o número secreto, exibe uma mensagem de sucesso com o número de tentativas.

## Estruturas Utilizadas

| Componente   | Função                                      |
|--------------|---------------------------------------------|
| `Random`     | Geração de números pseudoaleatórios        |
| `do-while`   | Garante pelo menos uma execução do loop    |
| `int.TryParse` | Validação segura de input do usuário      |
| `if-else`    | Lógica condicional para feedback (MAIOR/MENOR) |

## Justificativa

- **Por que `Random`?**  
  É a classe padrão do .NET para geração de números aleatórios, balanceando performance e simplicidade.

- **Por que `do-while`?**  
  Ideal para cenários onde o bloco de código deve executar pelo menos uma vez (como um jogo).

- **Tratamento de erros (`TryParse`)**  
  Evita exceções ao lidar com inputs não numéricos, garantindo robustez.
  

## Exercício 10: Lista de Tarefas (To-Do List)

**Descrição Funcional:**  
Permite ao usuário adicionar tarefas, marcá-las como concluídas e visualizar a lista completa.

### Passo a Passo Lógico

### 1️. Estrutura de Dados

Duas listas paralelas:

- `tarefas (List<string>)`: armazena a descrição das tarefas.
- `concluidas (List<bool>)`: armazena o status (true/false) das tarefas.

### 2️. Menu Interativo (`switch-case`)

- **Opção 1 (Adicionar)**  
  - Captura input do usuário com `Console.ReadLine()`.
  - Adiciona à lista `tarefas` e registra status `false` em `concluidas`.

- **Opção 2 (Concluir)**  
  - Lista tarefas pendentes com índices.
  - Valida o índice e atualiza `concluidas` para `true`.

- **Opção 3 (Listar)**  
  - Exibe todas as tarefas com `[PENDENTE]` ou `[CONCLUÍDA]`.

### 3️. Validação

- Verifica se o índice fornecido existe e está dentro dos limites.

## Estruturas Utilizadas

| Componente   | Função                                  |
|--------------|-----------------------------------------|
| `List<string>` | Armazenamento dinâmico das tarefas     |
| `List<bool>`   | Controle de status (concluída/pendente) |
| `switch-case`  | Navegação entre opções do menu         |
| `for`          | Laço para exibir tarefas               |

## Justificativa

- **Por que listas paralelas?**  
  Solução simples para projetos pequenos, evitando complexidade de classes adicionais. Em projetos maiores, uma classe `Tarefa` seria preferível.

- **Por que `switch-case`?**  
  Organização clara de funcionalidades no menu. Para sistemas complexos, o padrão Command ou Delegates pode ser uma evolução natural.

- **Validação de índices**  
  Impede acesso a posições inválidas nas listas, prevenindo `IndexOutOfRangeException`.
