using System.Collections.Generic;
using System.Linq;

namespace Amba.TfVars.Model
{
    public class MapNode : ITfVarsNode
    {
        public List<MapPairNode> Values { get; private set; } = new List<MapPairNode>();

        //index operator
        public MapPairNode? this[string key]
        {
            get
            {
                return Values.FirstOrDefault(x => x.Key == key);
            }
            set
            {
                for (int i = 0; i < Values.Count; i++)
                {
                    if (Values[i].Key == key)
                    {
                        Values[i] = value;
                        return;
                    }
                }
                Values.Add(value);
            }
        }
    }
}