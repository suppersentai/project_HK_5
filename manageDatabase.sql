create database manageSell;
use manageSell;
create table tbl_Staff(
idStaff int not null auto_increment,
nameStaff varchar(20) not null,
birthStaff date,
addressStaff varchar(100),
phoneStaff int not null,
hdldStaff char(10),

constraint unique_phoneStaff unique(phoneStaff),
constraint primary key(idStaff)
);

alter table tbl_Staff auto_increment = 1000;
select * from tbl_Staff;


insert into tbl_Staff (idStaff,nameStaff,birthStaff,addressStaff,phoneStaff,hdldStaff)
 values('Truong chung toan','1996/14/05/','long binh -bien hoa -dong nai',0333216634,'hd333');
 
 insert into tbl_Staff (idStaff,nameStaff,birthStaff,addressStaff,phoneStaff,hdldStaff)
 values('','Truong chung toan','1996/05/14','long binh -bien hoa -dong nai',0333216635,'hd333');
 
 insert into tbl_Staff (nameStaff,birthStaff,addressStaff,phoneStaff,hdldStaff)
 values('Truong chung toan','1996/05/14','long binh -bien hoa -dong nai',0333216636,'hd333');