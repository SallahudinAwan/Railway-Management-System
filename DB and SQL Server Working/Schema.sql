---------------------------------------------------------Railways Management System------------------------------------------

----------------------------------------------------------Schema File---------------------------------------------------

Use master
go
drop database RMS1
go
CREATE DATABASE RMS1
Go
USE RMS1
Go
CREATE TABLE Users (
user_id int IDENTITY(1,1) PRIMARY KEY,
UserType varchar(255) Not NULL,
first_name varchar(255) NOT NULL,
last_name varchar(255) Not Null,
age int NOT NULL,
CNIC varchar(15),
Email varchar(50),
mobile_no varchar(12) NOT NULL,
Password varchar(50) NOT NULL,
Wallet INT NOT NULL
);
GO
drop Table Passenger
go
CREATE TABLE Passenger(
passenger_id int PRIMARY KEY,
user_id int NOT NULL FOREIGN KEY REFERENCES Users(user_id),
reservation_status varchar(255) Default 'Not Allotted Seat' NOT NULL
);
GO
drop Table Train
go
CREATE TABLE Train(
train_no int IDENTITY(1,1) PRIMARY KEY,
train_name varchar(255) NOT NULL,
total_seats int default 40 Not Null --Max Seats 40
);
GO
drop Table Station
go
CREATE TABLE Station(
station_id int IDENTITY(1,1) PRIMARY KEY,
station_name varchar(255) NOT NULL,
city varchar(255) NOT NULL
);
GO
Drop Table Trip
go
CREATE TABLE Trip(--Updated One
trip_id int IDENTITY(1,1) PRIMARY KEY,
orig_station int NOT NULL FOREIGN KEY REFERENCES Station(station_id),
dest_station int NOT NULL FOREIGN KEY REFERENCES Station(station_id),
Trip_type varchar(255) Not Null,                      /* Popular or UnPopular Trip*/
Fare int Not Null
);
GO
CREATE TABLE Seats(
seat_no int NOT NULL,
train_no int NOT NULL FOREIGN KEY REFERENCES Train(train_no),
status_seat varchar(255) Default 'Not Booked' Not Null,    /*Seat Booked Or Not*/
Constraint s_seats Primary Key (train_no,seat_no),
Constraint check_Seatno_outRange Check (seat_no<=40)
);
drop table Ticket
GO
CREATE TABLE Ticket(
ticket_id int IDENTITY(1,1) PRIMARY KEY,
passenger_id int NOT NULL FOREIGN KEY REFERENCES Passenger(passenger_id),
train_no int NOT NULL FOREIGN KEY REFERENCES Train(train_no),
seat_no int Not Null,
trip_ID int Not Null FOREIGN KEY REFERENCES Trip(trip_id),
departure_time DateTime Not Null,
Constraint uniqSeat Unique(departure_time,seat_no,train_no)
);
GO
Drop Table Train_Info
go
CREATE TABLE Train_Info(
train_no int NOT NULL FOREIGN KEY REFERENCES Train(train_no),
departure_time DateTime NOT NULL,
arrival_time DateTime NOT NULL,
trip_id int NOT NULL FOREIGN KEY REFERENCES Trip(trip_id),
Constraint check_valid Check (arrival_time>departure_time)
);
Create Table User_Feedback(
user_id int not NULL FOREIGN KEY REFERENCES Users(user_id),
feedback varchar(255) NOT NULL
)
Go



-----------------------------------------------Insertion Procedures----------------------------------------------

Go
-----------------------------
go
Create Procedure InsertUsers_proc
(
@UserType varchar(255),
@first_name varchar(255),
@last_name varchar(255),
@age int,
@CNIC varchar(15),
@Email varchar(50),
@mobile_no varchar(12) ,
@Password varchar(50) ,
@Wallet INT
) as begin
Insert Into Users(UserType,first_name,last_name,age,CNIC,Email,mobile_no,Password,Wallet)
Values(@UserType,@first_name,@last_name,@age,@CNIC,@Email,@mobile_no,@Password,@Wallet);
end

