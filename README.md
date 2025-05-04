# Trabalho-Pratico-CSharp
Trabalho Tópicos Especiais de Sistemas

Alunos:
- Lucas Antonio Salomão Jarek
- Vinicius da Costa Silva
- Wallacy

Questões Resolvidas

* Exercício 1: Validação de Senha Forte
Este exercício solicita ao usuário que insira uma senha e verifica se ela é forte, considerando os seguintes critérios:
  - Deve ter pelo menos 8 caracteres.
  - Deve conter pelo menos uma letra maiúscula.
  - Deve conter pelo menos um número.
  - Deve conter pelo menos um caractere especial dos seguintes: `!@#$%¨&*()_-+=`.

A senha só será considerada forte quando atender todos esses requisitos.

* Exercício 2: Tabuada Completa
Neste exercício, o programa solicita ao usuário um número e exibe a tabuada desse número de 1 a 10, utilizando um laço `for`.

* Exercício 3: Cálculo de Fatorial
O programa solicita um número inteiro positivo ao usuário e calcula o fatorial desse número utilizando um laço `while`. O fatorial de um número `n` é o produto de todos os números inteiros de 1 até `n`.

* Exercício 4: Conversor de Temperaturas
Este exercício cria um menu interativo para conversão de temperaturas:
1. Celsius para Fahrenheit.
2. Fahrenheit para Celsius.
O menu continua ativo até o usuário escolher a opção de sair (opção 3).

## Explicação Detalhada dos Exercícios 9 e 10 

### Exercício 9: Jogo da Adivinhação  
**Descrição Funcional:**  
Implementa um jogo onde o usuário tenta adivinhar um número aleatório entre 1 e 100, recebendo dicas ("MAIOR" ou "MENOR") a cada tentativa.  

**Passo a Passo Lógico:**  
1. Gera um número secreto com `Random.Next(1, 101)`.  
2. Em um loop `do-while`, solicita palpites até o acerto:  
   - Valida o input com `int.TryParse`.  
   - Incrementa o contador de tentativas.  
   - Fornece feedback comparando o palpite com o número secreto.  
3. Ao acertar, exibe o número de tentativas utilizadas.  

**Estruturas Utilizadas:**  
- `Random` para aleatoriedade.  
- `do-while` para garantir pelo menos uma tentativa.  
- `if-else` para lógica de comparação.  

**Justificativas:**  
- `Random` é a classe padrão do C# para geração de números aleatórios.  
- `do-while` é ideal para loops que devem executar pelo menos uma vez.  

### Exercício 10: Lista de Tarefas (To-Do List)  
**Descrição Funcional:**  
Permite ao usuário adicionar tarefas, marcá-las como concluídas e visualizar a lista completa.  

**Passo a Passo Lógico:**  
1. Usa duas listas paralelas:  
   - `List<string>` para nomes das tarefas.  
   - `List<bool>` para status (true = concluída, false = pendente).  
2. Menu interativo com `switch-case`:  
   - **Adicionar:** Recebe input e adiciona às listas.  
   - **Concluir:** Lista tarefas pendentes e atualiza o status.  
   - **Listar:** Exibe todas com prefixos `[PENDENTE]` ou `[CONCLUÍDA]`.  

**Estruturas Utilizadas:**  
- `List<string>` e `List<bool>` para armazenamento.  
- `switch-case` para navegação no menu.  
- `for` para iteração na exibição.  

**Justificativas:**  
- Listas paralelas simplificam o gerenciamento sem necessidade de classes.  
- `switch-case` organiza claramente as funcionalidades do menu.  
