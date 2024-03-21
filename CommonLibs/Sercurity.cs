using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibs
{
    public static class Sercurity
    {
		public static bool HasXssFilterChars(string s)
		{
			if (string.IsNullOrEmpty(s)) return false;

			s = s.ToLower();
			return s.Contains("<") || s.Contains(">") ||
				   s.Contains("%3c") || s.Contains("%3e") ||
				   s.Contains("＜") || s.Contains("＞") ||
				   s.Contains("%ef%bc%9c") || s.Contains("%ef%bc%9e");
		}
	}
}
