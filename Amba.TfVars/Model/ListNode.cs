using System.Collections.Generic;
using System.Text;

namespace Amba.TfVars.Model
{
    public class ListNode : TfVarsNode
    {
        public List<TfVarsNode> Values { get; set; } = new List<TfVarsNode>();
    
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("[");
            foreach (var value in Values)
            {
                sb.AppendLine(value.ToString());
            }
            sb.AppendLine("]");
            return sb.ToString();
        }
    }
}