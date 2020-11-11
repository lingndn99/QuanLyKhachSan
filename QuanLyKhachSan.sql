/*Create Database*/
CREATE DATABASE quanlykhachsan
GO
/*Create Table*/
USE quanlykhachsan
GO
/*Create Table tbl_TaiKhoan*/
IF OBJECT_ID('tbl_TaiKhoan') IS NOT NULL
       DROP TABLE tbl_TaiKhoan
CREATE TABLE tbl_TaiKhoan(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Account VARCHAR(50) NOT NULL,
	Password VARCHAR(50) NOT NULL,
	Deleted BIT NULL
	)
GO
/* Create Table tbl_Phong*/
IF OBJECT_ID('tbl_Phong') IS NOT NULL
       DROP TABLE tbl_Phong
CREATE TABLE tbl_Phong(
	MaPhong NCHAR(10) PRIMARY KEY,
	TenPhong NVARCHAR(50) NOT NULL,
	LoaiPhong NVARCHAR(50) NOT NULL,
	Gia FLOAT NOT NULL,
	TrangThai NCHAR(10) NOT NULL,
	Deleted BIT NULL
	)
GO	
/*Create Table tbl_KhachHang*/
IF OBJECT_ID('tbl_KhachHang') IS NOT NULL
       DROP TABLE tbl_KhachHang
CREATE TABLE tbl_KhachHang(
	MaKhachHang NCHAR(10) PRIMARY KEY,
	TenKhach NVARCHAR(50) NOT NULL,
	DiaChi NVARCHAR(50) NOT NULL,
	CMND VARCHAR(11) NOT NULL,
	SDT VARCHAR(10) NOT NULL,
	Deleted BIT NULL
	)
GO	
/*Create Table tbl_NhanVien*/
IF OBJECT_ID('tbl_NhanVien') IS NOT NULL
       DROP TABLE tbl_NhanVien
CREATE TABLE tbl_NhanVien(
	MaNhanVien NCHAR(10) PRIMARY KEY,
	TenNhanVien NVARCHAR(50) NOT NULL,
	DiaChi NVARCHAR(50) NOT NULL,
	CMND VARCHAR(11) NOT NULL,
	SDT VARCHAR(10) NOT NULL,
	Deleted BIT NULL
	)
GO	
/*Create Table tbl_DichVu*/
IF OBJECT_ID('tbl_DichVu') IS NOT NULL
       DROP TABLE tbl_DichVu
CREATE TABLE tbl_DichVu(
	MaDichVu NCHAR(10) PRIMARY KEY,
	TenDichVu NVARCHAR(50) NOT NULL,
	Gia FLOAT(50) NOT NULL,
	Deleted BIT NULL
	)
GO

/*Create Table tbl_PhieuDangKy*/
IF OBJECT_ID('tbl_PhieuDangKy') IS NOT NULL
       DROP TABLE tbl_PhieuDangKy
CREATE TABLE tbl_PhieuDangKy(
	MaPhieuDat NCHAR(10) PRIMARY KEY,
	TenKhach NVARCHAR(50) NOT NULL,
	SDT VARCHAR(10) NOT NULL,
	NgayDangKy DATETIME NOT NULL,
	NgayHenNhan DATETIME NOT NULL,
	MaNhanVien NCHAR(10) NOT NULL,
	MaPhong NCHAR(10) NOT NULL,
	Deleted BIT NULL
	)
GO	
/*Create Table tbl_PhieuNhanPhong*/
IF OBJECT_ID('tbl_PhieuNhanPhong') IS NOT NULL
       DROP TABLE tbl_PhieuNhanPhong
CREATE TABLE tbl_PhieuNhanPhong(
	MaPhieuNhan NCHAR(10) PRIMARY KEY,
	MaNhanVien NCHAR(10) NOT NULL,
	MaKhachHang NCHAR(10) NOT NULL,
	MaPhong NCHAR(10) NOT NULL,
	Deleted BIT NULL
	)
GO	
/*Create Table tbl_HoaDon*/
IF OBJECT_ID('tbl_HoaDon') IS NOT NULL
       DROP TABLE tbl_HoaDon
CREATE TABLE tbl_HoaDon(
	MaHoaDon NCHAR(10) PRIMARY KEY,
	MaNhanVien NCHAR(10) NOT NULL,
	MaKhachHang NCHAR(10) NOT NULL,
	MaPhong NCHAR(10) NOT NULL,
	MaDichVu NCHAR(10) NOT NULL,
	ThanhTien FLOAT NOT NULL,
	Deleted BIT NULL
	)
GO	





