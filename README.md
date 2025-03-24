# Jogo dos Dados

![](https://i.imgur.com/VPDE6NF.gif)
- O jogo dos dados consiste em uma disputa entre o usuario e o computador para chegar ao fim do tabuleiro (posi��o 30).

## - Funcionalidades:

- **Intera��o com o usuario** : O jogo permite o usuario participar diretamente do jogo como se realmente estivesse jogando um dado.
- **Condi��o de Vit�ria ou Derrota** : O jogo consegue perceber se o usuario ganhou ou perdeu o jogo.
- **Condi��es extras**: O jogo traz algumas condi��es em cas especificas como recuar duas casas ou andar tres casas extras.


## - Como usar?
1. Clone o rep�sit�rio ou baixe o c�digo fonte
2. Abra o terminal ou o prompt de comando e navegue at� a pasta raiz
3. Utilize o comando abaixo para restaurar as depend�ncias do projeto.

```
dotnet restore
```

4. Em seguida, complete uma solu��o utilizando o comando

```
dotnet build --configuration Release
```

5. Para executar o projeto compilado em tempo real:
```
dotnet run --JogoDosDados.ConsoleApp
```

6.Para executar o arquivo compilado, navegue at� a pasta ./JogoDosDados.ConsoleApp/bin/Release/net8.0/e execute o arquivo:
```
JogoDosDados.ConsoleApp.exe
```

### Requisitos:
- .NET SDK (recomendado .NET 8.0 ou superior) para constru��o e execu��o do projeto.