CREATE DATABASE QUAN_LI_HOC_VIEN
GO
USE QUAN_LI_HOC_VIEN
GO

CREATE TABLE NGUOI_DUNG(
    TenDangNhap NVARCHAR(30) not null primary key,
    MatKhau NVARCHAR(30) not null,


)
GO
insert into dbo.NGUOI_DUNG(TenDangNhap,MatKhau) values('admin','admin')
insert into dbo.NGUOI_DUNG(TenDangNhap,MatKhau) values('staff','staff')
GO 