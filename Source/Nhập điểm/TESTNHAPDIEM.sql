create database TestNhapDiem
use TestNhapDiem

create table BANGDIEM
(
    MAHS int,
	MALOP nvarchar(10),
	MAHK int,
	MAMONHOC nvarchar(10),
	MANAMHOC int,
	KTM1 float NULL,
	KTM2 float NULL,
	KTM3 float NULL,
	KTM4 float NULL,
	KTM5 float NULL,
	KT15P1 float NULL,
	KT15P2 float NULL,
	KT15P3 float NULL,
	KT15P4 float NULL,
	KT15P5 float NULL,
	KT15P6 float NULL,
	KT1T1 float NULL,
	KT1T2 float NULL,
	KT1T3 float NULL,
	KT1T4 float NULL,
	KT1T5 float NULL,
	KT1T6 float NULL,
	DIEMTB float NULL,
	DIEMTHI float NULL,
	constraint PK_DIEMTB primary key (MALOP,MANAMHOC,MAHK,MAMONHOC)
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


select HSHS.MAHS, HOTEN, KTM1, KTM2, KTM3, KTM4, KTM5, KT15P1, KT15P2, KT15P3, KT15P4, KT15P5, KT15P6, KT1T1, KT1T2, KT1T3, KT1T4, KT1T5, KT1T6, DIEMTHI, DIEMTB
from HSHS, BANGDIEM
where HSHS.MAHS = BANGDIEM.MAHS