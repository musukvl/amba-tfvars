using System.Collections.Generic;
using System.Text;

namespace Amba.TfVars.Model
{
    public class MapNode : TfVarsNode
    {
        public List<MapPairNode> Values { get; set; } = new List<MapPairNode>();
        
        //index operator
        public MapPairNode this[string key]
        {
            get
            {
                foreach (var value in Values)
                {
                    if (value.Key == key)
                    {
                        return value;
                    }
                }
                return null;
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