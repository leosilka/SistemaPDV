namespace SistemaPDV.Itens;

internal class DadosItem
{
    public DadosItem(int codigoItem, string nomeItem, float precoItem, int estoqueItem)
    {
        CodigoItem = codigoItem;
        NomeItem = nomeItem;
        PrecoItem = precoItem;
        EstoqueItem = estoqueItem;
    }

    public int CodigoItem { get; set; }
    public string NomeItem { get; set; }
    public float PrecoItem { get; set; }
    public int EstoqueItem { get; set; }
}
