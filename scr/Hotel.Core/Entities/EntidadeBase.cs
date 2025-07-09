using Hotel.Core.Utils;

namespace Hotel.Core.Entities;

public class EntidadeBase
{
    public EntidadeBase()
    {
        CreatedAt = DateTimeUtils.NowInBrazil();
        DeletedAt = null;
        DeletedBy = null;
    }
    public DateTime CreatedAt { get; set; } 
    public DateTime? DeletedAt { get; set; } 
    public Guid? DeletedBy { get; set; }  
}