using Gaia.NET.Gaia.API.Engine.Scene;

SceneWindow window = new SceneWindow();
if (!window.CreateInitialization())
    Console.WriteLine("Proccess of creating window failed");
window.ExecuteEventHandler();
Console.ReadLine();
