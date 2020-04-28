drop database QLCB;
Create database QLCB;
use QLCB;

create table ChucVu(
	MaCV int not null primary key,
	TenCV nvarchar(50),
)

create table CanBo(
	MaCB int not null primary key,
	TenCB nvarchar(30),
	ChucVuCB int not null,
	SoGioGiang int check(SoGioGiang >=0),
	DonGia money,

	constraint fk_CanBo_ChucVu
	foreign key (ChucVuCB)
	references ChucVu(MaCV)
	on update cascade
	on delete cascade,
)

insert into ChucVu values(1, N'Giảng Viên');
insert into ChucVu values(2, N'Trưởng Ban');
insert into ChucVu values(3, N'Cán Bộ');

select * from CanBo