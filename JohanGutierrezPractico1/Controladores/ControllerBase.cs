namespace JohanGutierrezPractico1.Controladores
{
    public class ControllerBase
    {
        public Datos datos { get; set; }

        public ControllerBase()
        {
            datos = new Datos();
        }
    }
}