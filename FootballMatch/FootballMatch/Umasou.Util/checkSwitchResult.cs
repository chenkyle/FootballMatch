using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballMatch.Umasou.Util
{
    class checkSwitchResult
    {
        ///
        ///检查是否可以实现字符串或数字之间的相互转换
        ///
        public static bool checkStringSwitchInteger(string stringNum)
        {
            try  
            {
                Convert.ToInt32(stringNum);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
