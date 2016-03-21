USE DoctorVisitingSystem;
GO

CREATE PROCEDURE spMakeAnAppointment
	@firstName NVARCHAR(30),
	@lastName NVARCHAR(50),
	@dateOfBirth DATETIME,
	@address NVARCHAR(100),
	@doctorsName NVARCHAR(30),
	@appointmentDateTime DATETIME
AS
BEGIN
	SET NOCOUNT ON;
	DECLARE @patientId INT,
			@doctorId INT,
			@appointmentDateTimeFinish DATETIME,
			@appointmentId INT;	

	IF EXISTS (SELECT 1
			   FROM tblPatient 
			   WHERE FirstName = @firstName AND LastName = @lastName AND DateOfBirth = @dateOfBirth AND [Address] = @address)
		BEGIN
			SELECT @patientId = Id
			FROM tblPatient 
			WHERE FirstName = @firstName AND LastName = @lastName AND DateOfBirth = @dateOfBirth AND [Address] = @address;
		END;
	ELSE
		BEGIN
			INSERT INTO tblPatient VALUES
					(@firstName, @lastName, @dateOfBirth, @address);
			SET @patientId = SCOPE_IDENTITY();
		END;

	SELECT @doctorId = Id
	FROM tblDoctor
	WHERE @doctorsName = Name;

	SELECT @appointmentDateTimeFinish = dbo.fnAddTimeToDateTime(@appointmentDateTime, AppointmentDuration)
	FROM tblDoctor
	WHERE @doctorId = Id;
	
	IF dbo.fnCheckDateTimeWithinDoctorsWorkingHour(@doctorId, @appointmentDateTime) = 0
		BEGIN;
			THROW 50020, 'Doctor does not work at that time!', 16;
		END;

	ELSE IF dbo.fnCheckDateTimeWithinDoctorsFreeTime(@doctorId, @appointmentDateTime) = 0
		BEGIN;
			THROW 50010, 'Doctor has an appointment at that time!', 16;
		END;	

	ELSE IF dbo.fnCheckDateTimeWithinPatientFreeTime(@patientId, @doctorId, @appointmentDateTime) = 0
		BEGIN;
			THROW 50030, 'Patient has an appointment at that time!', 16;
		END;

	INSERT INTO tblAppointment VALUES
		(@doctorId, @patientId, @appointmentDateTime, @appointmentDateTimeFinish);

	SET @appointmentId = SCOPE_IDENTITY();

	SELECT * 
	FROM tblAppointment
	WHERE Id = @appointmentId;
END;
GO


--returns 1 if there are no appointments to that doctor at certain time
CREATE FUNCTION fnCheckDateTimeWithinDoctorsFreeTime
(
	@doctorId INT,
	@desiredDateTime DATETIME
)
RETURNS BIT
AS
BEGIN
	DECLARE @isCompatible BIT;
	DECLARE @duration TIME = (SELECT d.AppointmentDuration FROM tblDoctor d WHERE d.Id = @doctorId);
	DECLARE @desiredDateTimeStart DATETIME = @desiredDateTime;
	DECLARE @desiredDateTimeFinish DATETIME = dbo.fnAddTimeToDateTime(@desiredDateTimeStart, @duration);

	IF EXISTS
		(
		SELECT 1
		FROM tblAppointment a
		WHERE	
				a.DoctorId = (SELECT Id FROM tblDoctor WHERE Id = @doctorId)
			AND
				(
					(@desiredDateTimeStart >= a.AppointmentDateTimeStart AND @desiredDateTimeStart < a.AppointmentDateTimeFinish)
					OR
					(@desiredDateTimeFinish > a.AppointmentDateTimeStart AND @desiredDateTimeFinish <= a.AppointmentDateTimeFinish )
				)
		) 
		SET @isCompatible = 0;
	ELSE
		SET @isCompatible = 1;
	RETURN @isCompatible;
END;
GO


