namespace Amba.TfVars.Serializer;

public class SerializerOptions
{
    /// <summary>
    /// Indent the tfvars file
    /// </summary>
    public bool Indent { get; set; } = true;
    
    /// <summary>
    ///  The size of the indent
    /// </summary>
    public int IndentSize { get; set; } = 4;
    
    /// <summary>
    ///  Include a trailing comma in the list
    /// </summary>
    public bool IncludeListTrailingComma { get; set; }= false;
    
    

    public static SerializerOptions Default => new();
} 