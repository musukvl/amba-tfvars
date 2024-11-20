using System.Collections.Generic;

namespace Amba.TfVars.Model;

public interface ITfVarsNodeEnumerable<T> : IEnumerable<T> where T : TfVarsNode
{
}