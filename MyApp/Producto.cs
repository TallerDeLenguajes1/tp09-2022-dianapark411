class Producto{
    public string Nombre {get;set;}
    public DateTime FechaVencimiento {get;set;}
    public float Precio {get;set;}
    private string Tamanio {get;set;}

    public Producto(){
        string[] listaNombres = {"Caramelos", "Gaseosa", "Leche", "Pollo", "Fideos", "Arroz", "Mayonesa", "Pan", "Cereales"};
        string[] listaTam = {"Pequenio", "Mediano", "Grande"};
        Random rnd = new Random();

        Nombre = listaNombres[rnd.Next(0, listaNombres.Length)];
        FechaVencimiento = RandomDay();
        Precio = rnd.Next(1000, 5000);
        Tamanio = listaTam[rnd.Next(0, 3)];
    }

    public override string ToString()
    {
        string cadena = "";

        cadena += $"Nombre: {Nombre}\n";
        cadena += $"Fecha de vencimiento: {FechaVencimiento.ToString("dd/MM/yyyy")}\n";
        cadena += $"Precio: {Precio}\n";
        cadena += $"Tamaño: {Tamanio}";

        return cadena;
    }

    public DateTime RandomDay() {
        //Hago una fecha aleatoria entre 2022 y 2024 para el vencimiento
        DateTime fechaMax = new DateTime(2024, 1, 1);
        DateTime start = new DateTime(2022, 1, 1); 
        Random gen = new Random(); 
        int range = (fechaMax - start).Days; 
        return start.AddDays(gen.Next(range)); 
    }

}