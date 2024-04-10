create login mylogin with password = 'mylogin', check_policy = off
sp_changedbowner mylogin

drop database QLCB

create database QLCB
use QLCB
use master

create table CanBo(
	MaCB int primary key IDENTITY(1,1),
	TenCB nvarchar(50) not null,
	ChucVuCB int not null,
	SoGoGiang int not null,
	DonGia money not null
	foreign key (ChucVuCB) references ChucVu(MaCV) on update cascade on delete cascade
);

create table ChucVu (
	MaCV int primary key IDENTITY(1,1),
	TenCV nvarchar(50) not null
);

select * from CanBo
select * from ChucVu

INSERT INTO ChucVu VALUES (N'Giảng viên');
INSERT INTO ChucVu VALUES (N'Trợ giảng cao cấp');
INSERT INTO ChucVu VALUES (N'Trợ giảng');
INSERT INTO ChucVu VALUES (N'Thực tập sinh');

INSERT INTO CanBo VALUES(N'Nguyễn Thanh Tài', 1, 100, 100000);
INSERT INTO CanBo VALUES(N'Trần Trọng Nhân', 3, 40, 70000);
INSERT INTO CanBo VALUES(N'Cao Văn Minh', 1, 20, 50000);
INSERT INTO CanBo VALUES(N'Đỗ Thu Minh', 2, 335, 200000);
INSERT INTO CanBo VALUES(N'Đinh Cao Ngọc', 4, 69, 40000);


set IDENTITY_INSERT  CanBo ON