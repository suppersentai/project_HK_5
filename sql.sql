/*
NV = nhân viên
SP= nhà cung cấp
TP = loại sản phẩm
CT = khách hàng 

id > 100 = id product;
id>500 = id bill/
drop database managesell;
*/

create database manageSell;
use manageSell;
 /* table staff…*/
create table tbl_staff(
idStaff char(6) not null,
nameStaff nvarchar(20) not null,
birthStaff date,
addressStaff nvarchar(100),
phoneStaff char (10),
genderStaff nvarchar(6) not null,
constraint unique_phoneStaff unique(phoneStaff), /* unique : phone không ddk trùng lặp*/
constraint primary key(idStaff)
);

insert into tbl_staff 
values ('NV001','Trương Tiểu Toàn','1996/05/14','long binh',0333215535,'boy');

insert into tbl_staff (idStaff,nameStaff,birthStaff,addressStaff,phoneStaff,genderStaff) 
values ('NV002','Trương Tiểu Toàn','1996/05/14','long binh',0333215534,'boy');


/*-------------------------------------------------------------*/
 /* table supply…*/
create table tbl_supply(
idSupply char (6) primary key not null,
nameSupply nvarchar (60) not null,
addressSupply nvarchar (44) not null,
phoneSupply char(10) not null unique
);

insert into tbl_supply
values('SP001','Nhà Cung Cấp 1','long bình - biên hòa - đồng nai','0251222333');
insert into tbl_supply
values('SP002','Nhà Cung Cấp 2','long bình - biên hòa - đồng nai','0251222334');

/*-------select * from tbl_supply;------------------------------------------------------*/


 /* table  type…*/
 create table tbl_typeProduct(
 idType char (6) not null primary key,
 nameType nvarchar(44) not null
 );
 
 insert into tbl_typeProduct
 values('TP001','Quần');
 insert into tbl_typeProduct
 values('TP002','Áo');
/*-------------------------------------------------------------*/

 /* table  product…*/
create table tbl_product(
idProduct int not null auto_increment primary key ,
nameProduct nvarchar (44) not null,
idType char (6) not null  ,/* loại sp : ví dụ như : áo ,quần , mũ , nón*/
sizeProduct char(10) not null,
leftOverProduct int not null,/*số lượng hàng tồn trong kho*/
colorProduct nvarchar (10)  not null,
priceInProduct int  not null,/* giá nhập vào*/
priceOutProduct int  not null,/*giá bán ra*/
idsupply char(6),/* Nhà cung cấp*/ 
note nvarchar (1000) ,/*Ghi chú nếu có*/
foreign key (idsupply) references tbl_supply(idSupply)
);
alter table tbl_product auto_increment = 1000;
alter table tbl_product 
add foreign key (idType) references tbl_typeProduct(idType);


insert into tbl_product (nameProduct,idType,sizeProduct,leftOverProduct,colorProduct,priceInProduct,priceOutProduct,idsupply,note)
values ('Áo bà ba','TP001','32',100,'red',10000,20000,'SP001','chua co note');

insert into tbl_product (nameProduct,idType,sizeProduct,leftOverProduct,colorProduct,priceInProduct,priceOutProduct,idsupply,note)
values ('Quần xì ','TP002','39',100,'green',20000,30000,'SP002','chua co note');

/*----select * from tbl_product;---------------------------------------------------------*/


 /* table customer …*/

create table tbl_customer(
/* cái này thu thập  thông tinh khách hàng  ,,*/
idCustomer char(6) not null primary key ,
nameCustomer nvarchar(55) not null,
phoneCustomer char(10) not null 
);

insert into tbl_customer 
values ('CT001','Tiểu Phàm',0123456789);
insert into tbl_customer 
values ('CT002','Tiểu Phàm',0123456780);

/*-------------------------------------------------------------*/
 /* table bill …*/

create table tbl_bill(
idBill int not null primary key ,
idStaff char (6)not null,
dayOfSell datetime,
totallMoney int 
);

alter table tbl_bill 
change idBill idBill int not null auto_increment;
alter table tbl_bill auto_increment 5000;
alter table tbl_bill
add foreign key (idStaff) references tbl_staff(idStaff);
/*alter table tbl_bill
add foreign key (idCustomer) references tbl_customer(idCustomer);
*/

insert into tbl_bill(idStaff,dayOfSell,totallMoney)
values('NV001','2018/11/1',60000);

insert into tbl_bill(idStaff,dayOfSell,totallMoney)
values('NV001','2018/11/1',60000);


/*---------select * from tbl_bill----------------------------------------------------*/

 /* table detail bill…*/

create table tbl_detailBill(
idBill int not null,
idProduct int not null,
quantity int ,
price int 
);

alter table tbl_detailBill
add constraint fk_detailBill_idBill foreign key (idBill) references tbl_bill(idBill);
alter table tbl_detailBill 
add  constraint fk_detailBill_idproduct foreign key (idProduct) references tbl_product(idProduct);

insert into tbl_detailBill
values(5000,'1000',3,10000);
insert into tbl_detailBill
values(5001,'1001',2,30000);

/*------ select * from tbl_product;-------------------------------------------------------*/
/* table manage total sales an price…*/
create table tbl_manageProduct(
idProduct int ,
totalSell int,/* quản lí số lượng sản phẩm đã bán đk bao nhiêu*/
totalPrice int ,/*Tổng doanh thu cả vốn lẫn lãi*/
profit int /*Lợi nhuận*/

);

alter table tbl_manageProduct
 add constraint fk_manageProduct foreign key (idProduct) references tbl_product(idProduct);
 insert into tbl_manageProduct 
 values(1000,3,60000,30000);
 insert into tbl_manageProduct 
 values(1001,2,60000,30000);
/*-------------------------------------------------------------*/