create database TestHanhKiem
use TestHanhKiem

create table HANHKIEM
(
    MAHS int,
	MALOP nvarchar(10),
	MAHK int,
	MANAMHOC int,
	HANHKIEM nvarchar(10),
	constraint PK_DIEMTB primary key (MALOP,MANAMHOC,MAHK,MAHS)
)


create table HSHS
(
	MAHS int identity(1,1),
	HOTEN nvarchar(40),
	DIACHI nvarchar(40),
	NGAYSINH smalldatetime,
	GIOITINH nvarchar(40),
	TONGIAO nvarchar(40),
	DANTOC nvarchar(40),
	HOTENCHA nvarchar(40),
	NGHENGHIEPCHA nvarchar(40),
	HOTENME nvarchar(40),
	NGHENGHIEPME nvarchar(40),
	MANAMHOC int,
	constraint PK_HSHS primary key (MAHS)
)

create table LOP
(
    MALOP nvarchar(10),
	SISO int,
)

UPDATE HANHKIEM 
SET HANHKIEM = 'Tốt' 
where  MAHS = 1 and MALOP= '10A1' and MANAMHOC = 2018 and MAHK = 1