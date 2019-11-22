CREATE TABLE `users` (
    `ID` INT(10) NOT NULL AUTO_INCREMENT,
    `Login` VARCHAR(50) UNIQUE NOT NULL,
    `AccessKey` VARCHAR(50) NOT NULL,
    PRIMARY KEY (`ID`)
)
COLLATE='latin1_swedish_ci'
ENGINE=InnoDB;