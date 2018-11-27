/*
  

*/
drop database quanlibanhang;
create database quanlibanhang;
use quanlibanhang;

/* ---- table Loai san pham--------------------------------*/
create table LOAISANPHAM(
Id int not null ,
TenLoai nvarchar(100)
);

alter table LOAISANPHAM
add constraint fk_LoaiSP primary key (Id);

alter table LOAISANPHAM
modify column  Id int auto_increment;

alter table LOAISANPHAM
auto_increment = 1;

insert into LOAISANPHAM(tenloai) 
values ('Quần');

insert into LOAISANPHAM(tenloai) 
values ('Áo');
insert into LOAISANPHAM(tenloai)  
values ('Giày');
insert into LOAISANPHAM(tenloai)  
values ('Dép');
insert into LOAISANPHAM (tenloai) 
values ('Áo Khoác');
select * from LOAISANPHAM ;

/*-----------select * from LOAISANPHAM ;----------------------------------------------------*/

/* ---- table Nhan vien--------------------------------*/
create table NHANVIEN(
Id  int not null ,
Ten nvarchar(59),
Phone char(10) unique,
NgaySinh date ,
DiaChi nvarchar(100),
Luong int,
NgayVaoLam date ,
GioiTinh nvarchar(4)
);
alter table NHANVIEN
add constraint fk_NhanVien primary key (Id);

alter table NHANVIEN
modify column  Id int auto_increment;

alter table NHANVIEN
auto_increment = 1;

insert into NHANVIEN(Ten,Phone,NgaySinh,DiaChi,Luong,NgayVaoLam,GioiTinh)
VALUES('Trương CHung TOàn','0333216635','1996/05/14','long bình - biên hòa - đồng nai',100000,'2018/12/12','Nam');
insert into NHANVIEN(Ten,Phone,NgaySinh,DiaChi,Luong,NgayVaoLam,GioiTinh)
VALUES('Trương Tiểu TOàn','0333236635','1996/05/14','long bình - biên hòa - đồng nai',100000,'2018/12/12','Nam');



/*---------------------------------------------------------------*/

/* ---- table Khach Hang--------------------------------*/
create table KHACHHANG(
Id int not null ,
Ten nvarchar(100),
DiaChi nvarchar(100),
Phone char(10),
GioiTinh nvarchar(4)
);

alter table KHACHHANG
add constraint fk_KhachHang primary key (Id);

alter table KHACHHANG
modify column  Id int auto_increment;

alter table KHACHHANG
auto_increment = 1;

insert into KHACHHANG(ten,diachi,phone,gioitinh)
values ('khách hàng 1 ','thanh hoa',2333335553,'nữ');
insert into KHACHHANG(ten,diachi,phone,gioitinh)
values ('khách hàng 2 ','thanh hoa',2335335553,'nữ');
insert into KHACHHANG(ten,diachi,phone,gioitinh)
values ('khách hàng 3 ','thanh hoa',2333777553,'nữ');
/*---------------------------------------------------------------*/

/* ---- table Nha cung cap--------------------------------*/
create table NHACUNGCAP(
Id int not null ,
Ten nvarchar(100),
DiaChi nvarchar(200),
Phone char(19) unique

);

alter table NHACUNGCAP
add constraint fk_NhaCungCap primary key (Id);

alter table NHACUNGCAP
modify column  Id int auto_increment;

alter table NHACUNGCAP
auto_increment = 1;
insert into NHACUNGCAP
values ('','Nha cung cấp 1 ','Biên hòa đồng nai',0156453333);
insert into NHACUNGCAP
values ('','Nha cung cấp 2 ','Biên hòa đồng nai',0156453334);

/*----------select * from NHACUNGCAP;-----------------------------------------------------*/

/* ---- table san pham--------------------------------*/

create table SANPHAM(
Id int not null ,
Ten nvarchar(100),
IdNhaCungCap int ,
IdLoaiSanPham int,
Size int,
MauSac nvarchar(15),
TongSoLuong int,
DoiTuongSuDung nvarchar(4),
note nvarchar(500)


);
alter table SANPHAM
add constraint Pk_SanPham primary key (Id);
alter table SANPHAM
add constraint fk_NhaCungCap foreign key (IdNhaCungCap) references NHACUNGCAP(Id);
alter table SANPHAM
add constraint fk_LoaiSanPham foreign key (IdLoaiSanPham) references LOAISANPHAM(Id);

alter table SANPHAM
modify column  Id int auto_increment;

alter table SANPHAM
auto_increment = 1;
insert into SANPHAM
values ('','Áo ba lỗ ',1,2,32,'red',100,'nữ','');
insert into SANPHAM
values ('','Áo thun ',1,2,32,'red',100,'nam','');
insert into SANPHAM
values ('','Quần jean ',1,1,32,'red',100,'nữ','');
insert into SANPHAM
values ('','Áo lửng ',1,1,32,'red',100,'nam','');
insert into SANPHAM
values ('','bitit hunter ',1,3,32,'red',100,'nữ','');
insert into SANPHAM
values ('','giày bóng ',1,3,32,'red',100,'nam','');

