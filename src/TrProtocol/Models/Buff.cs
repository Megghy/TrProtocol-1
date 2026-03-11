namespace TrProtocol.Models;

public partial struct Buff
{
    public ushort BuffType;
    public short BuffTime;
    
    public override readonly string ToString()
    {
        var seconds = BuffTime / 60f;
    
        return $"{{Buff ID: {BuffType}, Time: {BuffTime} ({seconds:F1}s)}}";
    }
}
