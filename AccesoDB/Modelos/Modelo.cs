using System.ComponentModel.DataAnnotations;

namespace AccesoDB.Modelos;

public class Modelo
{
    [Key]
    public required string Id { get; set; }
}