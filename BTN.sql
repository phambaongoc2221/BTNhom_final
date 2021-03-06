create database BTN; 
use BTN; 

create table khachHang( makh varchar(10) primary key not null, tenkh Nvarchar(20) not null, sdt char(12) not null, diachi nvarchar(20) not null);

create table nhanVien( manv varchar(10) primary key not null, tennv nvarchar(20) not null, gioitinh nvarchar(4) not null,
ngaysinh varchar(30) not null, diachi nvarchar(20) not null, sdt char(12) not null, email varchar(30) not null);   

create table nhaCungCap( mancc varchar(10) primary key not null, tenncc nvarchar(30) not null, diachi nvarchar(20) not null,
sdt char(12) not null);

create table hangHoa( mahh varchar(10) primary key not null, mancc varchar(10) references nhaCungCap(mancc) not null,
tenhh nvarchar(20) not null, trangthai nvarchar(10) not null, soluong int, dongia float(2) not null);

create table nhapHang (manhap varchar(10) primary key not null, mancc varchar(10) references nhaCungCap(mancc) not null,
ngaynhap varchar(30) not null, tongtiennhap float(2));

create table chiTiet_nhapHang (mactnh varchar(10) primary key not null, manhap varchar(10) references nhapHang(manhap)  not null, mahh varchar(10) references hangHoa(mahh) not null,
soluong int not null, soluonghong int  not null, thanhtien float(2));

create table hoaDon( mahd varchar(10) primary key not null, makh varchar(10) references khachHang(makh) not null,
manv varchar(10) references nhanVien(manv) not null, ngaytao varchar(30) not null, tongtien float(2));

create table chiTiet_hoaDon(macthd varchar(10) primary key not null, mahd varchar(10) references hoaDon(mahd) not null,
mahh varchar(10) references hangHoa(mahh) not null, soluong int not null, tongtien float(2)); 

CREATE TRIGGER trg_tinhTienChiTietNhapHang on chiTiet_nhapHang after insert as begin 
update chiTiet_nhapHang set thanhtien = (chiTiet_nhapHang.soluong - chiTiet_nhapHang.soluonghong) * hangHoa.dongia
from chiTiet_nhapHang, hangHoa, inserted
where chiTiet_nhapHang.mahh = hangHoa.mahh and inserted.mactnh = chiTiet_nhapHang.mactnh
end

create trigger trg_updateTinhTienChiTietNhapHang on chiTiet_nhapHang after update as begin 
update chiTiet_nhapHang set thanhtien = (chiTiet_nhapHang.soluong - chiTiet_nhapHang.soluonghong) * hangHoa.dongia
from chiTiet_nhapHang, hangHoa, inserted
where chiTiet_nhapHang.mahh = hangHoa.mahh and inserted.mactnh = chiTiet_nhapHang.mactnh
end

create trigger trg_tinhTienNhapHang on chiTiet_nhapHang after insert as begin 
update nhapHang set tongtiennhap = (select sum(thanhtien) from chiTiet_nhapHang where manhap= nhapHang.manhap)
from chiTiet_nhapHang, nhapHang, inserted
where chiTiet_nhapHang.manhap = nhapHang.manhap and inserted.manhap = nhapHang.manhap
end

create trigger trg_updateTinhTienNhapHang on chiTiet_nhapHang after update as begin 
update nhapHang set tongtiennhap = (select sum(thanhtien) from chiTiet_nhapHang where manhap= nhapHang.manhap)
from chiTiet_nhapHang, nhapHang, inserted
where chiTiet_nhapHang.manhap = nhapHang.manhap and inserted.manhap = nhapHang.manhap
end

create trigger trg_deleteTinhTienNhapHang on chiTiet_nhapHang after delete as begin 
update nhapHang set tongtiennhap = (select sum(thanhtien) from chiTiet_nhapHang where manhap= nhapHang.manhap)
from chiTiet_nhapHang, nhapHang
where chiTiet_nhapHang.manhap = nhapHang.manhap 
end

create trigger trg_tinhTongHangKhiNhap on chiTiet_nhapHang after insert as begin 
update Hanghoa set soLuong = hangHoa.soluong + (select SUM(inserted.soluong) from inserted where mahh = hangHoa.mahh) - (select SUM(inserted.soluonghong) from inserted where mahh = hangHoa.mahh)
from chiTiet_nhapHang, hangHoa, inserted
where chiTiet_nhapHang.mahh = hangHoa.mahh and inserted.mactnh = chiTiet_nhapHang.mactnh
end

create trigger trg_updateTinhTongHangKhiNhap on chiTiet_nhapHang after update as begin 
update Hanghoa set soLuong = hangHoa.soluong + (select SUM(inserted.soluong) from inserted where mahh = hangHoa.mahh) - (select SUM(inserted.soluonghong) from inserted where mahh = hangHoa.mahh) - (select SUM(deleted.soluong) from deleted where mahh = hangHoa.mahh) + (select SUM(deleted.soluonghong) from deleted where mahh = hangHoa.mahh)
from chiTiet_nhapHang, hangHoa, inserted, deleted
where chiTiet_nhapHang.mahh = hangHoa.mahh and inserted.mactnh = chiTiet_nhapHang.mactnh and deleted.mactnh = chiTiet_nhapHang.mactnh
end

