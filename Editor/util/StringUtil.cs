using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor.util
{
    class StringUtil
    {
        /**
         * 判断字符串是否为空
         */
        public static Boolean isEmpty(string str)
        {
            int length = 0;
            if (null != str)
            {
                length = str.Length;
            }
            return 0 == length ? true : false;
        }

        /**
         * 判断字符串不为空
         * 
         */
        public static Boolean isNotEmpty(string str)
        {
            return !isEmpty(str);
        }
    }
}
