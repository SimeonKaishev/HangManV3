CREATE DATABASE HangMan;
USE HangMan;
CREATE TABLE Teams(
TeamId int not null auto_increment primary key,
TeamName varchar(10) unique not null,
TeamPointAmount int Default 0
);
CREATE TABLE Users(
Id int unique auto_increment primary key,
TeamId int default null,
Username varchar(12) unique not null,
Password text not null,
PointAmount int Default 0,
FOREIGN KEY (TeamId) REFERENCES Teams(TeamId)
);
CREATE TABLE Words(
Id int unique auto_increment primary key,
Word varchar(50) unique,
Difficulty ENUM('easy','medium','hard','impossible')
);
insert Into teams values(1,"NoTeam",0);
insert Into teams values(8,"jeffteam",104);
insert Into teams values(9,"thewinners",117);
insert Into users values(1,1,"gosho","WERevlwEYQBkKESTC8N3/ssD/hHR+8Bs1uXHmE/Eq1RrkVaw",10);
insert Into users values(12,8,"Jeff","F0tzF4bY7eP2XWjdh9mCu+yQRp648mvGMtUFQh+zvzUpdBAC",104);
insert Into users values(13,9,"User1","feRCOz16lG25ILDqzEL63kOyBvpsdhhnHuCJ6LpMFVpaYqrG",61);
insert Into users values(14,9,"gosho2","7NJfd1THlpkOM4sx2Gazevu7RUgwtjH8w+d+LhZAElh6MgPa",56);
insert Into words values(1,"anything","medium");
insert Into words values(2,"word","easy");
insert Into words values(3,"aftershock","hard");
insert Into words values(4,"pneumonoultramicroscopicsilicovolcanoconiosis","impossible");

select * from users;
select * from teams;
select * from words;
