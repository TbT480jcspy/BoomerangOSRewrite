using Silk.NET.OpenGL;
using Silk.NET.Maths;

namespace BoomerangOS.Graphics.Shaders;

public class Shader
{
    private readonly GL _gl;

    public uint Handle { get; private set; }


    public Shader(GL gl, string vertex, string fragment)
    {
        _gl = gl;

        uint vertexShader = Compile(
            ShaderType.VertexShader,
            vertex
        );

        uint fragmentShader = Compile(
            ShaderType.FragmentShader,
            fragment
        );


        Handle = _gl.CreateProgram();

        _gl.AttachShader(
            Handle,
            vertexShader
        );

        _gl.AttachShader(
            Handle,
            fragmentShader
        );

        _gl.LinkProgram(Handle);


        _gl.DeleteShader(vertexShader);
        _gl.DeleteShader(fragmentShader);
    }


    private uint Compile(
        ShaderType type,
        string source)
    {
        uint shader = _gl.CreateShader(type);

        _gl.ShaderSource(
            shader,
            source
        );

        _gl.CompileShader(shader);

        return shader;
    }

    public unsafe void SetMatrix4(
    string name,
    Matrix4X4<float> matrix)
    {
        int location = _gl.GetUniformLocation(
            Handle,
            name
        );

        _gl.UniformMatrix4(
            location,
            1,
            false,
            (float*)&matrix
        );
    }


    public void Use()
    {
        _gl.UseProgram(Handle);
    }
}