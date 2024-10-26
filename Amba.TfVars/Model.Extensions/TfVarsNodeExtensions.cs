using System.Collections.Generic;
using System.Linq;

namespace Amba.TfVars.Model.Extensions
{
    public static class TfVarsNodeExtensions
    {
        public static Dictionary<string, ITfVarsNode>? ToDictionary(this ITfVarsNode node)
        {
            var map = node.ToMap();
            return map.Values.ToDictionary(x => x.Key, x => x.Value);
        }
        public static MapNode ToMap(this ITfVarsNode node)
        {
            return node as MapNode ?? new MapNode();
        }

        public static ListNode ToList(this ITfVarsNode node)
        {
            return node as ListNode ?? new ListNode();
        }

    }
}