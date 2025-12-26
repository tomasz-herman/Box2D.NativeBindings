using System.Runtime.InteropServices;

namespace Box2D.Base;

public struct Version
{
    public int Major;
    public int Minor;
    public int Revision;

    [DllImport("box2d",  EntryPoint = "b2GetVersion")]
    public static extern Version GetVersion();

    public override string ToString() => $"{Major}.{Minor}.{Revision}";
}