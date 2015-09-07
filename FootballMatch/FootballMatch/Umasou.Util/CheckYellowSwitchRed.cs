using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FootballMatch.Umasou.Util;

namespace FootballMatch.Umasou.Util
{
    class CheckYellowSwitchRed
    {
        ///
        ///检查黄牌数量是否累计到可以转化为红牌数量
        ///
        //检查黄牌数量是否累计到转换为红牌数量
        public static bool checkSwitchState(int yellowCardNum)
        {
            bool flag = false;
            if (yellowCardNum >= SystemParam.getSwitchNum()) //查询配置文件中设定的黄牌转换为红牌数量的值
            {
                flag = true;  //达到临界转换条件时
            }
            return flag;
        }
    }
}
