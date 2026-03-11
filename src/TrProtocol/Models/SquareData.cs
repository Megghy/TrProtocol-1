using Terraria.ID;
using TrProtocol.Attributes;
using TrProtocol.Interfaces;

namespace TrProtocol.Models;
public partial struct SquareData : IAutoSerializable
{
    public short TilePosX;
    public short TilePosY;
    public byte Width;
    public byte Height;
    public TileChangeType ChangeType;
    [ArraySize(nameof(Width), nameof(Height))]
    public SimpleTileData[,] Tiles;
    
    public override readonly string ToString()
    {
        if (Width == 1 && Height == 1)
        {
            return $"{{(X:{TilePosX}, Y:{TilePosY}) | Type: {ChangeType} | Single Tile}}";
        }
        
        return $"{{({TilePosX}, {TilePosY}) | Size: {Width}x{Height} | Type: {ChangeType}}}";
    }
}
