using ProjectSenai.Model;


while(true)
{
 ExemploSenaiContext context = new ExemploSenaiContext();
 Console.WriteLine("O que deseja fazer? 1- login, 2- Registro ou 3 - Sair");
 string num = Console.ReadLine();
 if (num == "1")
 {
    foreach(Usuario usuario in context.Usuarios)
    {
        Console.Clear();
    }
 }
 else if(num == "2")
 {
    Console.Clear();
 }
 else if(num == "3")
{
   Console.Clear();
}
else
    Console.WriteLine("Operação mal sucecida");
}