insert into SANPHAM
values ('','dép lê',1,4,32,'red',100,'nữ','');
insert into SANPHAM
values ('','dép tông xẹp tông',1,4,32,'red',100,'nam','');
insert into SANPHAM
values ('','Áo Khoác nỉ ',1,5,32,'red',100,'nữ','');
insert into SANPHAM
values ('','Áo khoác da ',1,5,32,'red',100,'nam','');

/*---------------------------------------------------------------*/



/* ---- table hoa don --------------------------------*/

create table HOADON(

Id  int not null ,
IdNhanVien int,
IdKhachHang int,
NgayLapHD date

);


alter table HOADON
add constraint fk_HoaDon primary key (Id);

alter table HOADON
add constraint fk_IdNhanVien foreign key (IdNhanVien) references NHANVIEN(Id);
alter table HOADON
add constraint fk_IdKhachHang foreign key (IdKhachHang) references KHACHHANG(Id);


alter table HOADON
modify column  Id int auto_increment;

alter table HOADON
auto_increment = 1;

INSERT INTO HOADON 
values('',1,1,2018/8/8);
INSERT INTO HOADON 
values('',2,2,2018/8/8);
INSERT INTO HOADON 
values('',1,2,2018/8/8);
/*---------------------------------------------------------------*/

/* ---- table Chi tiet hoa don--------------------------------*/
create table CHITIETHOADON(

IdHoaDon  int not null ,
IDSanPham int,
GiaBan double,
SoLuong int,
TongTien int 
);


alter table CHITIETHOADON
add constraint fk_IdHoaDon foreign key (IdHoaDon) references HOADON(Id);
alter table CHITIETHOADON
add constraint fk_IdSanPham foreign key (IDSanPham) references SANPHAM(Id);
INSERT INTO CHITIETHOADON
VALUES(1,1,20000,2,40000);
INSERT INTO CHITIETHOADON
VALUES(1,2,60000,2,120000);
INSERT INTO CHITIETHOADON
VALUES(2,3,30000,2,60000);
INSERT INTO CHITIETHOADON
VALUES(2,4,40000,1,40000);
/*---------------------------------------------------------------*/

/* ---- table Nhap Nhap Hang--------------------------------*/

create table HoaDonNhapHang(
IdHoaDonNhap int not null ,
IdNhaCungCap int ,
IdSanPham int,
SoLuong int,
DonGia double ,
GiaBan double not null ,
NgayNhap date
);
alter table HoaDonNhapHang
add constraint pk_HoaDonNhap primary key (IdHoaDonNhap);

alter table HoaDonNhapHang
add constraint fk_IdNhaCungCap foreign key (IdNhaCungCap) references NHACUNGCAP(Id);

alter table HoaDonNhapHang
add constraint fk_IdSanPhams foreign key (IdSanPham) references SANPHAM(Id);



alter table HoaDonNhapHang
modify column  IdHoaDonNhap int auto_increment;

alter table HoaDonNhapHang
auto_increment = 1;


insert into hoadonnhaphang 
values ('',1 ,1,100,10000,20000,'2018,2,11');
insert into hoadonnhaphang 
values ('',1 ,2,100,10000,60000,'2018,2,11');
insert into hoadonnhaphang 
values ('',1 ,3,100,10000,30000,'2018,2,11');
insert into hoadonnhaphang 
values ('',1 ,4,100,10000,40000,'2018,2,11');
insert into hoadonnhaphang 
values ('',1 ,5,100,10000,50000,'2018,2,11');
insert into hoadonnhaphang 
values ('',1 ,6,100,10000,20000,'2018,2,11');
insert into hoadonnhaphang 
values ('',1 ,7,100,10000,60000,'2018,2,11');
insert into hoadonnhaphang 
values ('',1 ,8,100,10000,30000,'2018,2,11');
insert into hoadonnhaphang 
values ('',1 ,9,100,10000,40000,'2018,2,11');
insert into hoadonnhaphang 
values ('',1 ,10,100,10000,50000,'2018,2,11');
/*---------------------------------------------------------------*/
/*------------------- KHU VỰC TEST QUERY--------------------------------------------*/
select SANPHAM.* ,LOAISANPHAM.tenLoai,giaban from SANPHAM, LOAISANPHAM ,HoaDonNhapHang where SANPHAM.idLOAISANPHAM = LOAISANPHAM.id and sanpham.id=hoadonnhaphang.IdSanPham;
select * from HoaDonNhapHang;
select * from sanpham;