drop trigger trg_deleteTinhTongHangKhiNhap;

create trigger trg_deleteTinhTongHangKhiNhap on chiTiet_nhapHang after delete as begin 
update hangHoa set soLuong =  hangHoa.soluong - (select SUM(deleted.soluong) from deleted where mahh = hangHoa.mahh) + (select SUM(deleted.soluonghong) from deleted where mahh = hangHoa.mahh)
from chiTiet_nhapHang, hangHoa, deleted
where chiTiet_nhapHang.mahh = hangHoa.mahh and hangHoa.mahh = deleted.mahh
end
--------------

create trigger trg_tinhTienCTHD on chiTiet_hoaDon after insert, update as begin 
update chiTiet_hoaDon set tongtien = inserted.soluong * hangHoa.dongia 
from hangHoa, chiTiet_hoaDon, inserted
where hangHoa.mahh = chiTiet_hoaDon.mahh and inserted.macthd = chiTiet_hoaDon.macthd 
end

create trigger trg_tinhTienHoaDon on chiTiet_hoaDon after insert, update as begin 
update hoaDon set tongtien = (select SUM(chiTiet_hoaDon.tongtien) from chiTiet_hoaDon where mahd = hoaDon.mahd) 
from hoaDon, chiTiet_hoaDon, inserted
where hoaDon.mahd = chiTiet_hoaDon.mahd and inserted.mahd = hoaDon.mahd  
end


create trigger trg_deleteTinhTienHoaDon on chiTiet_hoaDon after delete as begin 
update hoaDon set tongtien = hoaDon.tongtien - (select SUM(deleted.tongtien) from deleted where mahd = hoaDon.mahd) 
from hoaDon, chiTiet_hoaDon, deleted
where hoaDon.mahd = chiTiet_hoaDon.mahd and deleted.mahd = hoaDon.mahd  
end

create trigger trg_tinhSoLuongHangHoaConLai on chiTiet_hoaDon after insert as begin 
update hangHoa set soluong = hangHoa.soluong - (select SUM(inserted.soluong) from inserted where mahh = hangHoa.mahh) 
from hangHoa, chiTiet_hoaDon, inserted
where hangHoa.mahh = chiTiet_hoaDon.mahh and inserted.mahh = hangHoa.mahh 
end

create trigger trg_updateTinhSoLuongHangHoaConLai on chiTiet_hoaDon after update as begin 
update hangHoa set soluong = hangHoa.soluong - (select SUM(inserted.soluong) from inserted where mahh = hangHoa.mahh) + (select SUM(deleted.soluong) from deleted where mahh = hangHoa.mahh) 
from hangHoa, chiTiet_hoaDon, inserted, deleted
where hangHoa.mahh = chiTiet_hoaDon.mahh and inserted.mahh = hangHoa.mahh and deleted.mahh = hangHoa.mahh
end

create trigger trg_deleteTinhSoLuongHangHoaConLai on chiTiet_hoaDon after delete as begin 
update hangHoa set soluong = hangHoa.soluong + (select SUM(deleted.soluong) from deleted where mahh = hangHoa.mahh) 
from hangHoa, chiTiet_hoaDon, deleted
where hangHoa.mahh = chiTiet_hoaDon.mahh and deleted.mahh = hangHoa.mahh 
end

drop table khachHang;
drop table nhanVien;
drop table nhaCungCap;
drop table hangHoa;
drop table hoaDon;
drop table chiTiet_hoaDon;
drop table giaoHang;
drop table nhapHang;
drop table chiTiet_nhapHang;

insert into khachHang values('KH1', N'NGUYỄN VĂN 1', '01234567891', N'HÀ NỘI'); 
insert into khachHang values('KH2', N'NGUYỄN VĂN 2', '01234567892', N'HÀ NAM'); 
insert into khachHang values('KH3', N'NGUYỄN VĂN 3', '01234567893', N'HÀ TĨNH'); 
insert into khachHang values('KH4', N'NGUYỄN VĂN 4', '01234567894', N'HÀ GIANG'); 
insert into khachHang values('KH5', N'NGUYỄN VĂN 5', '01234567895', N'HÀ ĐÔNG'); 

