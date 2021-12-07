

create table NAMHOC
{
	MaNamHoc char(8) primary key,
	TenNamHoc varchar(40)

}

create table HOCKY
{
	MaHocKy char(6) primary key,
	TenHK varchar(20),
	HeSoHK int

}

create table KHOILOP
{
	MaKhoi char(6) primary key,
	TenKhoi varchar(20)

}

create table LOPHOC
{
	MaLop char(6) primary key,
	TenLop varchar(20),
	MaNH char(8),
	MaHKchar(6),
	SiSo int,
	MaGVCN char(8)
}

create table MONHOC
{
	MaMH char(8) primary key,
	TenMH varchar(30),
	HeSoMH int
}

create table KQHOCKY
{
	MaHS char(8),
	MaHK char(8),
	DTBHocKy float,
	MaHocLuc char(8),
	MaHanhKiem char(8),
	MaKetQua char(8)
}

create table KETQUA
{
	MaKetQua char (8) primary key,
	TenKetQua varchar(20)

}

create table KQHOCKYMONHOC
{
	MaKQHocKy char(8) primary key,
	MaHS char(8) primary key,
	MaMonHoc char(8),
	MaHocKy char(8),
	DiemTBMon
}

create table DIEM
{
	MaKQHocKy char(8) primary key,
	MaLoai char(8) primary key,
	Diem int
}

create table LOAIDIEM
{
	MaLoai char(8) primary key,
	TenLoai varchar(20),
	HeSo int
}

create table KQCANAMMONHOC
{
	MaHS char(8)  primary key,
	MaMH char(8)  primary key,
	DTBCaNam float
}
create ta


