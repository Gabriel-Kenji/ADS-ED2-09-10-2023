namespace ADS_ED2_09_10_2023;

public class Lote
{
    private int id;
    private int qtde;
    private DateTime venc;

    public int Id
    {
        get => id;
        set => id = value;
    }

    public int Qtde
    {
        get => qtde;
        set => qtde = value;
    }

    public DateTime Venc
    {
        get => venc;
        set => venc = value;
    }

    public Lote()
    {
        this.id = 0;
        this.qtde = 0;
        this.venc = new DateTime(0, 0, 0);
    }

    public Lote(int id, int qtde, DateTime venc)
    {
        this.id = id;
        this.qtde = qtde;
        this.venc = venc;
    }

    public override string ToString()
    {
        return this.id + " - " + this.qtde + " - " + this.venc;
    }
}