using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Indexers
    {
        readonly private Dictionary<string, object> dict =
            new Dictionary<string, object>();

        public object this[string key] {
            get {
                return dict.TryGetValue(key, out object action)
                    ? action : null;
            }
            set {
                dict[key] = value;
            }
        }
    }
}
