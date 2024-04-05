﻿using Microsoft.Extensions.Logging;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace api_web_services_dose_certa.Models
{
    public class Note
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string? Id { get; set; }

        public string Content { get; set; }

        public DateTime CreationDate { get; set; } = DateTime.UtcNow;

<<<<<<< HEAD
         public string? IdUserAgente { get; set; }

        public string? IdUserPaciente { get; set; }

        public User? UserAgente { get; set; }

        public User? UserPaciente { get; set; }
        
=======
        public string? IdUserAgente { get; set; }
        public string? IdUserPaciente { get; set; }

        // Propriedade de Navegação (opcional)
        public User? UserAgente { get; set; }
        public User? UserPaciente { get; set; }
>>>>>>> 74622f8e23693b9b99ab1df88ea87f2379454196

    }
}
