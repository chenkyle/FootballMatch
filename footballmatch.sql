/*
Navicat MySQL Data Transfer

Source Server         : chzh921
Source Server Version : 50511
Source Host           : localhost:3306
Source Database       : footballmatch

Target Server Type    : MYSQL
Target Server Version : 50511
File Encoding         : 65001

Date: 2015-09-08 10:20:12
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `defaultset`
-- ----------------------------
DROP TABLE IF EXISTS `defaultset`;
CREATE TABLE `defaultset` (
  `defaultSeason` varchar(50) NOT NULL,
  `defaultMatch` varchar(50) NOT NULL,
  `defaultTurn` int(11) NOT NULL,
  PRIMARY KEY (`defaultSeason`,`defaultMatch`,`defaultTurn`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of defaultset
-- ----------------------------
INSERT INTO `defaultset` VALUES ('25', '中超联赛sssss', '1');

-- ----------------------------
-- Table structure for `gameinfo`
-- ----------------------------
DROP TABLE IF EXISTS `gameinfo`;
CREATE TABLE `gameinfo` (
  `uniqueID` int(11) NOT NULL AUTO_INCREMENT,
  `matchID` int(11) NOT NULL,
  `matchGameNum` int(11) NOT NULL,
  `gameName` varchar(50) NOT NULL,
  `homeTeam` varchar(50) NOT NULL,
  `guestTeam` varchar(50) NOT NULL,
  `gameWinner` varchar(50) DEFAULT NULL,
  `gameResult` varchar(40) DEFAULT NULL,
  `gameAddress` varchar(200) DEFAULT NULL,
  `gameDate` datetime DEFAULT NULL,
  PRIMARY KEY (`uniqueID`),
  KEY `homeTeam` (`homeTeam`),
  KEY `guestTeam` (`guestTeam`),
  KEY `matchID` (`matchID`),
  CONSTRAINT `gameinfo_ibfk_1` FOREIGN KEY (`homeTeam`) REFERENCES `team` (`teamName`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `gameinfo_ibfk_2` FOREIGN KEY (`guestTeam`) REFERENCES `team` (`teamName`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `gameinfo_ibfk_3` FOREIGN KEY (`matchID`) REFERENCES `matchinfo` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of gameinfo
-- ----------------------------
INSERT INTO `gameinfo` VALUES ('1', '1', '1', '全国大学生联赛', '北京理工大学校队', '河海大学校队', '北京理工大学校队', '3:1', '北京理工大学', '2015-02-06 00:00:00');
INSERT INTO `gameinfo` VALUES ('2', '1', '2', '北理VS河海第二轮', '北京理工大学校队', '河海大学校队', '北京理工大学校队', '2:1', '河海大学', '2015-02-11 00:00:00');
INSERT INTO `gameinfo` VALUES ('3', '1', '3', 'fff', '河海大学校队', '清华大学', '河海大学校队', '2:1', 'shshh', '2015-09-07 00:00:00');
INSERT INTO `gameinfo` VALUES ('4', '1', '4', 'ccc', '北京理工大学校队', '河海大学校队', '北京理工大学校队', '2:1', 'ccc', '2015-09-07 00:00:00');

-- ----------------------------
-- Table structure for `gameseason`
-- ----------------------------
DROP TABLE IF EXISTS `gameseason`;
CREATE TABLE `gameseason` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `matchid` int(11) DEFAULT NULL,
  `numofseason` int(11) DEFAULT NULL,
  `seasondescription` varchar(100) DEFAULT NULL,
  `scheduleid` int(11) DEFAULT NULL,
  `matchname` varchar(45) DEFAULT NULL,
  `currentgameturn` int(11) DEFAULT NULL,
  `isCurrentSeason` varchar(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of gameseason
-- ----------------------------
INSERT INTO `gameseason` VALUES ('1', '1', '25', '中超联赛第25轮正在火热进行', '1', '中超联赛', '1', '');
INSERT INTO `gameseason` VALUES ('2', null, '1', '', null, '世界杯', null, '');
INSERT INTO `gameseason` VALUES ('3', null, '2', '群雄逐鹿，王师可待！', null, '亚洲杯', null, '');
INSERT INTO `gameseason` VALUES ('4', null, '1', '1', null, 'aaaa', null, '');
INSERT INTO `gameseason` VALUES ('5', null, '2', '2', null, 'aaaa', null, '');
INSERT INTO `gameseason` VALUES ('6', null, '3', '3', null, 'aaaa', null, '');
INSERT INTO `gameseason` VALUES ('7', null, '1', '重庆大学第一届研究生足球联赛', null, '重庆大学研究生足球赛', null, '');
INSERT INTO `gameseason` VALUES ('8', null, '2', '重庆大学第二届研究生足球赛', null, '重庆大学研究生足球赛', null, '');

-- ----------------------------
-- Table structure for `matchinfo`
-- ----------------------------
DROP TABLE IF EXISTS `matchinfo`;
CREATE TABLE `matchinfo` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `seasonName` varchar(50) NOT NULL,
  `description` varchar(400) DEFAULT NULL,
  `switchNum` int(11) NOT NULL,
  `serialNum` int(11) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8 COMMENT='包括赛季名称，赛季黄牌转换为红牌的数量条件，赛季轮次总计';

-- ----------------------------
-- Records of matchinfo
-- ----------------------------
INSERT INTO `matchinfo` VALUES ('1', '亚洲杯', '亚洲国家的足球赛事', '2', '40');
INSERT INTO `matchinfo` VALUES ('4', '世界杯', '全世界的国家的参加的足球比赛', '2', '20');
INSERT INTO `matchinfo` VALUES ('5', '美洲杯', '北美洲以及拉丁美洲国家参加的足球比赛', '2', '25');
INSERT INTO `matchinfo` VALUES ('7', '西班牙甲级联赛 ', '欧洲第一顶级足球赛事', '2', '30');
INSERT INTO `matchinfo` VALUES ('8', '重庆大学研究生足球赛', '', '2', '5');

-- ----------------------------
-- Table structure for `matchplayerinfo`
-- ----------------------------
DROP TABLE IF EXISTS `matchplayerinfo`;
CREATE TABLE `matchplayerinfo` (
  `unqiueID` int(11) NOT NULL AUTO_INCREMENT,
  `matchID` int(11) NOT NULL,
  `teamID` int(11) NOT NULL,
  `playerID` int(11) NOT NULL,
  `yellowCardNum` int(11) DEFAULT NULL,
  `redCardNum` int(11) DEFAULT NULL,
  `IsAvalible` bit(1) DEFAULT NULL,
  PRIMARY KEY (`unqiueID`),
  KEY `matchConstain` (`matchID`),
  KEY `playerConstrain` (`playerID`),
  KEY `teamID` (`teamID`),
  CONSTRAINT `matchConstain` FOREIGN KEY (`matchID`) REFERENCES `matchinfo` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `matchplayerinfo_ibfk_1` FOREIGN KEY (`teamID`) REFERENCES `team` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `playerConstrain` FOREIGN KEY (`playerID`) REFERENCES `player` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8 COMMENT='//记录赛事球员基本信息，反应球员在某一赛事中累计的黄牌数量，红牌数量以及是否能够参赛等信息';

-- ----------------------------
-- Records of matchplayerinfo
-- ----------------------------
INSERT INTO `matchplayerinfo` VALUES ('11', '1', '1', '2', null, null, null);
INSERT INTO `matchplayerinfo` VALUES ('12', '1', '1', '3', null, null, null);
INSERT INTO `matchplayerinfo` VALUES ('13', '1', '1', '4', null, null, null);
INSERT INTO `matchplayerinfo` VALUES ('15', '1', '1', '6', null, null, null);
INSERT INTO `matchplayerinfo` VALUES ('16', '1', '2', '9', null, null, null);
INSERT INTO `matchplayerinfo` VALUES ('17', '1', '4', '8', null, null, null);

-- ----------------------------
-- Table structure for `matchteaminfo`
-- ----------------------------
DROP TABLE IF EXISTS `matchteaminfo`;
CREATE TABLE `matchteaminfo` (
  `uniqueID` int(11) NOT NULL AUTO_INCREMENT,
  `matchID` int(11) NOT NULL,
  `teamID` int(11) NOT NULL,
  PRIMARY KEY (`uniqueID`),
  KEY `matchConstrain` (`matchID`),
  KEY `teamConstrain` (`teamID`),
  CONSTRAINT `matchConstrain` FOREIGN KEY (`matchID`) REFERENCES `matchinfo` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `teamConstrain` FOREIGN KEY (`teamID`) REFERENCES `team` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8 COMMENT='//记录某一赛事中的球队，反应哪些球队参加到该赛事中';

-- ----------------------------
-- Records of matchteaminfo
-- ----------------------------
INSERT INTO `matchteaminfo` VALUES ('5', '1', '1');
INSERT INTO `matchteaminfo` VALUES ('6', '1', '2');
INSERT INTO `matchteaminfo` VALUES ('8', '1', '4');

-- ----------------------------
-- Table structure for `player`
-- ----------------------------
DROP TABLE IF EXISTS `player`;
CREATE TABLE `player` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `playerName` varchar(20) NOT NULL,
  `number` int(11) DEFAULT NULL,
  `postion` varchar(20) DEFAULT NULL,
  `teamName` varchar(50) NOT NULL,
  `playerIDnum` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `teamName` (`teamName`),
  CONSTRAINT `player_ibfk_1` FOREIGN KEY (`teamName`) REFERENCES `team` (`teamName`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of player
-- ----------------------------
INSERT INTO `player` VALUES ('1', '二孔', '2', '前锋', '北京理工大学校队', null);
INSERT INTO `player` VALUES ('2', '老朱', '6', '前锋', '北京理工大学校队', null);
INSERT INTO `player` VALUES ('3', '洋洋', '8', '前锋', '北京理工大学校队', null);
INSERT INTO `player` VALUES ('4', '小真', '1', '前锋', '北京理工大学校队', null);
INSERT INTO `player` VALUES ('5', '樊闪闪', '3', '中锋', '北京理工大学校队', null);
INSERT INTO `player` VALUES ('6', '小明', '7', '中锋', '北京理工大学校队', null);
INSERT INTO `player` VALUES ('7', '何以琛', '21', '前锋', '北京大学', null);
INSERT INTO `player` VALUES ('8', '英菲', '17', '前锋', '清华大学', null);
INSERT INTO `player` VALUES ('9', '李迪', '18', '后卫', '河海大学校队', null);

-- ----------------------------
-- Table structure for `playergetcardrecord`
-- ----------------------------
DROP TABLE IF EXISTS `playergetcardrecord`;
CREATE TABLE `playergetcardrecord` (
  `uniqueID` int(11) NOT NULL AUTO_INCREMENT,
  `matchID` int(11) NOT NULL,
  `playerID` int(11) NOT NULL,
  `yellowCardNum` int(11) DEFAULT NULL,
  `redCardNum` int(11) DEFAULT NULL,
  `serialNum` int(11) DEFAULT NULL,
  `getDate` datetime DEFAULT NULL,
  PRIMARY KEY (`uniqueID`),
  KEY `match_Constrain` (`matchID`),
  KEY `player_Constrain` (`playerID`),
  CONSTRAINT `match_Constrain` FOREIGN KEY (`matchID`) REFERENCES `matchinfo` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `player_Constrain` FOREIGN KEY (`playerID`) REFERENCES `player` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 COMMENT='//记录球员领取各类牌的时间及其数量';

-- ----------------------------
-- Records of playergetcardrecord
-- ----------------------------
INSERT INTO `playergetcardrecord` VALUES ('1', '1', '4', '1', '0', '1', '2015-02-06 21:06:28');
INSERT INTO `playergetcardrecord` VALUES ('2', '1', '4', '1', '0', '1', '2015-02-11 10:49:24');

-- ----------------------------
-- Table structure for `schedule`
-- ----------------------------
DROP TABLE IF EXISTS `schedule`;
CREATE TABLE `schedule` (
  `id` int(10) unsigned zerofill NOT NULL AUTO_INCREMENT,
  `seasonId` int(11) NOT NULL,
  `matchId` int(11) NOT NULL,
  `turn` int(11) NOT NULL,
  `gameDate` varchar(255) NOT NULL,
  `homeTeamName` varchar(255) NOT NULL,
  `guestTeamName` varchar(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of schedule
-- ----------------------------
INSERT INTO `schedule` VALUES ('0000000001', '1', '8', '1', '2013年19月1日', 'A', 'B');
INSERT INTO `schedule` VALUES ('0000000002', '1', '8', '1', '2013年19月2日', 'C', 'B');
INSERT INTO `schedule` VALUES ('0000000003', '1', '8', '1', '2013年19月3日', 'D', 'E');
INSERT INTO `schedule` VALUES ('0000000004', '1', '8', '1', '2013年19月4日', 'C', 'A');
INSERT INTO `schedule` VALUES ('0000000005', '1', '8', '1', '2013年19月1日', 'A', 'B');
INSERT INTO `schedule` VALUES ('0000000006', '1', '8', '1', '2013年19月2日', 'C', 'B');
INSERT INTO `schedule` VALUES ('0000000007', '1', '8', '1', '2013年19月3日', 'D', 'E');
INSERT INTO `schedule` VALUES ('0000000008', '1', '8', '1', '2013年19月4日', 'C', 'A');

-- ----------------------------
-- Table structure for `suspendedrecord`
-- ----------------------------
DROP TABLE IF EXISTS `suspendedrecord`;
CREATE TABLE `suspendedrecord` (
  `uniqueID` int(11) NOT NULL AUTO_INCREMENT,
  `matchID` int(11) NOT NULL,
  `playerID` int(11) NOT NULL,
  `gameNum` int(11) NOT NULL,
  `Date` datetime DEFAULT NULL,
  PRIMARY KEY (`uniqueID`),
  KEY `matchConstrian` (`matchID`),
  KEY `playerConstrian` (`playerID`),
  CONSTRAINT `matchConstrian` FOREIGN KEY (`matchID`) REFERENCES `matchinfo` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `playerConstrian` FOREIGN KEY (`playerID`) REFERENCES `player` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 COMMENT='记录球员被停赛的信息，包括日期和停赛场次';

-- ----------------------------
-- Records of suspendedrecord
-- ----------------------------
INSERT INTO `suspendedrecord` VALUES ('1', '1', '4', '2', '2015-02-11 00:00:00');

-- ----------------------------
-- Table structure for `team`
-- ----------------------------
DROP TABLE IF EXISTS `team`;
CREATE TABLE `team` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `teamName` varchar(50) NOT NULL,
  `teamLeader` varchar(20) DEFAULT NULL,
  `teamManager` varchar(20) DEFAULT NULL,
  `teamCoach` varchar(20) DEFAULT NULL,
  `teamFullName` varchar(100) DEFAULT NULL,
  `birthDate` varchar(50) DEFAULT NULL,
  `matchName` varchar(50) DEFAULT NULL,
  `location` varchar(45) DEFAULT NULL,
  `introduction` varchar(300) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `teamName` (`teamName`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of team
-- ----------------------------
INSERT INTO `team` VALUES ('1', '北京理工大学校队', 'Umasou', 'BIT', '路人甲', '北京理工大学足球队', '2008-02-14 00:53:38', '中国男子甲A联赛', '海淀区魏公村', '这是一支大学生职业足球队');
INSERT INTO `team` VALUES ('2', '河海大学校队', 'Arvin', 'HHUC', '路人乙', null, null, null, null, null);
INSERT INTO `team` VALUES ('3', '北京大学', 'Hobbit', 'BJUC', '路人丙', null, null, null, null, null);
INSERT INTO `team` VALUES ('4', '清华大学', 'SICOYI', 'QHUC', '路人丁', null, null, null, null, null);
INSERT INTO `team` VALUES ('5', '北京航空航天', 'Buzer', 'BHUC', '路人戊', null, null, null, null, null);
INSERT INTO `team` VALUES ('8', 'A', 'a', '', '', 'aaaaa', '2015年8月31日', '重庆大学研究生足球赛', 'a', 'a');
INSERT INTO `team` VALUES ('9', 'B', 'B', 'B', 'B', 'B', '2015年8月31日', '重庆大学研究生足球赛', 'B', 'B');
INSERT INTO `team` VALUES ('10', 'C', 'C', 'C', 'C', 'CC', '2015年8月31日', '重庆大学研究生足球赛', 'C', 'C');
INSERT INTO `team` VALUES ('11', 'D', 'D', 'D', 'D', 'D', '2015年8月31日', '重庆大学研究生足球赛', 'D', 'D');
INSERT INTO `team` VALUES ('12', 'E', 'E', 'E', 'E', 'E', '2015年8月31日', '重庆大学研究生足球赛', 'E', 'E');
