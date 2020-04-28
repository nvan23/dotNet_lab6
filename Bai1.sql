Create Database DVDLibrary
Use DVDLibrary
Create Table DVDLibrary(
	DVDCodeNo int Primary Key,
	DVDTitle nvarchar(100) Not Null,
	[Language] nvarchar(20) Not Null,
	SubTitle bit Not Null,
	Price Money Not Null
)


Create Login mylogin with password = 'mylogin', CHECK_POLICY = OFF
Use DVDLibrary
sp_changedbowner mylogin

select * from DVDLibrary


