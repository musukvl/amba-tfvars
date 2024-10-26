using System.Collections.Generic;
using System.Text;

namespace Amba.TfVars.Model;

public class ListNode : IVariableExpressionNode
{
    public List<IVariableExpressionNode> Values { get; set; } = new List<IVariableExpressionNode>();
}