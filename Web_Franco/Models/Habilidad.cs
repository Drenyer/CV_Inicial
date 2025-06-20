namespace Web_Franco.Models
{
    public class Habilidad
    {
        public string Nombre { get; set; } = "";
        public string Descripcion { get; set; } = "";
        public string Tipo { get; set; } = ""; // "Dura" o "Blanda"
    }

    public static class HabilidadesPredefinidas
    {
        public static List<Habilidad> ObtenerHabilidadesDuras()
        {
            return new List<Habilidad>
            {
                new Habilidad 
                { 
                    Nombre = "Programación", 
                    Descripcion = "Dominio de JavaScript (React, Node.js), Python (Django) y C#. Desarrollo de una app de gestión académica para mi proyecto final. En Incamotors, aplicaría estos conocimientos en el desarrollo de sistemas internos para gestión vehicular y plataformas de atención al cliente.",
                    Tipo = "Dura"
                },
                new Habilidad 
                { 
                    Nombre = "Bases de datos", 
                    Descripcion = "Diseño e implementación de bases SQL (MySQL) y NoSQL (MongoDB). Optimicé consultas para un sistema de reportes en mi pasantía. En Incamotors, utilizaría estas habilidades para optimizar las bases de datos de inventario y registro de clientes, mejorando los tiempos de respuesta.",
                    Tipo = "Dura"
                },
                new Habilidad 
                { 
                    Nombre = "Herramientas", 
                    Descripcion = "Git/GitHub, Docker, AWS (Conceptos básicos). Certificado en Scrum Foundation. En Incamotors, aplicaría estos conocimientos para el control de versiones en proyectos colaborativos, despliegue de aplicaciones y gestión ágil de equipos de desarrollo.",
                    Tipo = "Dura"
                }
            };
        }

        public static List<Habilidad> ObtenerHabilidadesBlandas()
        {
            return new List<Habilidad>
            {
                new Habilidad 
                { 
                    Nombre = "Trabajo en equipo", 
                    Descripcion = "Participé activamente en 3 proyectos grupales durante mi formación, coordinando tareas entre desarrolladores y diseñadores. En Incamotors, aplicaría esta habilidad para colaborar eficientemente con el equipo de desarrollo y otros departamentos en proyectos de software automotriz.",
                    Tipo = "Blanda"
                },
                new Habilidad 
                { 
                    Nombre = "Orientación a resultados", 
                    Descripcion = "Entregué mi proyecto final de carrera 2 semanas antes del plazo, cumpliendo todos los requisitos funcionales. En Incamotors, me enfocaría en desarrollar soluciones que cumplan con los objetivos del negocio en los tiempos establecidos.",
                    Tipo = "Blanda"
                },
                new Habilidad 
                { 
                    Nombre = "Capacidad de aprendizaje rápido", 
                    Descripcion = "Aprendí React.js en 1 mes para implementarlo en mi proyecto de titulación. En Incamotors, aplicaría esta capacidad para asimilar rápidamente las tecnologías y procesos específicos de la industria automotriz.",
                    Tipo = "Blanda"
                }
            };
        }
    }
}