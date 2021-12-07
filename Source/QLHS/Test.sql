create database Test
use Test
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
	constraint PK_HSHS primary key (MAHS,MANAMHOC)
)
insert into HSHS values (0001,N'Nguyen Van A',N'ASDASDASD','3/15/1997',N'Nam',N'Không',N'Kinh',N'Nguyễn Văn B',N'Công Nhân',N'Nguyễn Thị C',N'Nội trợ',2018)
set dateformat dmy
select * from HSHS order by MAHS desc
update HSHS set HOTEN = 1, DIACHI= 2 where MAHS = 5 
UPDATE HSHS SET HOTEN = 'Tung 12', DIACHI = 'asdasdasd', NGAYSINH = '1/1/2000', GIOITINH = 'Nam', TONGIAO = N'Phật Giáo', DANTOC = 'Kinh', HOTENCHA='asdasda', NGHENGHIEPCHA='asdasd',HOTENME='asdasd',NGHENGHIEPME='asadasd',MANAMHOC= 2015 