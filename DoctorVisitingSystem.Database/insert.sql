USE DoctorVisitingSystem;
GO

SET IDENTITY_INSERT tblDoctor ON;

INSERT INTO tblDoctor (Id, Name, ArrivingTime, LeavingTime, StartingTimeOfBreak, FinishingTimeOfBreak, AppointmentDuration) 
	VALUES	
	(1, 'Dr. Ben', '9:00', '19:00', '15:00', '16:00', '1:00'),
	(2, 'Dr. Richard', '7:00', '19:00', '13:00', '15:00', '2:00'),
	(3, 'Dr. Mark', '12:00', '21:00', '16:00', '18:00', '1:00'),
	(4, 'Dr. William', '6:00', '16:00', '10:00', '11:00', '2:00'),
	(5, 'Dr. Paul', '15:00', '22:00', '18:00', '19:00', '1:00'),
	(6, 'Dr. Mary', '10:00', '20:00', '14:00', '15:00', '0:30');

SET IDENTITY_INSERT tblDoctor OFF;
GO

SET IDENTITY_INSERT tblPatient ON;

INSERT INTO tblPatient (Id, FirstName, LastName, DateOfBirth, [Address]) 
	VALUES
	(1, 'Oleh', 'Melnyk', '1991-02-12', 'Hmelnytskoho'),
	(2, 'Ivan', 'Kravchuck', '1980-12-22', 'Horodotska'),
	(3, 'Olha', 'Shevchenko', '1956-04-05', 'Serbska'),
	(4, 'Olena', 'Mazur', '1975-06-30', 'Donetska'),
	(5, 'Serhiy', 'Tkach', '1997-03-03', 'Lypynskoho'),
	(6, 'Yuriy', 'Kulyk', '1998-09-12', 'Valova'),
	(7, 'Iryna', 'Ivanova', '1962-07-23', 'Illenka'),
	(8, 'Halyna', 'Dudash', '1975-03-09', 'Pasichna'),
	(9, 'Ivan', 'Melnyk', '1991-02-12', 'Hmelnytskoho'),
	(10, 'Maria', 'Ivanova', '1957-03-20', 'Horodotska'),
	(11, 'Ihor', 'Mazur', '1974-12-20', 'Donetska'),
	(12, 'Serhiy', 'Mazur', '1999-06-30', 'Donetska'),
	(13, 'Orysia', 'Mazur', '2000-08-14', 'Donetska'),
	(14, 'Olha', 'Shevchenko', '1945-04-17', 'Rusovyh');

SET IDENTITY_INSERT tblPatient OFF;


SET IDENTITY_INSERT tblAppointment ON;

INSERT INTO tblAppointment (Id, DoctorId, PatientId, AppointmentDateTimeStart, AppointmentDateTimeFinish) 
	VALUES
	(1, 5, 2, '2016-03-30 15:00', '2016-03-30 16:00'),
	(2, 5, 3, '2016-03-30 17:00', '2016-03-30 18:00'),
	(3, 5, 7, '2016-03-30 20:00', '2016-03-30 21:00'),
	(4, 1, 2, '2016-03-30 9:00', '2016-03-30 10:00'),
	(5, 2, 4, '2016-03-30 11:00', '2016-03-30 13:00'),	
	(6, 4, 5, '2016-03-30 08:00', '2016-03-30 10:00'),
	(7, 3, 5, '2016-03-30 19:00', '2016-03-30 20:00'),
	(8, 6, 13, '2016-03-30 10:00', '2016-03-30 10:30'),
	(9, 6, 8, '2016-03-30 15:30', '2016-03-30 16:00'),
	(10, 6, 9, '2016-03-30 12:00', '2016-03-30 12:30'),
	(11, 6, 10, '2016-03-30 19:00', '2016-03-30 19:30'),
	(12, 3, 1, '2016-03-30 12:00', '2016-03-30 13:00'),
	(13, 2, 6, '2016-03-30 15:00', '2016-03-30 17:00');

SET IDENTITY_INSERT tblAppointment OFF;


SET IDENTITY_INSERT tblReceptionist ON;

INSERT INTO tblReceptionist(Id, FirstName, LastName, [Login], [Password]) 
	VALUES
	(1, 'Sophia', 'Kulyk', 'supersophia', '79fc98c9ebcefe5acf01bc9802b4af1d'), --password : sophia123
	(2, 'Oksana', 'Halamaha', 'OksanaTheBest', 'c0e2705291054393f3cab6a93aa5d00d'), --password : oksa52
	(3, 'Ivan', 'Kulyk', 'i', 'c4ca4238a0b923820dcc509a6f75849b'); --password : 1	

SET IDENTITY_INSERT tblReceptionist OFF;