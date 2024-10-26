using System.Collections.Generic;
using System.Text;

namespace Amba.TfVars.Model
{
    public class ListNode : ITfVarsNode
    {
        public List<ITfVarsNode> Values { get; set; } = new List<ITfVarsNode>();
    }
}