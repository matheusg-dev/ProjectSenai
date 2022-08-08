using System.Collections.Generic;
using System;
using ProjectSenai.Model;
using System.Collections;
using System.IO;
using System.Diagnostics;
using System.Linq;

List<string> Nomes = new List<string>();
Nomes.Add("Matheus");
Nomes.Add("Kleber");
Nomes.Add("Joao");
Nomes.Add("Henrique");
Nomes.Add("Pedro");
Nomes.Add("Jose");
Nomes.Add("Marisa");
Nomes.Add("Paulo");
Nomes.Add("Roberto");
Nomes.Add("Eugenia");
List<string> Senha = new List<string>();
Senha.Add("0");
Senha.Add("1");
Senha.Add("2");
Senha.Add("3");
Senha.Add("4");
Senha.Add("5");
Senha.Add("6");
Senha.Add("7");
Senha.Add("8");
Senha.Add("9");
Senha.Add("!");
Senha.Add("@");
Senha.Add("#");
Senha.Add("$");
Senha.Add("%");
Senha.Add("&");
Senha.Add("/");
Senha.Add("_");

Random rnd = new Random();

var SenhaCompleta = "";
int ListNomesIndex = rnd.Next(Nomes.Count);

   for(int i = 0; i <= 5; i++)
   { 
      SenhaCompleta += Senha[rnd.Next(Senha.Count)];
   }

Console.WriteLine(Nomes[ListNomesIndex]);
Console.WriteLine(SenhaCompleta);

Usuario usuario = new Usuario();
usuario.Nome = Nomes[ListNomesIndex];
usuario.Senha = SenhaCompleta;

Post post = new Post();
post.Momento = DateTime.Now;

Console.WriteLine(post.Momento);

ExemploSenaiContext context = new ExemploSenaiContext();
context.Add(usuario);
context.SaveChanges();


/*
using ProjectSenai.Model;

while(true)
{
 ExemploSenaiContext context = new ExemploSenaiContext();
 Console.WriteLine("O que deseja fazer? 1- login, 2- Registro ou 3 - Sair");
 string num = Console.ReadLine();
 if (num == "1")
 {
   ConsoleWriteLine("Digite seu nome:");
   string nome = Console.ReadLine();

   Usuario expectedUser = null;
    foreach(Usuario usuario in context.Usuarios)
    {
        if(Usuario.Nome == nome)
        {
         expectedUser = usuario;
        }
    }

    if(expectedUser == null)
    {
      ConsoleWriteLine($"Usuário com ID{expectedUser}logado.");

    }

 }
 else if(num == "2")
 {
    Console.Clear();
 }
 else if(num == "3")
{
   break;
}
else
    Console.WriteLine("Operação mal sucecida");
} 
*/



