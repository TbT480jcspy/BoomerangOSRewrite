namespace BoomerangOS.Graphics.Rendering;

public interface IRenderer
{
    void Initialize();

    void BeginFrame();

    void EndFrame();

    void Shutdown();
}