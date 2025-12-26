# Box2DSharp

A high-performance .NET 8 wrapper for the [Box2D](https://box2d.org/) physics engine (v3).

Box2DSharp provides direct C# bindings to the modern Box2D C API, utilizing the new Handle/ID-based architecture (`WorldId`, `BodyId`, `ShapeId`) for improved performance and memory management.

## Features

*   **Box2D v3 API:** targets the latest iteration of Box2D with the new C-style API.
*   **High Performance:** Uses `unsafe` code and P/Invoke with minimal overhead.
*   **Zero-Allocation:** Heavy usage of `ref` structs and stack allocation to minimize GC pressure.
*   **Modern .NET:** Built for .NET 8.0+.

## Prerequisites

*   [.NET 8.0 SDK](https://dotnet.microsoft.com/download)
*   **Box2D Native Library:** You must provide the compiled `box2d` shared library (`box2d.dll`, `libbox2d.so`, or `libbox2d.dylib`) accessible in your runtime path (e.g., copied to the output directory).

## Getting Started

### Installation

1.  Clone the repository:
    ```bash
    git clone https://github.com/your-username/Box2DSharp.git
    ```
2.  Ensure you have the native Box2D binary available.

### Basic Usage

The API mirrors the C-style Box2D v3 API but adapted for C#.

```csharp
using System.Numerics;
using Box2D;
using Box2D.Collision;
using Box2D.Types;
using Box2D.Types.Bodies;
using Box2D.Types.Shapes;

// 1. Initialize the World
WorldDef worldDef = WorldDef.Default();
worldDef.Gravity = new Vector2(0, -10f);

using World world = new World(ref worldDef);

// 2. Create a Ground Body
BodyDef groundBodyDef = BodyDef.Default();
groundBodyDef.Position = new Vector2(0.0f, -10.0f);
Body groundBody = new Body(world.Id, ref groundBodyDef);

// 3. Add a Shape to the Ground
Polygon groundBox = Polygon.MakeBox(50.0f, 10.0f);
ShapeDef groundShapeDef = ShapeDef.Default();
Shape groundShape = new Shape(groundBody.Id, ref groundShapeDef, ref groundBox);

// 4. Create a Dynamic Body
BodyDef bodyDef = BodyDef.Default();
bodyDef.Type = BodyType.DynamicBody;
bodyDef.Position = new Vector2(0.0f, 4.0f);
Body body = new Body(world.Id, ref bodyDef);

// 5. Add Shape to Dynamic Body
Polygon dynamicBox = Polygon.MakeBox(1.0f, 1.0f);
ShapeDef shapeDef = ShapeDef.Default();
shapeDef.Density = 1.0f;
shapeDef.Material.Friction = 0.3f;
Shape bodyShape = new Shape(body.Id, ref shapeDef, ref dynamicBox);

// 6. Step the Simulation
float timeStep = 1.0f / 60.0f;
int subStepCount = 4;

Console.WriteLine("Simulation started...");
for (int i = 0; i < 60; ++i)
{
    world.Step(timeStep, subStepCount);
    Vector2 position = body.GetPosition();
    Console.WriteLine($"Step {i}: Position={position}");
}
```

## Running the Demo

A sample project is provided in `Box2D.Demo`.

```bash
dotnet run --project Box2D.Demo
```

*Note: The demo will fail if the native `box2d` library is not found in the output directory.*

## Architecture

This wrapper differs from previous C# ports (like Box2DX or older Box2DSharp versions) by strictly adhering to the **Handle-based** design of Box2D v3. Instead of managing object lifecycles directly, you manipulate simulation objects via IDs (`BodyId`, `ShapeId`), which ensures memory safety and cache coherence on the native side.
