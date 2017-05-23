--1: tai khoan 

create table taikhoan 
(
TenTk char (50) not null,
MatKhau char (50) not null,
primary key (TenTK),
)

--2: loai sach

create table loaisach
(
MaLS char (50) not null,
TenLS nvarchar (200) not null,
primary key (MaLS),
)

--3: nha xuat ban

create table NXB
(
MaNXB char (50) not null,
TenNXB nvarchar (100) not null,
DiaChiNXB nvarchar (100) not null,
Website nvarchar (100) null,
primary key (MaNXB),
)

--4: sach
 create table sach 
 (
 MaSach char (50) not null,
 TenSach nvarchar (100) not null,
 TacGia nvarchar (50)  null,
 MaNXB char (50),
 MaLS char (50),
 NamXB int null,
 LanXB int null,
 SoLuong int not null,
 NoiDung nvarchar (200) null,
 primary key (MaSach),
 foreign key (MaNXB) references NXB (MaNXB),
 foreign key (MaLS) references loaisach (MaLS),
 )

 --5: sinh vien
 create table sinhvien
(
MaThe char (50) not null,
TenSV nvarchar (50) not null,
Ngaysinh datetime not null, 
DiaChi nvarchar (100),
Lop nvarchar (50) not null,
Khoa nvarchar (50) not null,
NgayCapThe datetime not null,
NgayHetHan datetime not null,
gioitinh int,
primary key (MaThe),
)

--6: phat

create table phat
(
MaSach char(50),
MaThe char (50),
LyDoPhat nvarchar (200),
foreign key (MaSach) references sach (MaSach),
foreign key (MaThe) references sinhvien (MaThe),
)

--7: Nhan vien

create table nhanvien 
(
MaNV char (50) not null,
TenNV nvarchar (50) not null,
DiaChi nvarchar (50) not null,
NgaySinh datetime null,
GioiTinh int not null,
DienThoai char (20) not null,
MatKhau char (50) not null,
primary key (MaNV),
)

--8: muon sach

create table muonsach
(
SoPhieuMuon char (50) not null,
MaThe char (50),
MaNV char (50),
NgayMuon date,
primary key (SoPhieuMuon),
foreign key (MaThe) references sinhvien (MaThe),
foreign key (MaNV) references nhanvien (MaNV),
)

--9: chi tiet phieu muon
 
create table chitietphieumuon
(
SoPhieuMuon char (50),
MaSach char (50),
HenTra date,
foreign key (SoPhieuMuon) references muonsach(SoPhieuMuon),
)

--10: tra sach

create table trasach
(
SoPhieuMuon char (50),
MaSach char (50),
MaNV char (50),
NgayTra date,
foreign key (SoPhieuMuon) references muonsach (SoPhieuMuon),
)

--11: 