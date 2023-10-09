namespace ADS_ED2_09_10_2023;

public class Medicamentos
{
    private List<Medicamento> listaMedicamentos;

    public List<Medicamento> ListaMedicamentos
    {
        get => listaMedicamentos;
        set => listaMedicamentos = value ?? throw new ArgumentNullException(nameof(value));
    }

    public Medicamentos()
    {
        listaMedicamentos = new List<Medicamento>();
    }

    public void adicionar(Medicamento medicamento)
    {
        listaMedicamentos.Add(medicamento);
    }

    public bool deletar(Medicamento medicamento)
    {
        listaMedicamentos.Remove(medicamento);
        return true;
    }   

    public Medicamento pesquisar(Medicamento medicamento)
    {
        foreach (var medica in listaMedicamentos)
        {
            if (medica.Id == medicamento.Id)
            {
                return medica;
            }
        }
        return null;
    }
}