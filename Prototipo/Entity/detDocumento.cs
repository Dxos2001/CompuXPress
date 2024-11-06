public class DetDocumento{
    public int id {get; set;}
    public int idDocumento {get; set;}
    public int idProducto {get; set;}
    public decimal valorVenta {get; set;}
    public decimal igv {get; set;}
    public decimal cant {get; set;}
    public decimal montoTotal = (valorVenta + (valorVenta * igv))*cant;
}