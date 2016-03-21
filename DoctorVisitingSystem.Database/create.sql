CREATE DATABASE DoctorVisitingSystem;
GO

USE DoctorVisitingSystem;
GO

CREATE TABLE tblDoctor
(
	Id INT NOT NULL IDENTITY(1, 1),
	Name NVARCHAR(30) NOT NULL,
	ArrivingTime TIME NOT NULL,
	LeavingTime TIME NOT NULL,
	StartingTimeOfBreak TIME NOT NULL,
	FinishingTimeOfBreak TIME NOT NULL,
	AppointmentDuration TIME NOT NULL,

	CONSTRAINT PK_tblDoctor_Id PRIMARY KEY (Id),
	CONSTRAINT CK_tblDoctor_ArrivingTimeLessThanStartingTimeOfBreak CHECK (ArrivingTime < StartingTimeOfBreak),
	CONSTRAINT CK_tblDoctor_StartingTimeOfBreakLessThanFinishingTimeOfBreak CHECK (StartingTimeOfBreak < FinishingTimeOfBreak),
	CONSTRAINT CK_tblDoctor_FinishingTimeOfBreakLessThanLeavingTime CHECK (FinishingTimeOfBreak < LeavingTime),
	CONSTRAINT CK_tblDoctor_AppointmentDurationMoreThanZero CHECK (AppointmentDuration > '00:00')
);

CREATE TABLE tblPatient
(
	Id INT NOT NULL IDENTITY(1, 1),
	FirstName NVARCHAR(30) NOT NULL,
	LastName NVARCHAR(50) NOT NULL,
	DateOfBirth DATETIME NOT NULL,
	[Address] NVARCHAR(100) NOT NULL,

	CONSTRAINT PK_tblPatient_Id PRIMARY KEY (Id),
	CONSTRAINT CK_tblPatient_DateOfBirthLessThanTodaysDate CHECK (DateOfBirth < GETDATE()),
	CONSTRAINT UQ_tblPatient_FirstName_LastName_DateOfBirth_Address UNIQUE (FirstName, LastName, DateOfBirth, [Address])
);

CREATE TABLE tblAppointment
(
	Id INT NOT NULL IDENTITY(1, 1),
	DoctorId INT NOT NULL,
	PatientId INT NOT NULL,
	AppointmentDateTimeStart DATETIME NOT NULL,
	AppointmentDateTimeFinish DATETIME NOT NULL,

	CONSTRAINT PK_tblAppointment_Id PRIMARY KEY (Id),
	CONSTRAINT FK_tblAppointment_DoctorId_tblDoctor_Id FOREIGN KEY (DoctorId) REFERENCES tblDoctor (Id),
	CONSTRAINT FK_tblAppointment_PatientId_tblPatient_Id FOREIGN KEY (PatientId) REFERENCES tblPatient (Id),
	CONSTRAINT CK_tblAppointment_AppointmentDateTimeStartMoreThanTodaysDateTime CHECK (AppointmentDateTimeStart > DATEADD(MINUTE, -5, GETDATE())),
	CONSTRAINT CK_tblAppointment_AppointmentDateTimeStartLessThanAppointmentDateTimeFinish CHECK (AppointmentDateTimeStart < AppointmentDateTimeFinish),
);

CREATE TABLE tblReceptionist 
(
	Id INT NOT NULL IDENTITY(1, 1),
	FirstName NVARCHAR(30) NOT NULL,
	LastName NVARCHAR(50) NOT NULL,
	[Login] NVARCHAR(50) NOT NULL,
	[Password] NVARCHAR(50) NOT NULL,

	CONSTRAINT PK_tblReceptionist_Id PRIMARY KEY (Id),
	CONSTRAINT UQ_tblReceptionist_Login UNIQUE ([Login])
);