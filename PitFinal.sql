CREATE DATABASE PitFinal

USE [PitFinal]

CREATE TABLE UserInformation
(
	IdUser INT NOT NULL PRIMARY KEY identity (1,1),
	NameLogin [VARCHAR](50) NOT NULL,
	UserLogin [VARCHAR](50) NOT NULL UNIQUE,
	PasswordLogin [VARCHAR](50) NOT NULL
)

CREATE TABLE AlarmInformation
(
	IdAlarm INT NOT NULL PRIMARY KEY identity (1,1),
	IdUser INT NOT NULL FOREIGN KEY REFERENCES UserInformation(IdUser),
	HourAlarm INT NOT NULL,
	MinuteAlarm INT NOT NULL,
	MedicineAlarm [VARCHAR](50) NOT NULL,
	WeekAlarm [VARCHAR](50) NOT NULL
)

CREATE TABLE ScheduleInformation
(
	IdSchedule INT NOT NULL PRIMARY KEY identity (1,1),
	IdUser INT NOT NULL FOREIGN KEY REFERENCES UserInformation(IdUser),
	DaySchedule INT NOT NULL,
	MonthSchedule INT NOT NULL,
	YearSchedule INT NOT NULL,
	HourSchedule INT NOT NULL,
	MinuteSchedule INT NOT NULL,
	DescriptionSchedule [VARCHAR](50) NOT NULL
)

SELECT * FROM UserInformation
SELECT * FROM AlarmInformation
SELECT * FROM ScheduleInformation