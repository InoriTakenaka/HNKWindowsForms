using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HNKWindowsForms.Auxiliary {
    public static class ExtensionMethods {
        public static int SafeParse(this string src) {
            if (int.TryParse(src, out int result))
                return result;
            else
                return 0;
        }
    }
}
