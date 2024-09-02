using LiteDB;

namespace Modelos;
public class Vendas : Registro
{
    string produto { get; set; }
    string quantidade { get; set; }
    string lucro { get; set; }
    
    string cliente { get; set; }
    [BsonId]
    public string Id { get; set; }
    
}