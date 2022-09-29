<h1 align="center">
    Avaliação 01
</h1>

<p align="center">Projeto desenvolvido durante a avaliação da disciplina <strong> Programação Orientada a Objetos</strong>.</p>

<hr>

## Sobre a avaliação 📚

Considerando a classe abaixo:

```C# 
public class User
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
} 
```

Crie uma aplicação web (API) com as seguintes funcionalidades:

1) Endpoint `http://localhost:1234/user` que seja capaz de tratar requisições GET e POST. 
A requisição GET deverá retornar uma lista com todos os usuários criados numa lista 
de User. O método POST deverá realizar o cadastro de um novo User na lista.
GET deverá retornar o status 200. Já o post, deverá retornar o status de criação, 
juntamente com os dados do usuário criado.

2) Endpoint `http://localhost:1234/login` que seja capaz de tratar requisições GET. Neste 
endpoint, o usuário deverá passar os parâmetros email e senha e ter como retorno as 
possíveis respostas:

    a. 404 (caso o usuário não seja encontrado com o email e senha fornecidos)

    b. 200 (caso o usuário seja encontrado. Deverá retornar os dados do usuário

<hr>

##  Referências 📌

🔹 Projeto desenvolvido durante prova, do curso de Análise e desenvolvimento de sistemas na Fatec Rio Preto 

🔹 Créditos ao professor da disciplina [Henrique Dezani](https://github.com/henriquedezani) 


<hr>

## Tecnologias 🚀 

Esse projeto foi desenvolvido com as seguintes tecnologias:

<div style="display: inline_block">
	<img align="center" alt="Vivi-CSHARP" height="40" width="50" src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/csharp/csharp-original.svg">
    <img align="center" alt="Vivi-CSHARP" height="40" width="50" src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/visualstudio/visualstudio-plain.svg">
          
</div>

<hr> 

### Feito com ♥ by [VivianNadoti](https://github.com/vinadoti)