--returns 1 if time is within doctor's schedule 
CREATE FUNCTION fnCheckDateTimeWithinDoctorsWorkingHour
(	
	@doctorId INT,
	@desiredDateTime DATETIME
)
RETURNS BIT
AS
BEGIN
	DECLARE @isCompatible BIT,
			@desiredTime TIME  = CAST(@desiredDateTime AS TIME);

	IF  	
	(@desiredTime BETWEEN 
		(SELECT ArrivingTime FROM tblDoctor WHERE Id = @doctorId) 
		AND
		(SELECT dbo.fnSubtractTimeFromTime(StartingTimeOfBreak, AppointmentDuration) FROM tblDoctor WHERE Id = @doctorId)
	)
	OR
	(@desiredTime BETWEEN 
		(SELECT FinishingTimeOfBreak FROM tblDoctor WHERE Id = @doctorId) 
		AND
		(SELECT dbo.fnSubtractTimeFromTime(LeavingTime, AppointmentDuration) FROM tblDoctor WHERE Id = @doctorId)
	)
		SET @isCompatible = 1;
	ELSE
		SET @isCompatible = 0;
	
	RETURN @isCompatible;
END;
GO


--returns 1 if patient doesn't have an appointment with doctor at that period of time
CREATE FUNCTION fnCheckDateTimeWithinPatientFreeTime
(
	@patientId INT,	
	@doctorId INT,
	@desiredDateTime DATETIME
)
RETURNS BIT
AS
BEGIN
	DECLARE @isCompatible BIT;

	IF NOT EXISTS
	(
		SELECT 1
		FROM tblAppointment a
		WHERE a.PatientId = @patientId 
		AND (
				(@desiredDateTime >= a.AppointmentDateTimeStart AND @desiredDateTime < a.AppointmentDateTimeFinish)
					OR
				(dbo.fnAddTimeToDateTime(@desiredDateTime, (SELECT d.AppointmentDuration FROM tblDoctor d WHERE d.Id = @doctorId))
					> a.AppointmentDateTimeStart 
					AND dbo.fnAddTimeToDateTime(@desiredDateTime, (SELECT d.AppointmentDuration FROM tblDoctor d WHERE d.Id = @doctorId)) <= a.AppointmentDateTimeFinish)
			)
	)	
		SET @isCompatible = 1;
	ELSE
		SET @isCompatible = 0;
	
	RETURN @isCompatible;
END;
GO


CREATE FUNCTION fnAddTimeToDateTime
(
	@dateTime DATETIME, 
	@timeToAdd TIME
)
RETURNS DATETIME
AS
BEGIN
	DECLARE @hoursToAdd INT = DATEPART(HOUR, @timeToAdd),
			@minutesToAdd INT = DATEPART(MINUTE, @timeToAdd);

	SET @dateTime = DATEADD(HOUR, @hoursToAdd, @dateTime);
	SET @dateTime = DATEADD(MINUTE, @minutesToAdd, @dateTime);

	RETURN @dateTime;
END;
GO


CREATE FUNCTION fnSubtractTimeFromTime
(
	@inputTime TIME,
	@timeToSubtract TIME
)
RETURNS TIME
AS
BEGIN
	DECLARE @hoursToSubtract INT = DATEPART(HOUR, @timeToSubtract),
		    @minutesToSubtract INT = DATEPART(MINUTE, @timeToSubtract);

	SET @inputTime = DATEADD(HOUR, (-1) * @hoursToSubtract, @inputTime);
	SET @inputTime = DATEADD(MINUTE, (-1) * @minutesToSubtract, @inputTime);

	RETURN @inputTime;
END;
GO


CREATE PROCEDURE spGetReceptionistByLogin
	@login NVARCHAR(50),
	@password NVARCHAR(50)
AS
BEGIN
	SELECT Id, FirstName, LastName, [Login], [Password]
	FROM tblReceptionist
	WHERE [Login] = @login AND [Password] = @password;
END
GO


CREATE PROCEDURE spGetAllApointmentByPatientName
	@firstName NVARCHAR(30),
	@lastName NVARCHAR(50),
	@dateOfBirth DATETIME,
	@address NVARCHAR(100)
