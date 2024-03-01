CREATE DATABASE [391project1P2]
GO
USE [391project1P2]
GO
CREATE TABLE [dbo].[course](
	[courseID] [nvarchar](20) NOT NULL,
	[department] [nvarchar](20) NOT NULL,
	[faculty] [nvarchar](40) NOT NULL,
	[university] [nvarchar] (60) NOT NULL,

	CONSTRAINT PK_course PRIMARY KEY (courseID)
)
GO
CREATE TABLE [dbo].[dates](
	[dateID] [nchar](10) NOT NULL,
	[semester] [nvarchar](10) NOT NULL,
	[year] [nchar](10) NOT NULL,

	CONSTRAINT PK_date PRIMARY KEY (dateID)
)
GO
CREATE TABLE [dbo].[instructor](
	[instructorID] [nchar](10) NOT NULL,
	[firstName] [nvarchar](40) NOT NULL,
	[lastName] [nvarchar](40) NOT NULL,
	[rank] [nchar](10) NOT NULL,
	[university] [nvarchar](60) NOT NULL,
	[faculty] [nvarchar](40) NOT NULL,

	CONSTRAINT PK_instructor PRIMARY KEY (instructorID)
)
GO
CREATE TABLE [dbo].[student](
	[studentID] [nchar](10) NOT NULL,
	[firstName] [nvarchar](40) NOT NULL,
	[lastName] [nvarchar](40) NOT NULL,
	[major] [nvarchar](40) NOT NULL,
	[gender] [nvarchar](10) NOT NULL,
	[street] [nvarchar](20) NOT NULL,
	[postalCode] [nvarchar](20) NOT NULL,
	[city] [nvarchar](20) NOT NULL,
	[province] [nvarchar](20) NOT NULL,
	[country] [nvarchar](20) NOT NULL,

	CONSTRAINT PK_student PRIMARY KEY (studentID)
)
GO
CREATE TABLE [dbo].[takes](
	[instructorID] [nchar](10) NOT NULL,
	[courseID] [nvarchar](20) NOT NULL,
	[studentID] [nchar](10) NOT NULL,
	[dateID] [nchar](10) NOT NULL,

	CONSTRAINT PK_takes PRIMARY KEY (instructorID, courseID, studentID, dateID),
	CONSTRAINT FK_takes_instructor FOREIGN KEY (instructorID) REFERENCES instructor(instructorID),
	CONSTRAINT FK_takes_course FOREIGN KEY (courseID) REFERENCES course(courseID),
	CONSTRAINT FK_takes_student FOREIGN KEY (studentID) REFERENCES student(studentID),
	CONSTRAINT FK_takes_date FOREIGN KEY (dateID) REFERENCES dates(dateID)
)
GO
