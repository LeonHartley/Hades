-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               8.0.11 - MySQL Community Server - GPL
-- Server OS:                    Win64
-- HeidiSQL Version:             9.5.0.5196
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

-- Dumping structure for table hades_game.players
CREATE TABLE IF NOT EXISTS `players` (
  `Id` bigint(20) NOT NULL AUTO_INCREMENT,
  `InstanceId` int(11) NOT NULL,
  `Name` varchar(64) NOT NULL,
  `Password` varchar(256) NOT NULL,
  `AvatarId` bigint(20) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `instance_id_username` (`InstanceId`,`Name`),
  KEY `avatar_id` (`AvatarId`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Dumping data for table hades_game.players: ~1 rows (approximately)
/*!40000 ALTER TABLE `players` DISABLE KEYS */;
INSERT INTO `players` (`Id`, `InstanceId`, `Name`, `Password`, `AvatarId`) VALUES
	(1, 1, 'Leon', '', 1);
/*!40000 ALTER TABLE `players` ENABLE KEYS */;

-- Dumping structure for table hades_game.player_avatars
CREATE TABLE IF NOT EXISTS `player_avatars` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(64) NOT NULL,
  `Figure` varchar(64) NOT NULL,
  `Motto` varchar(256) NOT NULL DEFAULT '',
  `Credits` int(11) NOT NULL DEFAULT '0',
  `VipPoints` int(11) NOT NULL DEFAULT '0',
  `ActivityPoints` int(11) NOT NULL DEFAULT '0',
  `AchievementPoints` int(11) NOT NULL DEFAULT '0',
  `DateCreated` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `DateLastActivity` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `FavouriteGroup` int(11) DEFAULT NULL,
  `RankId` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Dumping data for table hades_game.player_avatars: ~0 rows (approximately)
/*!40000 ALTER TABLE `player_avatars` DISABLE KEYS */;
INSERT INTO `player_avatars` (`Id`, `Name`, `Figure`, `Motto`, `Credits`, `VipPoints`, `ActivityPoints`, `AchievementPoints`, `DateCreated`, `DateLastActivity`, `FavouriteGroup`, `RankId`) VALUES
	(1, 'Leon', '', '', 0, 0, 0, 0, '2018-10-07 18:13:59', '2018-10-07 18:13:59', NULL, NULL);
/*!40000 ALTER TABLE `player_avatars` ENABLE KEYS */;

-- Dumping structure for table hades_game.player_badges
CREATE TABLE IF NOT EXISTS `player_badges` (
  `PlayerId` int(11) NOT NULL,
  `Code` varchar(50) NOT NULL,
  `Slot` tinyint(4) DEFAULT '0',
  PRIMARY KEY (`PlayerId`,`Code`),
  KEY `PlayerId` (`PlayerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Dumping data for table hades_game.player_badges: ~3 rows (approximately)
/*!40000 ALTER TABLE `player_badges` DISABLE KEYS */;
INSERT INTO `player_badges` (`PlayerId`, `Code`, `Slot`) VALUES
	(1, 'ADM', 0),
	(1, 'US8', 0),
	(1, 'VIP', 0);
/*!40000 ALTER TABLE `player_badges` ENABLE KEYS */;

-- Dumping structure for table hades_game.player_friends
CREATE TABLE IF NOT EXISTS `player_friends` (
  `PlayerId` bigint(20) NOT NULL,
  `FriendId` bigint(20) NOT NULL,
  `Relationship` tinyint(4) DEFAULT '0',
  PRIMARY KEY (`PlayerId`,`FriendId`),
  KEY `PlayerId` (`PlayerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Dumping data for table hades_game.player_friends: ~0 rows (approximately)
/*!40000 ALTER TABLE `player_friends` DISABLE KEYS */;
INSERT INTO `player_friends` (`PlayerId`, `FriendId`, `Relationship`) VALUES
	(1, 1, NULL);
/*!40000 ALTER TABLE `player_friends` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
