
create database trainningloginwinform
create table DM_ManHinh(
	MaManHinh char(50) not null,
	TenManHinh nvarchar(50)
	primary key(MaManHinh),
	
)
create table ql_NguoiDung(
	TenDangNhap char(50) not null,
	MatKhau char(50),
	HoatDong int,
	primary key(TenDangNhap)
)
create table ql_PhanQuyen(
	MaNhomNguoiDung char(50) not null,
	MaManHinh char(50),
	CoQuyen int,
	primary key(MaNhomNguoiDung,MaManHinh),
	foreign key(MaManHinh) references DM_ManHinh(MaManHinh)
)
create table ql_NhomNguoiDung(
	MaNhom char(50) not null,
	TenNhom char(50),
	GhiChu int,
	primary key(MaNhom)

)
create table ql_NguoiDungNhomNguoiDung(
	TenDangNhap char(50) not null,
	MaNhomNguoiDung char(50),
	GhiChu int,
	primary key(TenDangNhap,MaNhomNguoiDung),
	foreign key(TenDangNhap) references ql_NguoiDung(TenDangNhap),


)


insert into ql_NguoiDung values('admin1','123',1);
insert into ql_NguoiDung values('admin2','456',1);
insert into ql_NguoiDung values('admin3','789',1);


insert into ql_NhomNguoiDung values('admin','Admin',NULL);
insert into ql_NhomNguoiDung values('user','User',NULL);

insert into ql_NguoiDungNhomNguoiDung values('admin1','admin',NULL);
insert into ql_NguoiDungNhomNguoiDung values('admin2','admin',NULL);
insert into ql_NguoiDungNhomNguoiDung values('admin3','user',NULL);


insert into DM_ManHinh values('SF001','frmNguoiDung');
insert into DM_ManHinh values('SF002','frmNhomNguoiDung');
insert into DM_ManHinh values('SF003','frmThemNguoiDung');
insert into DM_ManHinh values('SF004','frmPhanQuyen');
insert into DM_ManHinh values('SF005',N'DM Màn Hình');
insert into DM_ManHinh values('SF006','Danh Muc Test');
insert into DM_ManHinh values('SF007',' Test');
insert into DM_ManHinh values('SF008','aaaaaa');



SELECT COUNT(*) AS Expr1
FROM     ql_NguoiDungNhomNguoiDung
WHERE  (ql_NguoiDungNhomNguoiDung.MaNhomNguoiDung = 'admin') AND (ql_NguoiDungNhomNguoiDung.TenDangNhap = 'admin2') 



SELECT DM_ManHinh.MaManHinh, DM_ManHinh.TenManHinh, ql_PhanQuyen.CoQuyen
FROM     DM_ManHinh INNER JOIN
                  ql_PhanQuyen ON DM_ManHinh.MaManHinh = ql_PhanQuyen.MaManHinh
WHERE  (ql_PhanQuyen.MaManHinh = @mamanhinh)