AS
BEGIN
	SELECT p.FirstName, p.LastName, d.Name, a.AppointmentDateTimeStart, a.AppointmentDateTimeFinish
	FROM tblPatient p INNER JOIN tblAppointment a
		ON p.Id = a.PatientId
		INNER JOIN tblDoctor d
		ON d.Id = a.DoctorId
	WHERE p.FirstName = @firstName
	  AND p.LastName = @lastName
	  AND p.DateOfBirth = @dateOfBirth
	  AND p.[Address] = @address
	ORDER BY a.AppointmentDateTimeStart;
END;
GO


CREATE PROCEDURE spGetAllDoctors
AS
BEGIN
	SELECT Id,
    	   Name, 
    	   ArrivingTime, 
    	   LeavingTime, 
    	   StartingTimeOfBreak, 
    	   FinishingTimeOfBreak, 
    	   AppointmentDuration
    FROM tblDoctor;
END;
GO


CREATE PROCEDURE spGetDoctorById
	@doctorId INT
AS
BEGIN
	SELECT Id,
    	   Name, 
    	   ArrivingTime, 
    	   LeavingTime, 
    	   StartingTimeOfBreak, 
    	   FinishingTimeOfBreak, 
    	   AppointmentDuration
    FROM tblDoctor
	WHERE Id = @doctorId;
END;
GO


CREATE PROCEDURE spGetAvaiableDoctorByDateTime
	@dateTime DATETIME
AS
BEGIN
	SELECT d.Id, d.Name
	FROM tblDoctor d
	WHERE dbo.fnCheckDateTimeWithinDoctorsFreeTime(d.Id, @dateTime) = 1
	AND dbo.fnCheckDateTimeWithinDoctorsWorkingHour(d.Id, @dateTime) = 1
END;
GO


CREATE PROCEDURE spGetDoctorsRating
	@timeFrom DATE,
	@timeTo DATE
AS
BEGIN
	(
		SELECT d.Name, "Count" = COUNT(a.PatientId)
		FROM tblDoctor d JOIN tblAppointment a
			ON(d.Id = a.DoctorId)
		WHERE CAST(a.AppointmentDateTimeStart AS DATE) BETWEEN @timeFrom AND @timeTo
		GROUP BY d.Name
	)
	UNION
	(
		SELECT Name, "Count" = 0
		FROM tblDoctor                                                        
		WHERE Name NOT IN (
							SELECT d.Name
							FROM tblDoctor d LEFT JOIN tblAppointment a                                                        
									ON (d.Id = a.DoctorId)                                                        
							WHERE CAST(a.AppointmentDateTimeStart AS DATE) BETWEEN @timeFrom AND @timeTo
							)					                                    
	)
	ORDER BY "Count" DESC, Name ASC
END;
GO


CREATE PROCEDURE spGetPatientsByDoctorIdAndDate
	@doctorId INT,
	@date DATE
AS
BEGIN
	SELECT p.FirstName, p.LastName, a.AppointmentDateTimeStart AS "AppointmentTime"
    FROM tblAppointment a INNER JOIN tblPatient p
        ON a.PatientId = p.Id
    WHERE CAST(a.AppointmentDateTimeStart AS DATE) = @date 
        AND a.DoctorId = @doctorId;
END;
GO


CREATE PROCEDURE spGetPatientsCountByDoctorIdAndDate
	@doctorId INT,
	@date DATE
AS
BEGIN
	SELECT COUNT(*) AS "PatientCount"
    FROM tblAppointment
    WHERE CAST(AppointmentDateTimeStart AS DATE) = @date 
    AND DoctorId = @doctorId;
END;
GO


CREATE PROCEDURE spGetPatientsByLastName
	@lastName NVARCHAR(50)
AS
BEGIN
	SELECT Id, FirstName, LastName, DateOfBirth, [Address]
	FROM tblPatient
	WHERE LastName LIKE CONCAT('%', @lastName, '%')
	ORDER BY LastName;
END;
GO