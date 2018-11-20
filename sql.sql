

create database manageSell;
use manageSell;
 /* table staff…*/
create table tbl_staff(
idStaff char(6) not null,
nameStaff varchar(20) not null,
birthStaff date,
addressStaff varchar(100),
phoneStaff int not null,
genderStaff char(6) not null,


constraint unique_phoneStaff unique(phoneStaff),
constraint primary key(idStaff)
);

/*-------------------------------------------------------------*/
 /* table supply…*/
create table tbl_supply(
idSupply char (6) primary key not null,
nameSupply char (60) not null,
addressSupply char (44) not null,
phoneSupply char(10) not null
);


/*-------------------------------------------------------------*/

 /* table  product…*/
create table tbl_product(
idProduct int not null auto_increment primary key ,
nameProduct varchar (44) not null,
typeProduct char (22) not null,
sizeProduct char(10) not null,
leftOverProduct int not null,
colorProduct char (10)  not null,
priceInProduct int  not null,
priceOutProduct int  not null,
supplyProduct varchar(44),
note varchar (1000) ,
foreign key (supplyProduct) references tbl_supply(idSupply)
);
alter table tbl_product auto_increment = 1000;


/*-------------------------------------------------------------*/


 /* table customer …*/
create table tbl_customer(
idCustomer char(6) not null primary key ,
nameCustomer varchar(55) not null,
phoneCustomer varchar(10) not null
);


/*-------------------------------------------------------------*/
 /* table bill …*/
create table tbl_bill(
idBill char(6) not null primary key ,
idStaff char not null,
idCustomer char(6) not null,
dayOfSell datetime,
totallMoney int 
);

alter table tbl_bill
add foreign key (idStaff) references tbl_staff(idStaff);
alter table tbl_bill
add foreign key (idCustomer) references tbl_customer(idCustomer);

/*-------------------------------------------------------------*/

 /* table detail bill…*/
create table tbl_detailBill(
idBill char(6) not null,
idProduct int not null,
quantity int ,
price int ,
totalPrice int
);
alter table tbl_detailBill
add foreign key (idBill) references tbl_bill(idBill);
alter table tbl_detailBill
add foreign key (idProduct) references tbl_product(idProduct);

/*-------------------------------------------------------------*/
/* table manage total sales an price…*/
create table tbl_manageProduct(
idProduct int ,
totalSell int,
totalPrice int ,
profit int 

);
alter table tbl_manageProduct
 add foreign key (idProduct) references tbl_product(idProduct)
 
/*-------------------------------------------------------------*/