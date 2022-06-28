use master
go
create database QuanLyPhongTro
go
use QuanLyPhongTro
go
create table Phong(
    Id int primary key identity ,
    Tang int,
    Gia int
)
go
create table NguoiThue(
    Id int primary key identity ,
    HoTen nvarchar(50),
    NgaySinh nvarchar(30),
    DiaChi nvarchar(100),
    SDT char(10)
)
go
create table ThuePhong(
    Id int primary key identity,
    NgayThue nvarchar(30),
    IdNguoiThue int not null,
    IdPhongThue int not null,
    TrangThai int
)
go
create table HoaDonDongTien(
    Id int primary key identity,
    IdPhong int not null,
    SoDien int,
    SoNuoc int,
    NgayDong nvarchar(30)
)
create table TaiKhoan
(
    TenDangNhap nvarchar(20) primary key,
    MatKhau     nvarchar(20) not null,
    LoaiTK      nvarchar(10)
)
go
insert into TaiKhoan values('admin','admin','admin')