Go
-----------------------------Procedure
Create Procedure InsertPassengers_proc 
(
@user_id int
) as begin
Insert Into Passenger(user_id)
values(@user_id);
end
Go
-----------------------------Procedure
Create Procedure InsertTrains_proc
(
@train_name varchar(255)
) as begin
Insert Into Train(train_name)
Values(@train_name)
end
Go
-----------------------------Procedure
Create Procedure InsertSeats_proc
(
@seat_no int,
@train_no int
) as Begin
Insert Into Seats(seat_no,train_no)
Values(@seat_no,@train_no)
end
Go
Create Procedure InsertTickets_proc
(
@passenger_id int,
@train_no int,
@seat_no int,
@trip_ID int
) as Begin
Insert Into Ticket(passenger_id,train_no,seat_no,trip_ID)
Values(@passenger_id,@train_no,@seat_no,@trip_ID)
end
Go

-----------------------------Procedure
Create Procedure InsertTrip_proc
(
@orig_station int,
@dest_station int,
@Trip_type varchar(255),     /* Popular or UnPopular Trip*/
@Fare int) as begin
Insert Into Trip(orig_station,dest_station,Trip_type,Fare)
Values(@orig_station,@dest_station,@Trip_type,@Fare)
end
Go

-----------------------------Procedure
Create Procedure InsertStation_proc
(
@station_name varchar(255),
@city varchar(255)
) as begin
Insert InTo Station(station_name,city)Values(@station_name,@city)
end
Go

-----------------------------Procedure
Drop Procedure InsertTickets_proc
GoCreate Procedure InsertTicket_proc
(
@passenger_id int,
@train_no int,
@seat_no int,
@trip_ID int,
@departure_time DateTime
)as begin
Insert into Ticket(passenger_id,train_no,seat_no,trip_ID,departure_time)
Values(@passenger_id,@train_no,@seat_no,@trip_ID,@departure_time)
end
-----------------------------Procedure
Go
Create Procedure InsertTrain_Info
(
@train_no int,
@departure_time DateTime,
@arrival_time DateTime,
@trip_id int
)
as begin
Insert Into Train_Info(train_no,departure_time,arrival_time,trip_id)
Values(@train_no,@departure_time,@arrival_time,@trip_id)
end
Go















-----------------------------------------------Insert Some Demo Values For Our Own Use(Informal)----------------------------------------------

Exec InsertUsers_proc 'User','Usman','Kabeer',21,'34502-7896374-9','uahmad565@gmail.com','03076331854','password',100
Exec InsertUsers_proc 'User','Osama','Ahmed',20,'304502','osama@gmail.com','452110','Khai',255
Exec InsertPassengers_proc 1
Exec InsertTrains_proc 'Express'
Exec InsertTrains_proc 'Z_Express'
Exec InsertSeats_proc 40,1
Exec InsertStation_proc 'LahoriStation','Lahore'
Exec InsertStation_proc 'FaislabadiStation','Faisalabad'
Exec InsertStation_proc 'KarachiStation','Karachi'
Exec InsertTrip_proc 1,2,'Popular',300
Exec InsertTrip_proc 2,3,'Popular',500
Exec InsertTicket_proc 1,1,1,1, '20210713 12:34:09 AM'
Exec InsertTicket_proc 1,1,2,1, '20210713 12:34:09 AM'
Exec InsertTicket_proc 1,1,2,1, '20200713 12:34:09 AM'
Exec InsertTicket_proc 1,2,1,1, '20210713 12:34:09 AM'
select * from Station
insert into Users values ('Admin','Admin','Khan',30,'33102-3456789-9','Adminkhan@gmail.com','0304-5852592','KhanSahib',0)

Exec InsertTrain_Info 1,'20210713 12:34:09 AM','20210714 12:34:09 PM',1
Exec InsertTrain_Info 2,'20210713 12:34:09 AM','20210714 12:34:09 PM',1
Exec InsertTrain_Info 2,'20210713 7:34:09 AM','20210713 7:34:09 AM',2
Go
insert into User_Feedback values(1,'Hello Sir Kaisy hain')
select * from User_Feedback
Select * From Ticket
Select * From Train_Info
Select * From Trip
Select * From Users
Select * From Passenger
Select * From Train
DBCC CHECKIDENT ('Train', RESEED, 2) 
Select * From Seats
DBCC CHECKIDENT ('Trip', RESEED, 3)  
Select * From Trip
delete from Train_Info
delete from Trip where trip_id>0 
select * from Station
--sp_help Ticket
Select train_name from Train
select station_name from Station
select station_name from Station

delete from Ticket where ticket_id>2

DBCC CHECKIDENT ('Ticket', RESEED, 2) 
delete from Passenger where passenger_id=4

