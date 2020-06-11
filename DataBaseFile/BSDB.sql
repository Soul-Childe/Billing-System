--create database BSDB  --消费系统数据库
--on primary
--(
--	name='BSDB',
--	filename='D:\Project\Project DataBase Files\BSDB.mdf'
--)
--go
use BSDB
go 
create table register_info	--注册信息表
(
	id nvarchar(50) primary key not null,--主键
	[user_name] nvarchar(50) not null,		--用户名
	[password] nvarchar(50) not null,		--密码
	phone nvarchar(11),						--手机
	email	nvarchar(50),					--email
	birthday nvarchar(8) not null,			--生日
	[address] nvarchar(255)not null,		--地址
	spare_item_1 nvarchar(255),				--备用字段1
	spare_item_2 nvarchar(255),				--备用字段2
	spare_item_3 nvarchar(255),				--备用字段3
	spare_item_4 nvarchar(255),				--备用字段4
	spare_item_5 nvarchar(255),				--备用字段5
	spare_item_6 nvarchar(255),				--备用字段6
	spare_item_7 nvarchar(255),				--备用字段7
	spare_item_8 nvarchar(255),				--备用字段8
	spare_item_9 nvarchar(255),				--备用字段9
	spare_item_10 nvarchar(255),			--备用字段10
)

select * from register_info