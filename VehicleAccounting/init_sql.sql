CREATE DATABASE car_library;
Use car_library;

create Table car_brand (
                           id bigint primary key auto_increment,
                           name varchar(150) NOT NULL);

create Table car_model (
                           id bigint primary key auto_increment,
                           name varchar(150) NOT NULL,
                           car_brand_id bigint,
                           foreign key (car_brand_id) references car_brand (id));

create Table car_owner (
                           id bigint primary key auto_increment,
                           first_name varchar(250)NOT NULL,
                           last_name varchar(250) not null,
                           pasport_number varchar(250) NOT null
);

Create table car (
                     id bigint primary key auto_increment,
                     brand_id bigint NOT null,
                     model_id bigint NOT null,
                     owner_id bigint,
                     number_car varchar(15),
                     year_car int NOT null,
                     engine_volume float NOT NUll,
                     foreign key (brand_id) references car_brand(id),
                     foreign key (model_id) references car_model (id),
                     foreign key (owner_id) references car_owner (id)
);

insert into car_brand (name) values ("BMW");
insert into car_brand (name) values ("Mersedes");
insert into car_brand (name) values ("Honda");

insert into car_model (name, car_brand_id) values ("X7", 1);
insert into car_model (name, car_brand_id) values ("X5", 1);
insert into car_model (name, car_brand_id) values ("X5M", 1);
insert into car_model (name, car_brand_id) values ("X3", 1);
insert into car_model (name, car_brand_id) values ("M3", 1);
insert into car_model (name, car_brand_id) values ("M5", 1);
insert into car_model (name, car_brand_id) values ("M8", 1);

insert into car_model (name, car_brand_id) values ("S221", 2);
insert into car_model (name, car_brand_id) values ("S222", 2);
insert into car_model (name, car_brand_id) values ("S223", 2);
insert into car_model (name, car_brand_id) values ("CLA 45S AMG", 2);
insert into car_model (name, car_brand_id) values ("Maybach GLS", 2);