insert into nhanVien values('NV1', N'NGUYỄN VĂN A', N'NAM', '2000-1-1', N'HÀ NỘI', '12345678901', 'nv1@gmail.com.vn');
insert into nhanVien values('NV2', N'NGUYỄN VĂN B', N'NỮ', '2000-1-1', N'HẢI PHÒNG', '12345678902', 'nv2@gmail.com.vn');
insert into nhanVien values('NV3', N'NGUYỄN VĂN C', N'NAM', '2000-1-1', N'HẢI DƯƠNG', '12345678903', 'nv3@gmail.com.vn');
insert into nhanVien values('NV4', N'NGUYỄN VĂN D', N'KHÁC', '2000-1-1', N'HƯNG YÊN', '12345678904', 'nv4@gmail.com.vn');
insert into nhanVien values('NV5', N'NGUYỄN VĂN E', N'NAM', '2000-1-1', N'BẮC NINH', '12345678905', 'nv5@gmail.com.vn');
 
insert into nhaCungCap values('NCC1', N'CUNG CẤP 1', N'HÀ NỘI', '23456789011'); 
insert into nhaCungCap values('NCC2', N'CUNG CẤP 2', N'HÀ NAM', '23456789011'); 
insert into nhaCungCap values('NCC3', N'CUNG CẤP 3', N'HÀ TĨNH', '23456789011'); 
insert into nhaCungCap values('NCC4', N'CUNG CẤP 4', N'HÀ GIANG', '23456789011'); 
insert into nhaCungCap values('NCC5', N'CUNG CẤP 5', N'HÀ ĐÔNG', '23456789011'); 

insert into hangHoa values( 'HH1', 'NCC1', N'HÀNG HÓA 1', N'CÒN', 0, '10000');
insert into hangHoa values( 'HH2', 'NCC2', N'HÀNG HÓA 2', N'CÒN', 0, '12000');
insert into hangHoa values( 'HH3', 'NCC3', N'HÀNG HÓA 3', N'CÒN', 0, '13000');
insert into hangHoa values( 'HH4', 'NCC4', N'HÀNG HÓA 4', N'CÒN', 0, '14000');
insert into hangHoa values( 'HH5', 'NCC5', N'HÀNG HÓA 5', N'CÒN', 0, '15000');

insert into nhapHang values ('NHAP1', 'NCC1', '2021-10-15', null)

insert into chiTiet_nhapHang values ('CTNHAP1', 'NHAP1', 'HH1', 100, 10, NULL);
insert into chiTiet_nhapHang values ('CTNHAP2', 'NHAP1', 'HH2', 200, 10, NULL);
insert into chiTiet_nhapHang values ('CTNHAP3', 'NHAP1', 'HH3', 100, 0, NULL);
insert into chiTiet_nhapHang values ('CTNHAP4', 'NHAP1', 'HH4', 200, 20, NULL);
insert into chiTiet_nhapHang values ('CTNHAP5', 'NHAP1', 'HH5', 100, 5, NULL);


insert into hoaDon values( 'HD1', 'KH1', 'NV1', '2021-10-15', null);
insert into hoaDon values( 'HD2', 'KH2', 'NV2', '2021-10-16', null);
insert into hoaDon values( 'HD3', 'KH3', 'NV3', '2021-10-17', null);
insert into hoaDon values( 'HD4', 'KH4', 'NV4', '2021-10-18', null);

insert into chiTiet_hoaDon values('CT_HD1', 'HD1', 'HH1', 1, null);
insert into chiTiet_hoaDon values('CT_HD2', 'HD2', 'HH2', 2, null);
insert into chiTiet_hoaDon values('CT_HD3', 'HD3', 'HH3', 3, null);
insert into chiTiet_hoaDon values('CT_HD4', 'HD4', 'HH4', 4, null);
insert into chiTiet_hoaDon values('CT_HD5', 'HD1', 'HH2', 2, null);
insert into chiTiet_hoaDon values('CT_HD6', 'HD2', 'HH1', 3, null);


insert into giaoHang values ('GH1', 'HD1', 'KH1', 10000, NULL)

insert into chiTiet_nhapHang values ('CTNHAP6', 'NHAP1', 'HH1', 14, 0, NULL)

update chiTiet_nhapHang set soluonghong = 0 where mactnh='CTNHAP1';
delete chiTiet_nhapHang where mactnh='CTNHAP6';

insert into chiTiet_nhapHang values ('CTNHAP6', 'NHAP1', 'HH1', 20, 10, NULL);
update chiTiet_nhapHang set soluong=30 where mactnh='CTNHAP6';
delete chiTiet_nhapHang where mactnh='CTNHAP6';

insert into chiTiet_hoaDon values('CT_HD7', 'HD1', 'HH1', 3, null);
update chiTiet_hoaDon set soluong = 1 where macthd = 'CT_HD7';
delete chiTiet_hoaDon where macthd='CT_HD7';

SELECT * FROM nhanVien
SELECT * FROM khachHang;
SELECT * FROM nhaCungCap;
SELECT * FROM nhapHang;
SELECT * FROM chiTiet_nhapHang;
SELECT * FROM hangHoa;
SELECT * FROM chiTiet_hoaDon;
SELECT * FROM hoaDon; 
SELECT * FROM giaoHang;