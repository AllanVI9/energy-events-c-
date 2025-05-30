namespace EnergyEvents.Services
{
    public class LoginService
    {
        private const string UsuarioCorreto = "admin";
        private const string SenhaCorreta = "1234";

        public bool Autenticar()
        {
            while (true)
            {
                Console.Write("Usuário: ");
                string usuario = Console.ReadLine();

                Console.Write("Senha: ");
                string senha = LerSenha();

                if (usuario == UsuarioCorreto && senha == SenhaCorreta)
                {
                    Console.WriteLine("\nLogin efetuado com sucesso!\n");
                    return true;
                }

                Console.WriteLine("\nUsuário ou senha incorretos. Tente novamente.\n");
            }
        }

        private string LerSenha()
        {
            string senha = "";
            ConsoleKeyInfo tecla;

            do
            {
                tecla = Console.ReadKey(true);

                if (tecla.Key != ConsoleKey.Backspace && tecla.Key != ConsoleKey.Enter)
                {
                    senha += tecla.KeyChar;
                    Console.Write("*");
                }
                else if (tecla.Key == ConsoleKey.Backspace && senha.Length > 0)
                {
                    senha = senha.Substring(0, senha.Length - 1);
                    Console.Write("\b \b");
                }
            } while (tecla.Key != ConsoleKey.Enter);

            Console.WriteLine();
            return senha;
        }
    }
}
