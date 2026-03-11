using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using TrProtocol.Interfaces;

namespace TrProtocol.Models;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct ItemData : IEquatable<ItemData>, IPackedSerializable
{
    public short ItemID;
    public byte Prefix;
    public short Stack;

    public readonly bool Equals(ItemData other) =>
        ItemID == other.ItemID && Prefix == other.Prefix && Stack == other.Stack;
    public override readonly bool Equals([NotNullWhen(true)] object? obj) => obj is ItemData data && Equals(data);

    public override readonly int GetHashCode() => HashCode.Combine(ItemID, Prefix, Stack);

    public static bool operator ==(ItemData left, ItemData right) => left.Equals(right);

    public static bool operator !=(ItemData left, ItemData right) => !left.Equals(right);
    
    public override readonly string ToString()
    {
        if (ItemID <= 0) return "[Empty Item]";
        var stackPrefix = Stack > 1 ? $"{Stack}x " : "";
        var prefixInfo = Prefix > 0 ? $", Prefix {Prefix}" : "";
        
        return $"{stackPrefix}[ID {ItemID}{prefixInfo}]";
    }
}
