namespace Amba.TfVars.Model;

public abstract class CollectionNode : TfVarsNode
{
    /// <summary>
    /// Determines if the collection written as a one-liner in tfvars file.
    /// For example:
    /// ```
    ///   users = [1, 2, 3]
    /// ```
    /// </summary>
    public bool OneLine { get; set; } = false;
    public string? CommentsAfter { get; set; } = null;

    public CollectionNode()
    {
    }
    
    public CollectionNode(bool oneLine)
    {
        OneLine = oneLine;
    }

}