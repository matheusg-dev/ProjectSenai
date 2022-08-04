/*using ProjectSenai.Model;

Usuario usuario = new Usuario();
usuario.Nome = "Matheusinho do grau";
usuario.Senha = "matheusinho123";

ExemploSenaiContext context = new ExemploSenaiContext();
context.Add(usuario);
context.SaveChanges();*/


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




