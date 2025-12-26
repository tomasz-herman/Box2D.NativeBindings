using System.Numerics;

namespace Box2D.Collision;

public struct ToiOutput
{
    public ToiState State;
    public Vector2 Point;
    public Vector2 Normal;
    public float Fraction;
}