namespace tl2_tp09_2023_VelizMiguelC;

public interface ITableroRepository
{
    public void addTablero(Tablero Tab);
    public void PutTablero(int idTab, Tablero Tab);
    public Tablero GetTablero(int idTab);
    public List<Tablero> GetTableros();
    public  List<Tablero> GetTableros(int idUsu);
    public void DeleteTablero(int idTab);
}