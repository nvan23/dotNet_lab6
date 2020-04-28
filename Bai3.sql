Create database ThanhToan;
use ThanhToan;

create table Phong(
	MaPhong int Primary Key,
	TenPhong nvarchar(10) not null,
)

Insert into Phong values(1, 'P01');
Insert into Phong values(2, 'P02');
Insert into Phong values(3, 'P03');
Insert into Phong values(4, 'P04');
Insert into Phong values(5, 'P05');
Insert into Phong values(6, 'P06');


create table KhachHang(
	SoHD int Primary key,
	TenKH nvarchar (100) not null,
	SoCMND int not null,
	SoTien money not null,
	NgayTT datetime not null,
	Phong int not null,

	Foreign Key (Phong) references Phong(MaPhong)
)

Select * from KhachHang
Select * from Phong