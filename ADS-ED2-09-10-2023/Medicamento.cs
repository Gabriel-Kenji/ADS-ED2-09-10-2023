namespace ADS_ED2_09_10_2023;

public class Medicamento
{
    private int id;
    private string nome;
    private string laboratorio;
    private Queue<Lote> lotes;

    public int Id
    {
        get => id;
        set => id = value;
    }

    public string Nome
    {
        get => nome;
        set => nome = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Laboratorio
    {
        get => laboratorio;
        set => laboratorio = value ?? throw new ArgumentNullException(nameof(value));
    }

    public Queue<Lote> Lotes
    {
        get => lotes;
        set => lotes = value ?? throw new ArgumentNullException(nameof(value));
    }

    public Medicamento()
    {
    }

    public Medicamento(int id, string nome, string laboratorio)
    {
        this.id = id;
        this.nome = nome;
        this.laboratorio = laboratorio;
        this.lotes = new Queue<Lote>();
    }

    public int qtdeDisponivel()
    {
        int qtde = 0;
        foreach (var lote in lotes)
        {
            qtde = qtde + lote.Qtde;
        }
        return qtde;
    }

    public void comprar(Lote lote)
    {
        lotes.Enqueue(lote);
    }

    public bool vender(int qtde)
    {
        if (this.qtdeDisponivel() >= qtde)
        {
            Console.WriteLine(this.qtdeDisponivel() + "-" +  qtde);
            int qtdes = qtde;
            for (int i = 0; i <= 1; i++)
            {
                Console.WriteLine("cc" + qtdes);
                if (lotes.Peek().Qtde == qtdes)
                {
                    Console.WriteLine("cc" + qtdes);
                    lotes.Dequeue();
                    qtdes = 0;
                }
                else if (lotes.Peek().Qtde < qtdes)
                {
                    Console.WriteLine("bb" + qtdes);
                    qtdes = qtdes - lotes.Peek().Qtde;
                    lotes.Dequeue();
                }
                else if (lotes.Peek().Qtde > qtdes)
                {
                    Console.WriteLine("aa" + qtdes);
                    lotes.Peek().Qtde = lotes.Peek().Qtde - qtdes;
                    qtdes = 0;
                }

                if (qtdes == 0)
                {
                    i = 100;
                }
            }
            return true;
        }
        return false;
    }

    public override string ToString()
    {
        return this.id + "-" + this.nome + "-" + this.laboratorio + "-" + this.qtdeDisponivel();
    }
}