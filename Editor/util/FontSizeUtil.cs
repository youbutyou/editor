using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor.util
{
    /**
     * 转换字号，仿word
     */
    enum MyFontSize
    {
        初号,
        小初,
        一号,
        小一,
        二号,
        小二,
        三号,
        小三,
        四号,
        小四,
        五号,
        小五,
        六号,
        小六,
        七号,
        八号,

    };
    class FontSizeUtil
    {
        public static float getSize(String name)
        {
            if (StringUtil.isEmpty(name))
            {
                return 10.5F;
            }
            switch (name)
            {
                case "初号":
                    return 46;
                case "小初":
                    return 36;
                case "一号":
                    return 26;
                case "小一":
                    return 24;
                case "二号":
                    return 22;
                case "小二":
                    return 18;
                case "三号":
                    return 16;
                case "小三":
                    return 15;
                case "四号":
                    return 14;
                case "小四":
                    return 12;
                case "五号":
                    return 10.5F;
                case "小五":
                    return 9;
                case "六号":
                    return 7.5F;
                case "小六":
                    return 6.5F;
                case "七号":
                    return 5.5F;
                case "八号":
                    return 5;
                default:
                    break;
            }
            return float.Parse(name);
        }

        public static string getName(string size)
        {
            switch (size)
            {
                case "46":
                    return "初号";
                case "36":
                    return "小初";
                case "26":
                    return "一号";
                case "24":
                    return "小一";
                case "22":
                    return "二号";
                case "18":
                    return "小二";
                case "16":
                    return "三号";
                case "15":
                    return "小三";
                case "14":
                    return "四号";
                case "12":
                    return "小四";
                case "10.5":
                    return "五号";
                case "9":
                    return "小五";
                case "7.5":
                    return "六号";
                case "6.5":
                    return "小六";
                case "5.5":
                    return "七号";
                case "5":
                    return "八号";
                default:
                    break;
            }
            return "五号";
        }
    }
}
