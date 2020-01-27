CREATE TABLE Role (
  Id INTEGER PRIMARY KEY IDENTITY,
  Name VARCHAR(20) NOT NULL,
);

CREATE TABLE Convenience (
  Id INTEGER PRIMARY KEY IDENTITY,
  ConvName VARCHAR(20) NOT NULL,
);

CREATE TABLE Hotel (
  Id INTEGER PRIMARY KEY IDENTITY,
  Name VARCHAR(100) NOT NULL,
  City VARCHAR(50) NOT NULL,
  Address VARCHAR(200) NOT NULL,
  Rating INTEGER,
  CONSTRAINT hotel_class CHECK (Rating IN (1, 2, 3, 4, 5))
);

CREATE TABLE ConvHotel (
  Id INTEGER PRIMARY KEY IDENTITY,
  ConvId INTEGER,
  HotelId INTEGER,
  CONSTRAINT ch_fk1 FOREIGN KEY (ConvId) REFERENCES Convenience (Id),
  CONSTRAINT ch_fk2 FOREIGN KEY (HotelId) REFERENCES Hotel (Id)
);

CREATE TABLE [User] (
  Id INTEGER PRIMARY KEY IDENTITY,
  RoleId INTEGER,
  Login VARCHAR(100) NOT NULL,
  PasswordHash VARCHAR(128) NOT NULL,
  Name VARCHAR(30),
  Surname VARCHAR(30),
  Email VARCHAR(50),
  Phone VARCHAR(20),
  CONSTRAINT user_fk FOREIGN KEY (RoleId) REFERENCES Role (Id)
);

CREATE TABLE Room (
  Id INTEGER PRIMARY KEY IDENTITY,
  HotelId INTEGER,
  Number INTEGER,
  Price INTEGER,
  RoomType VARCHAR(25) NOT NULL,
  CONSTRAINT room_fk FOREIGN KEY (HotelId) REFERENCES Hotel (Id),
  CONSTRAINT room_number CHECK (Number > 0),
  CONSTRAINT room_price CHECK (Price > 0)
);

CREATE TABLE Booking (
  Id INTEGER PRIMARY KEY IDENTITY,
  UserId INTEGER,
  RoomId INTEGER,
  DateBegin DATE,
  DateEnd DATE,
  CONSTRAINT booking_fk1 FOREIGN KEY (UserId) REFERENCES [User] (Id),
  CONSTRAINT booking_fk2 FOREIGN KEY (RoomId) REFERENCES Room (Id),
  CONSTRAINT booking_dates CHECK (DateEnd > DateBegin)
);

