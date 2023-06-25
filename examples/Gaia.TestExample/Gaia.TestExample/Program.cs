using Gaia.NET.Engine.Scene;

SceneWindow window = new SceneWindow();
if (!window.CreateInitialization())
    Console.WriteLine("Proccess of creating window failed");
window.ExecuteEventHandler();
Console.ReadLine();
