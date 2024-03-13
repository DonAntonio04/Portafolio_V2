using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Informacion.Api.Models;
 public class Informacion 
 {
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]

    public string Id {get; set;} = string.Empty;
    
    [BsonElement("Nombre")]

    public string Nombre {get; set;} = string.Empty; 
    [BsonElement("Edad")]
    public int Edad {get; set;}

    [BsonElement("Telefono")]
    public double Telefono {get; set;}

    [BsonElement("Carrera")]
    public string Carrera {get; set;} = string.Empty;
    [BsonElement("Gmail")]
    public string Gmail {get; set;} = string.Empty; 
 } 