CREATE TABLE GoodsGroups (
id int not null PRIMARY KEY,
name varchar(10) not null
);

CREATE TABLE Goods (
id int not null PRIMARY KEY,
name varchar(30) not null,
"group" int not null
FOREIGN KEY ("group") REFERENCES GoodsGroups(id)
);


CREATE TABLE GoodsSales  (
id int not null PRIMARY KEY,
good_id int not null,
quantity int not null,
sale_date date not null
FOREIGN KEY (good_id) REFERENCES Goods(id)
);