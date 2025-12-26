using System.Numerics;
using Box2D;
using Box2D.Collision;
using Box2D.Types;
using Box2D.Types.Bodies;
using Box2D.Types.Shapes;
using Version = Box2D.Base.Version;

Console.WriteLine($"Box2D Version: {Version.GetVersion()}");

WorldDef worldDef = WorldDef.Default();
worldDef.Gravity = new Vector2(0, -10f);

using World world = new World(ref worldDef);

// Ground
BodyDef groundBodyDef = BodyDef.Default();
groundBodyDef.Position = new Vector2(0.0f, -10.0f);
Body groundBody = new Body(world.Id, ref groundBodyDef);

Polygon groundBox = Polygon.MakeBox(50.0f, 10.0f);
ShapeDef groundShapeDef = ShapeDef.Default();
Shape groundShape = new Shape(groundBody.Id, ref groundShapeDef, ref groundBox);

// Dynamic Body
BodyDef bodyDef = BodyDef.Default();
bodyDef.Type = BodyType.DynamicBody;
bodyDef.Position = new Vector2(0.0f, 4.0f);
bodyDef.AngularVelocity = 20.0f;
Body body = new Body(world.Id, ref bodyDef);

Polygon dynamicBox = Polygon.MakeBox(1.0f, 1.0f);
ShapeDef shapeDef = ShapeDef.Default();
shapeDef.Density = 1.0f;
shapeDef.Material.Friction = 0.3f;
Shape bodyShape = new Shape(body.Id, ref shapeDef, ref dynamicBox);

// Simulation
float timeStep = 1.0f / 60.0f;
int subStepCount = 4;

Console.WriteLine("Starting simulation...");
for (int i = 0; i < 1000; ++i)
{
    world.Step(timeStep, subStepCount);
    Vector2 position = body.GetPosition();
    var rotation = body.GetRotation();
    float angle = MathF.Atan2(rotation.Sin, rotation.Cos);
    
    Console.WriteLine($"Step {i}: Pos={position} Angle={angle:F3}");
}

Console.WriteLine("Simulation finished.");