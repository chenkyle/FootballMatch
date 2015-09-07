using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballMatch.Umasou.Model
{
    public class CardState
    {
        ///
        ///   记录被罚的信息的状态
        ///
        //声明实例
        private int cardStateID;  //牌数量状态的ID
        private int redCardNumber;  //红牌数量
        private int yellowCardNumber;  //黄牌数量
        private bool IsStopMatch;  //是否停赛
        //构造函数
        public CardState()
        {
        }
        public CardState(int _cardStateID)
        {
            this.cardStateID = _cardStateID;
        }
        //取值方法
        public int getID()
        {
            return cardStateID;
        }
        public int getRedCardNum()
        {
            return redCardNumber;
        }
        public int getYellowCardNum()
        {
            return yellowCardNumber;
        }
        public bool getStopMatchState()
        {
            return IsStopMatch;
        }
        //赋值方法
        public void setID(int _cardStateID)
        {
            this.cardStateID = _cardStateID;
        }
        public void setRedCardNum(int _redCardNum)
        {
            this.redCardNumber = _redCardNum;
        }
        public void setYellowCardNum(int _yellowCardNum)
        {
            this.yellowCardNumber = _yellowCardNum;
        }
        public void setStopMatch(bool _IsStopMatch)
        {
            this.IsStopMatch = _IsStopMatch;
        }
    }
}
