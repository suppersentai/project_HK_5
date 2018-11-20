
create database manageSell;
use manageSell; 

create table tbl_Staff(
idStaff char not null,
nameStaff varchar(20) not null,
birthStaff date,
addressStaff varchar(100),
phoneStaff int not null,
genderStaff char(6) not null,

constraint unique_phoneStaff unique(phoneStaff),
constraint primary key(idStaff)
);

create table tbl_product(
idProduct int not null  ,
nameProduct varchar (44) not null,
typeProduct char (22) not null,
sizeProduct char(10) not null,
leftOverProduct int not null,
colorProduct char (10)  not null,
soldProduct int not null,
priceInProduct int  not null,
priceOutProduct int  not null,
note varchar (1000) 

);

alter table tbl_product 
add Constraint fk_product primary key (idProduct);

create table test(
id int auto_increment
);
alter table tbl_Staff auto_increment = 1000;
select * from tbl_Staff;


insert into tbl_Staff (idStaff,nameStaff,birthStaff,addressStaff,phoneStaff,hdldStaff)
 values('Truong chung toan','1996/14/05/','long binh -bien hoa -dong nai',0333216634,'hd333');
 
 insert into tbl_Staff (idStaff,nameStaff,birthStaff,addressStaff,phoneStaff,hdldStaff)
 values('','Truong chung toan','1996/05/14','long binh -bien hoa -dong nai',0333216635,'hd333');
 
 insert into tbl_Staff (nameStaff,birthStaff,addressStaff,phoneStaff,hdldStaff)
 values('Truong chung toan','1996/05/14','long binh -bien hoa -dong nai',0333216636,'hd333');