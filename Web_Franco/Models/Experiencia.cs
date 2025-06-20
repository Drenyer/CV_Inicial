namespace Web_Franco.Models
{
    public class Experiencia
    {
        public string Periodo { get; set; } = "Ene - Feb 2025";
        public string Cargo { get; set; } = "Practicante de Desarrollo de Software";
        public string Empresa { get; set; } = "GRUPO MOSS, Arequipa";
        public List<string> Implementaciones { get; set; } = new List<string>
        {
            "Desarrollé un aplicativo web para gestión de eventos deportivos utilizando:",
            "CRUD completo para administración de participantes",
            "API REST para integración con sistemas externos",
            "AWS (EC2 y S3) para despliegue y almacenamiento"
        };
        public List<string> Logros { get; set; } = new List<string>
        {
            "Implementación de un dashboard analítico que redujo los tiempos de procesamiento de datos en un 50%",
            "Optimización del flujo de gestión de participantes, simplificando el registro y seguimiento"
        };
    }
}