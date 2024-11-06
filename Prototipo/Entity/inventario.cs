public class Inventario{
    public int id {get;set;}
    public DateTime fechaMovimiento {get; set;}
    public int idProducto {get; set;}
    public string TipoMovimiento {get; set;}
    public decimal ingreso {get; set;}
    public decimal salida {get; set;}
    public decimal stock {get; set;}
    public string obs {get; set;}
}