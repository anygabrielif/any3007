using LiteDB;

namespace Modelos;

public class Materiaprima:Registro
{


    public string Nome{ get; set; }
      public string Telefone{ get; set; }
     public string Endereço{ get; set; }
     public string Quantidade{ get; set; }

      [BsonId]
      public int ID { get; set; }
}