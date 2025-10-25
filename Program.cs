namespace RSChallenge
{
    class Program
    {
        static void Main()
        {
            SextoExercicio();
            
        }

        static void PrimeiroExercicio()
        {
            Console.Write("Digite um nome:");
            string? inputName = Console.ReadLine();
            Console.Write("Digite uma mensagem de boas vindas:");
            string? inputMensagem = Console.ReadLine();
            Console.WriteLine($"Nome: {inputName} - {inputMensagem}");

        }

        static void SegundoExercicio()
        {
            Console.Write("Digite o seu nome: ");
            string? inputPrimeiroNome = Console.ReadLine();
            Console.Write("Digite o seu sobrenome: ");
            string? inputSegundoNome = Console.ReadLine();

            Console.WriteLine("Olá " + inputPrimeiroNome + inputSegundoNome);
        }

        static void TerceiroExercicio()
        {
            Console.WriteLine("Digite um número:");
            double inputPrimeiroNumero = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite outro número:");
            double inputSegundoNumero = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Escolha uma operação matemática: 1 - Somar | 2 - Subtrair | 3 - Multiplicar | 4 - Dividir ");
            int opcao;
            if (int.TryParse(Console.ReadLine(), out opcao))
            {
                if (opcao >= 1 && opcao <= 4)
                {
                    switch (opcao)
                    {
                        case 1:
                            double total = inputPrimeiroNumero + inputSegundoNumero;
                            Console.WriteLine(total);

                            break;
                        case 2:
                            if (inputPrimeiroNumero > inputSegundoNumero)
                            {
                                double totalS = inputPrimeiroNumero - inputSegundoNumero;
                                Console.WriteLine(totalS);
                            }
                            else
                            {
                                double totalS = inputSegundoNumero - inputPrimeiroNumero;
                                Console.WriteLine(totalS);
                            }
                            break;
                        case 3:
                            double totalM = inputPrimeiroNumero * inputSegundoNumero;
                            Console.WriteLine(totalM);
                            
                            break;
                        case 4:
                            double totalD = inputPrimeiroNumero / inputSegundoNumero;
                            Console.WriteLine(totalD);
                            break;
                    }
                }
                else
                {
                    throw new Exception("Escolha uma opção válida!");
                }
            }
        }

        static void QuartoExercicio()
        {
            Console.Write("Digite uma palavra:");
            string? inputPalavra = Console.ReadLine();
            int quantidade = inputPalavra.Length;
            Console.WriteLine(quantidade);
        }

        static void QuintoExercicio()
        {
            Console.WriteLine("Digite a placa do seu veículo:");
            string placa = Console.ReadLine().ToUpper();

            if (IsPlacaValida(placa))
            {
                Console.WriteLine("Placa válida!");
            }
            else
            {
                Console.WriteLine("Placa inválida!");
            }

            static bool IsPlacaValida(string placa)
            {
                if (placa.Length != 7)
                    return false;
                for (int i = 0; i < 3; i++)
                {
                    if (!char.IsLetter(placa[i]))
                        return false;
                }

                for (int i = 3; i < 7; i++)
                {
                    if (!char.IsDigit(placa[i]))
                        return false;
                }

                return true;
            }
        }

        static void SextoExercicio()
        {
            Console.WriteLine("Escolha um tipo de formatação para exibir a data: 1 - FORMATO COMPLETO | 2 - APENAS DATA | 3 - APENAS HORA | 4 - DATA COM MÊS POR EXTENSO");
            int opcao;
            if (int.TryParse(Console.ReadLine(), out opcao))
            {
                if (opcao >= 1 && opcao <= 4)
                {
                    switch (opcao)
                    {
                        case 1: 
                            DateTime data = DateTime.Now;
                            Console.WriteLine(data);
                            break;    
                        case 2: 
                            DateTime dataDMY = DateTime.Now;
                            Console.WriteLine(dataDMY.ToString("dd/MM/YYYY"));
                            break;    
                        case 3: 
                            DateTime dataHora = DateTime.Now;
                            Console.WriteLine(dataHora.ToString("HH"));
                            break;    
                        case 4: 
                            DateTime dataPorExtenso = DateTime.Now;
                            Console.WriteLine(dataPorExtenso.ToLongDateString());
                            break;    
                    }
                    
                }
            }
        }
    }    
}