insert into Role values ('Admin');
insert into Role values ('User');
-- Password is qwerty
insert into [User] values (1, 'Admin', '0dd3e512642c97ca3f747f9a76e374fbda73f9292823c0313be9d78add7cdd8f72235af0c553dd26797e78e1854edee0ae002f8aba074b066dfce1af114e32f8', 'Андрей', 'Иванов', 'admin@gmail.com', '+7 (919) 168-85-44');
insert into Convenience values ('Бассейн');
insert into Convenience values ('Аквапарк');
insert into Convenience values ('Спа');
insert into Convenience values ('Wi-Fi');
insert into Convenience values ('Бар');
insert into Convenience values ('Фитнес-зал');
insert into Convenience values ('Кухня');
insert into Convenience values ('Пляж');
insert into Hotel values ('The Waldorf Hilton Hotel', 'Лондон', 'Aldwich, WC2B 4DD, United Kingdom', 5);
insert into Hotel values ('Hilton Garden Inn Claridge', 'Рим', 'Viale Liegi 62, Rome, Italy', 5);
insert into Hotel values ('Hilton Sharks Bay Resort', 'Шарм-эль-Шейх', 'Ras Nusrani, Sharks Bay, Egypt', 4);
insert into Hotel values ('DoubleTree by Hilton Kemer', 'Анталья', 'Yeni Mah. Ataturk Bulv. 28/1, Kemer, 07980, Turkey', 4);
insert into Hotel values ('Bolton Vena', 'Vienna', 'Am Stadtpark 1, Vena, 1030, Austria', 3);
insert into Hotel values ('Bolton Mauritius Resort', 'Маврикий', 'Coastal Road, Wolmar, Flic-en-Flac, 90503', 5);
insert into Hotel values ('Hilton Bomonti Hotel Conference Center', 'Istanbul', 'Silahsor Cd No:42, 34381, Turkey', 4);
insert into Hotel values ('Hilton Diagonal Mar', 'Barcelona', 'Carrer del Taulat 262-264, 08019, Espania', 5);
insert into Hotel values ('Hampton City Centre', 'Warsaw', 'ul. Wspolna 72, Warsaw, 00-687, Poland', 3);
insert into Hotel values ('Хэмптон', 'Минск', 'Улица Толстого 8, 220007, Беларусь', 4);
insert into Hotel values ('Hilton Budapest City', 'Будапешт', 'Vaci ut 1-3, 1062, Hungary', 5);
insert into Hotel values ('Conrad', 'Tokyo', '1 Chome-9 Higashi-Shinbashi, Minato, 105-7337, Japan', 5);
insert into Hotel values ('Hilton Praga Old Town', 'Прага', 'V Celnici 7, Prague, 110 00, Czech Republic', 4);
insert into Hotel values ('Hilton Bosphorus', 'Istanbul', 'Harbiye Mh., Cumhuriyet Cad. No:50, 34367, Turkey', 5);
insert into Hotel values ('Хилтон Гарден Инн', 'Красноярск', 'ул. Молокова, д. 37, Красноярск, 660135, Россия', 5);
insert into Hotel values ('Хилтон Гарден Инн', 'Краснодар', 'ул. Красная, 25/2, Краснодар, 350000, Россия', 4);
insert into Hotel values ('Hilton Dussel', 'Дюссельдорф', 'Georg-Glock Strasse 20, Dusseldorf, 40474, Deutschland', 4);
insert into Hotel values ('Doubletree By Hilton Old Town', 'Istanbul', 'Beyazıt Mh., Ordu Cad. No:31, Istanbul, 34130, Turkey', 4);
insert into Hotel values ('Hilton Garden', 'Cologne', 'Marzellentstrasse 13-17, Koln, 50668, Germany', 5);
insert into Hotel values ('Hilton', 'Baku', '1B Azadlig Avenue, Baku, Azerbaijan', 3);
insert into Hotel values ('Хэмптон Хилтон', 'Воронеж', 'ул. Донбасская, 12б, Воронеж, 394030, Россия', 4);
insert into Hotel values ('Hilton Guam Resort', 'Guam', '202 Hilton Road, Tumon Bay, Tamuning, 96913', 4);
insert into Hotel values ('Conrad', 'Hong Kong', 'Pacific Place, 88 Queensway, Hong Kong, China', 5);
insert into Hotel values ('Hilton Vena Danube Waterfront', 'Vienna', 'Handelskai 269, Vena, 1020, Austria', 4);
insert into Hotel values ('Double-Tree Hilton', 'Warsaw', 'Skalnicowa Street 21, 04-797, Poland', 4);
insert into Hotel values ('Bolton Prague', 'Прага', 'Pobrenzi 1, Prague, 186 00, Czech Republic', 5);
insert into Hotel values ('Дабл-три', 'Минск', 'Проспект Победителей, 9, 220004, Беларусь', 4);
insert into Hotel values ('Hilton Bosphorus', 'Istanbul', 'Harbiye Mh., Cumhuriyet Cad. No:50, 34367, Turkey', 3);
insert into ConvHotel values (3, 1);
insert into ConvHotel values (4, 1);
insert into ConvHotel values (5, 1);
insert into ConvHotel values (6, 1);
insert into ConvHotel values (1, 2);
insert into ConvHotel values (4, 2);
insert into ConvHotel values (6, 2);
insert into ConvHotel values (7, 2);
insert into ConvHotel values (1, 3);
insert into ConvHotel values (2, 3);
insert into ConvHotel values (3, 3);
insert into ConvHotel values (6, 3);
insert into ConvHotel values (8, 3);
insert into ConvHotel values (1, 4);
insert into ConvHotel values (2, 4);
insert into ConvHotel values (3, 4);
insert into ConvHotel values (5, 4);
insert into ConvHotel values (8, 4);
insert into room values (1, 320, 15000, 'Стандартный');
insert into room values (1, 425, 30000, 'Люкс');
insert into room values (1, 480, 60000, 'Бизнес-номер');
insert into room values (1, 510, 100000, 'Президентский');
insert into room values (2, 100, 25000, 'Стандартный');
insert into room values (2, 115, 45000, 'Люкс');
insert into room values (2, 124, 60000, 'Бизнес-номер');
insert into room values (2, 510, 120000, 'Президентский');
insert into room values (3, 412, 20000, 'Стандартный');
insert into room values (3, 418, 30000, 'Люкс');
insert into room values (3, 425, 20000, 'Стандартный');
insert into room values (3, 488, 30000, 'Люкс');
insert into room values (4, 412, 20000, 'Стандартный');
insert into room values (4, 418, 30000, 'Люкс');
insert into room values (4, 425, 20000, 'Стандартный');
insert into room values (4, 488, 30000, 'Люкс');

DBCC CHECKIDENT ('User', RESEED, 0)
delete from [User]
insert into [User] values (1, 'Admin', '0dd3e512642c97ca3f747f9a76e374fbda73f9292823c0313be9d78add7cdd8f72235af0c553dd26797e78e1854edee0ae002f8aba074b066dfce1af114e32f8', 'Андрей', 'Иванов', 'admin@gmail.com', '+7 (919) 168-85-44');