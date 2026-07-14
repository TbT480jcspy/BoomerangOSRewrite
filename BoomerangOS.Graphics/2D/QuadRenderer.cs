using BoomerangOS.Graphics.Math;
using Silk.NET.OpenGL;

namespace BoomerangOS.Graphics._2D;


public class QuadRenderer
{
    private readonly GL _gl;
    private readonly Camera2D _camera;

    private uint _vao;
    private uint _vbo;


    public QuadRenderer(GL gl, Camera2D camera)
    {
        _gl = gl;
        _camera = camera;

        Initialize();
    }


    private unsafe void Initialize()
    {
        float[] vertices =
        {
        -0.5f, -0.5f,
         0.5f, -0.5f,
         0.5f,  0.5f,

        -0.5f, -0.5f,
         0.5f,  0.5f,
        -0.5f,  0.5f
    };


        _vao = _gl.GenVertexArray();
        _vbo = _gl.GenBuffer();


        _gl.BindVertexArray(_vao);

        _gl.BindBuffer(
            BufferTargetARB.ArrayBuffer,
            _vbo
        );


        fixed (float* v = vertices)
        {
            _gl.BufferData(
                BufferTargetARB.ArrayBuffer,
                (nuint)(vertices.Length * sizeof(float)),
                v,
                BufferUsageARB.StaticDraw
            );
        }
    }


    public void Draw(
    float x,
    float y,
    float width,
    float height)
    {

    }
}