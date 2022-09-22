---New Queries
USE RMS
Go
Drop Procedure getStationID
Go
Create Procedure getStationID -----------------PROCEDURE
(@orig_station varchar(255))
as begin
 Declare @id varchar(255)
 Select @id= S.station_id
From Station S
where S.station_name=@orig_station
return @id
end

Go
Drop Procedure ShowTrainDetails
GO                         -----------------PROCEDURE              
Create Procedure ShowTrainDetails --Trains that are taking trip
(
@orig_station varchar(255),
@dest_station varchar(255)
)
as begin
Declare @id1 varchar(255)
Exec @id1=getStationID @orig_station 
Declare @id2 varchar(255)
Exec @id2=getStationID @dest_station 
Select TI.trip_id,TI.train_no,TI.departure_time,TI.arrival_time,T.Fare
From Trip T Join Train_Info TI On T.trip_id=TI.trip_id 
where TI.departure_time > GETDATE() AND T.orig_station=Convert(int,@id1) AND T.dest_station=Convert(int,@id2)
end
GO

Go
Exec ShowTrainDetails 'LahoriStation','FaislabadiStation'

Go
Drop Procedure ShowSeatsInformation
GO                         -----------------PROCEDURE              
Create Procedure ShowSeatsInformation--Trains that are taking trip
(
@train_no int,
@departure_time DateTime
)
as begin 
Select *
From Ticket
where Ticket.train_no=@train_no AND Ticket.departure_time=@departure_time
end
GO
Exec ShowSeatsInformation 1,'2021-07-13 00:34:09.000'


--Exec getStationID 'FaislabadiStation'
--Go
--Select * From Station

