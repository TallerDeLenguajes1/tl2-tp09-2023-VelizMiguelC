namespace tl2_tp09_2023_VelizMiguelC;

public interface IUsuarioRepository
{
    public void addUsuario(Usuario Usu);
    public void PutUsuario(int id_Usu, Usuario Usu);
    public List<Usuario> ListUsuarios();
    public Usuario GetUsuario(int id_Usu);
    public void DeleteUsuario(int id_Usu);
}

