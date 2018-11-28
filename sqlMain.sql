/*
 */ 
drop database quanlibanhang;


create database quanlibanhang;
use quanlibanhang;

/* ---- table Loai san pham--------------------------------*/
create table LOAISANPHAM(
IdLoai int not null ,
TenLoai nvarchar(100)
);

alter table LOAISANPHAM
add constraint fk_LoaiSP primary key (IdLoai);

alter table LOAISANPHAM
modify column  IdLoai int auto_increment;

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
IdNV  int not null ,
TenNV nvarchar(59),
PhoneNV char(10) unique,
NgaySinhNV date ,
DiaChiNV nvarchar(100),
LuongNV int,
NgayVaoLam date ,
GioiTinhNV nvarchar(4)
);
alter table NHANVIEN
add constraint fk_NhanVien primary key (IdNV);

alter table NHANVIEN
modify column  IdNV int auto_increment;

alter table NHANVIEN
auto_increment = 1;

insert into NHANVIEN
VALUES('','Trương CHung TOàn','0333216635','1996/05/14','long bình - biên hòa - đồng nai',100000,'2018/12/12','Nam');
insert into NHANVIEN
VALUES('','Trương Tiểu TOàn','0333236635','1996/05/14','long bình - biên hòa - đồng nai',100000,'2018/12/12','Nam');



/*---------------------------------------------------------------*/

/* ---- table Khach Hang--------------------------------*/
create table KHACHHANG(
IdKH int not null ,
TenKH nvarchar(100),
DiaChiKH nvarchar(100),
PhoneKH char(10),
GioiTinhKH nvarchar(4)
);

alter table KHACHHANG
add constraint fk_KhachHang primary key (IdKH);

alter table KHACHHANG
modify column  IdKH int auto_increment;

alter table KHACHHANG
auto_increment = 1;

insert into KHACHHANG
values ('','khách hàng 1 ','thanh hoa',2333335553,'nữ');
insert into KHACHHANG
values ('','khách hàng 2 ','thanh hoa',2335335553,'Nam');
insert into KHACHHANG
values ('','khách hàng 3 ','thanh hoa',2333777553,'nữ');
/*---------------------------------------------------------------*/

/* ---- table Nha cung cap--------------------------------*/
create table NHACUNGCAP(
IdNCC int not null ,
TenNCC nvarchar(100),
DiaChiNCC nvarchar(200),
PhoneNCC char(19) unique

);

alter table NHACUNGCAP
add constraint fk_NhaCungCap primary key (IdNCC);

alter table NHACUNGCAP
modify column IdNCC int auto_increment;

alter table NHACUNGCAP
auto_increment = 1;
insert into NHACUNGCAP
values ('','Nha cung cấp 1 ','Biên hòa đồng nai',0156453333);
insert into NHACUNGCAP
values ('','Nha cung cấp 2 ','Biên hòa đồng nai',0156453334);

/*----------select * from NHACUNGCAP;-----------------------------------------------------*/

/* ---- table san pham--------------------------------*/

create table SANPHAM(
IdSP int not null ,
TenSP nvarchar(100),
IdNhaCungCap int ,
IdLoaiSanPham int,
Size int,
MauSac nvarchar(15),
TongSoLuongSP int,
DoiTuongSuDung nvarchar(4),
note nvarchar(500)


);
alter table SANPHAM
add constraint Pk_SanPham primary key (IdSP);
alter table SANPHAM
add constraint fk_NhaCungCap foreign key (IdNhaCungCap) references NHACUNGCAP(IdNCC);
alter table SANPHAM
add constraint fk_LoaiSanPham foreign key (IdLoaiSanPham) references LOAISANPHAM(IdLoai);

alter table SANPHAM
modify column  IdSP int auto_increment;

alter table SANPHAM
auto_increment = 1;
insert into SANPHAM
values ('','Áo ba lỗ ',1,2,32,'red',100,'nữ','');
insert into SANPHAM
values ('','Áo thun ',1,2,34,'green',100,'nam','');
insert into SANPHAM
values ('','Quần jean ',1,1,34,'blue',100,'nữ','');
insert into SANPHAM
values ('','Áo lửng ',1,1,32,'white',100,'nam','');
insert into SANPHAM
values ('','bitit hunter ',1,3,26,'red',100,'nữ','');
insert into SANPHAM
values ('','giày bóng ',1,3,41,'green',100,'nam','');

insert into SANPHAM
values ('','dép lê',1,4,42,'blue',100,'nữ','');
insert into SANPHAM
values ('','dép tông xẹp tông',1,4,45,'red',100,'nam','');
insert into SANPHAM
values ('','Áo Khoác nỉ ',1,5,33,'white',100,'nữ','');
insert into SANPHAM
values ('','Áo khoác da ',1,5,32,'brow',100,'nam','');

/*---------------------------------------------------------------*/

/* ---- table hoa don --------------------------------*/

create table HOADON(

IdHD  int not null ,
IdNhanVien int,
IdKhachHang int,
NgayLapHD date,
TongTien int 

);


alter table HOADON
add constraint fk_HoaDon primary key (IdHD);

alter table HOADON
add constraint fk_IdNhanVien foreign key (IdNhanVien) references NHANVIEN(IdNV);
alter table HOADON
add constraint fk_IdKhachHang foreign key (IdKhachHang) references KHACHHANG(IdKH);


alter table HOADON
modify column  IdHD int auto_increment;

alter table HOADON
auto_increment = 1;

/*---------------------------------------------------------------*/

/* ---- table Chi tiet hoa don--------------------------------*/
create table CHITIETHOADON(

IdHoaDon  int not null ,
IDSanPham int,
GiaBan double,
SoLuong int
);


alter table CHITIETHOADON
add constraint fk_IdHoaDon foreign key (IdHoaDon) references HOADON(IdHD);
alter table CHITIETHOADON
add constraint fk_IdSanPham foreign key (IDSanPham) references SANPHAM(IdSP);


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
add constraint fk_IdNhaCungCap foreign key (IdNhaCungCap) references NHACUNGCAP(IdNCC);

alter table HoaDonNhapHang
add constraint fk_IdSanPhams foreign key (IdSanPham) references SANPHAM(IdSP);



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

/*---------------------------------------------------------------*/

INSERT INTO HOADON 
values('',1,1,'2018/8/8',160000);
INSERT INTO HOADON 
values('',2,2,'2018/8/8',60000);
INSERT INTO HOADON 
values('',1,2,'2018/8/8',40000);
INSERT INTO HOADON 
values('',1,2,'2018/8/8',40000);
INSERT INTO HOADON 
values('',1,2,'2018/8/8','');



INSERT INTO CHITIETHOADON
VALUES(1,1,20000,2);
INSERT INTO CHITIETHOADON
VALUES(1,2,60000,2);
INSERT INTO CHITIETHOADON
VALUES(2,3,30000,2);
INSERT INTO CHITIETHOADON
VALUES(3,4,40000,1);
INSERT INTO CHITIETHOADON
VALUES(5,4,'10000',2);
select * from CHITIETHOADON;

/*------------------- KHU VỰC TEST QUERY--------------------------------------------*/

update HoaDon  set hoadon.tongtien=(select soluong * giaban from chitiethoadon  where hoadon.idHD=chitiethoadon.idhoadon);
