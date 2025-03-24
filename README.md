# Jogo dos Dados

![](https://i.imgur.com/VPDE6NF.gif)
- O jogo dos dados consiste em uma disputa entre o usuario e o computador para chegar ao fim do tabuleiro (posição 30).

## - Funcionalidades:

- **Interação com o usuario** : O jogo permite o usuario participar diretamente do jogo como se realmente estivesse jogando um dado.
- **Condição de Vitória ou Derrota** : O jogo consegue perceber se o usuario ganhou ou perdeu o jogo.
- **Condições extras**: O jogo traz algumas condições em cas especificas como recuar duas casas ou andar tres casas extras.


## - Como usar?
1. Clone o repósitório ou baixe o código fonte
2. Abra o terminal ou o prompt de comando e navegue até a pasta raiz
3. Utilize o comando abaixo para restaurar as dependências do projeto.

```
dotnet restore
```

4. Em seguida, complete uma solução utilizando o comando

```
dotnet build --configuration Release
```

5. Para executar o projeto compilado em tempo real:
```
dotnet run --JogoDosDados.ConsoleApp
```

6.Para executar o arquivo compilado, navegue até a pasta ./JogoDosDados.ConsoleApp/bin/Release/net8.0/e execute o arquivo:
```
JogoDosDados.ConsoleApp.exe
```

### Requisitos:
- .NET SDK (recomendado .NET 8.0 ou superior) para construção e execução do projeto.