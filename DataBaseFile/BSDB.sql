--create database BSDB  --����ϵͳ���ݿ�
--on primary
--(
--	name='BSDB',
--	filename='D:\Project\Project DataBase Files\BSDB.mdf'
--)
--go
use BSDB
go 
create table register_info	--ע����Ϣ��
(
	id nvarchar(50) primary key not null,--����
	[user_name] nvarchar(50) not null,		--�û���
	[password] nvarchar(50) not null,		--����
	phone nvarchar(11),						--�ֻ�
	email	nvarchar(50),					--email
	birthday nvarchar(8) not null,			--����
	[address] nvarchar(255)not null,		--��ַ
	spare_item_1 nvarchar(255),				--�����ֶ�1
	spare_item_2 nvarchar(255),				--�����ֶ�2
	spare_item_3 nvarchar(255),				--�����ֶ�3
	spare_item_4 nvarchar(255),				--�����ֶ�4
	spare_item_5 nvarchar(255),				--�����ֶ�5
	spare_item_6 nvarchar(255),				--�����ֶ�6
	spare_item_7 nvarchar(255),				--�����ֶ�7
	spare_item_8 nvarchar(255),				--�����ֶ�8
	spare_item_9 nvarchar(255),				--�����ֶ�9
	spare_item_10 nvarchar(255),			--�����ֶ�10
)

select * from register_info