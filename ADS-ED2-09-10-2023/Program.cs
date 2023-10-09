// See https://aka.ms/new-console-template for more information

using ADS_ED2_09_10_2023;

Medicamentos medicamentos = new Medicamentos();

int num = 100;
while (num > 0)
{
    int codigo = 0;
    int tombo = 0;
    Console.WriteLine("-------------------------------------------------------------");
    Console.WriteLine("                 0 - Sair");
    Console.WriteLine("                 1 - Cadastrar medicamento");
    Console.WriteLine("                 2 - Consultar medicamento (sintético)");
    Console.WriteLine("                 3 - Consultar medicamento (analítico)");
    Console.WriteLine("                 4 - Comprar medicamento");
    Console.WriteLine("                 5 - Vender medicamento");
    Console.WriteLine("                 6 - Listar medicamentos");
    Console.WriteLine("-------------------------------------------------------------");
    Console.Write("Digite uma opção desejada: ");
    num = Int32.Parse(Console.ReadLine());
    switch (num)
    {
        case 0:
            Console.WriteLine("SAINDO...");
            break;
        case 1:
            Console.Write("Digite o codigo do medicamento: ");
            codigo = Int32.Parse(Console.ReadLine());
            Console.Write("Digite o nome do medicamento: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o laboratorio do medicamento: ");
            string laboratorio = Console.ReadLine();
            
            medicamentos.adicionar(new Medicamento(codigo, nome, laboratorio));

            break;
        case 2:
            Console.Write("Digite o codigo do medicamento: ");
            codigo = Int32.Parse(Console.ReadLine());
            Medicamento medi = new Medicamento(codigo, "", "");

            Medicamento medicamento = medicamentos.pesquisar(medi);

            if (medicamento != null)
            {
                Console.WriteLine("Codigo: " + medicamento.Id);
                Console.WriteLine("Nome: " + medicamento.Nome);
                Console.WriteLine("Laboratorio: " + medicamento.Laboratorio);
                Console.WriteLine("Total medicamentos: " + medicamento.qtdeDisponivel());

            }
            else
            {
                Console.WriteLine("Livro não encontrado");
            }
            
            break;
        case 3:
            Console.Write("Digite o codigo do medicamento: ");
            codigo = Int32.Parse(Console.ReadLine());
            Medicamento medic = new Medicamento(codigo, "", "");

            Medicamento medicament = medicamentos.pesquisar(medic);

            if (medicament != null)
            {
                Console.WriteLine("Codigo: " + medicament.Id);
                Console.WriteLine("Titulo: " + medicament.Nome);
                Console.WriteLine("Autor: " + medicament.Laboratorio);
                Console.WriteLine("Total medicamentos: " + medicament.qtdeDisponivel());
                Console.WriteLine("Lotes: ");
                foreach (var lote in medicament.Lotes)
                {
                    Console.WriteLine("codigo: " + lote.Id);
                    Console.WriteLine("Quantidade: " + lote.Qtde);
                    Console.WriteLine("Data Venc: " + lote.Venc.ToString());
                }
            }
            else
            {
                Console.WriteLine("Medicamento não encontrado");
            }
            break;
        case 4:
            Console.Write("Digite o codigo do medicamento: ");
            codigo = Int32.Parse(Console.ReadLine());
            Medicamento medis = new Medicamento(codigo, "", "");

            Medicamento medicaments = medicamentos.pesquisar(medis);
            
            Console.Write("Digite o codigo do lote: ");
            codigo = Int32.Parse(Console.ReadLine());
            Console.Write("Digite o quantidade do lote: ");
            int qtde = Int32.Parse(Console.ReadLine());
            Console.Write("Digite o dia de vencimento: ");
            int dia = Int32.Parse(Console.ReadLine());
            Console.Write("Digite o mes de vencimento: ");
            int mes = Int32.Parse(Console.ReadLine());
            Console.Write("Digite o ano de vencimento: ");
            int ano = Int32.Parse(Console.ReadLine());
            
            medicaments.comprar(new Lote(codigo, qtde, new DateTime(ano,mes,dia)));
            break;
        case 5:
            Console.Write("Digite o codigo do medicamento: ");
            codigo = Int32.Parse(Console.ReadLine());
            Medicamento medist = new Medicamento(codigo, "", "");

            Medicamento medicamentst = medicamentos.pesquisar(medist);
            Console.Write("Digite o quantidade do lote: ");
            int qtdev = Int32.Parse(Console.ReadLine());
            if (medicamentst.vender(qtdev))
            {
                if (medicamentst.qtdeDisponivel() == 0)
                {
                    medicamentos.deletar(medicamentst);
                }
                Console.WriteLine("Medicamentos vendidos com sucesso");
            }
            else
            {
                Console.WriteLine("Não temos toda essa quantidade de medicamentos!");
            }
            break;
        case 6:
            foreach (var medica in medicamentos.ListaMedicamentos)
            {
                Console.WriteLine(medica.ToString());
            }

            break;
    }
}