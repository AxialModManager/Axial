using System.Runtime.InteropServices;

namespace Axial.Backend;

public class AxialBackend
{
    private static AxialBackend? s_instance;
    
    public static AxialBackend Create()
    {
        
        return s_instance;
    }
    
    public AxialBackend(Platform platform)
    {
        
    }
    
    public static AxialBackend Instance { get; }
}