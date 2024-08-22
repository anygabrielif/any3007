using LiteDB;

namespace Modelos;
public class Vendas 
{
    string produto { get; set; }
    string quantidade { get; set; }
    string lucro { get; set; }
    
    string cliente { get; set; }
    [BsonId]
    string id { get; set; }
    
}