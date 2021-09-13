CREATE PROC QLHS_ADMIN 
AS 
BEGIN 
   SELECT HS.MaHS, HS.HoTen, HS.GT, HS.NgaySinh,  HS.DiaChi, HS.PhuHuynh, HS.DinhMucHocPhi, HS.MaLop
   FROM tblHocSinh AS HS, tblLop AS LOP
   WHERE HS.MaLop = LOP.MaLop
END
GO


CREATE PROC QLHS_HOCSINH (@MaHS nchar(10))
AS
BEGIN
  SELECT HS.MaHS, HS.HoTen, HS.GT, HS.NgaySinh,  HS.DiaChi, HS.PhuHuynh, HS.DinhMucHocPhi, HS.MaLop
   FROM tblHocSinh AS HS, tblLop AS LOP
   WHERE HS.MaLop = LOP.MaLop
   AND HS.MaHS = @MaHS
END
GO


CREATE PROC THEM_HS_ADMIN 
(@MaHS nchar(10),
 @HoTen nvarchar(50),
 @GT nchar(3),
 @NgaySinh date,
 @DiaChi nvarchar(50),
 @PhuHuynh nvarchar(50),
 @DinhMucHocPhi float,
 @MaLop nchar(10)
 )
AS
BEGIN
   INSERT INTO tblHocSinh VALUES (@MaHS, @HoTen, @GT, @NgaySinh, @DiaChi, @PhuHuynh, @DinhMucHocPhi, @MaLop)
END
GO

CREATE PROC SUA_HS_ADMIN 
(@MaHS nchar(10),
 @HoTen nvarchar(50),
 @GT nchar(3),
 @NgaySinh date,
 @DiaChi nvarchar(50),
 @PhuHuynh nvarchar(50),
 @DinhMucHocPhi float,
 @MaLop nchar(10)
 )
AS
BEGIN
   UPDATE tblHocSinh 
   SET MaHS = @MaHS, HoTen = @HoTen, GT = @GT, NgaySinh = @NgaySinh, DiaChi = @DiaChi, PhuHuynh = @PhuHuynh, DinhMucHocPhi = @DinhMucHocPhi, MaLop = @MaLop
   WHERE MaHS = @MaHS
END
GO

CREATE PROC XOA_HS_ADMIN(@MaHS nchar(10))
AS
BEGIN
  DELETE tblHocSinh WHERE MaHS = @MaHS
END
GO

CREATE PROC TIMHS_ADMIN(@text nvarchar(50))
AS
BEGIN
	DECLARE @pattern nvarchar(50)
	SET @pattern = '%'+TRIM(@text)+'%'

	SELECT * FROM tblHocSinh
	WHERE MaHS LIKE @pattern OR HoTen LIKE @pattern OR GT LIKE @pattern OR NgaySinh LIKE @pattern OR 
			DiaChi LIKE @pattern OR PhuHuynh LIKE @pattern OR DinhMucHocPhi LIKE @pattern OR MaLop LIKE @pattern
END
GO

CREATE PROC XEMLICHHOC_HOCSINH(@MaHS nchar(10))
AS
BEGIN
  SELECT HS.MaHS, HS.MaLop, HS.HoTen, LOP.TenLop, MH.TenMon, CTGD.NgayDay, CTGD.SoTiet, GV.HoTen AS GVCN
  FROM tblHocSinh AS HS, tblLop AS LOP, tblGiaoVien AS GV, tblMonHoc AS MH, tblCTGD AS CTGD
  WHERE HS.MaHS = @MaHS
  AND GV.MaMon = MH.MaMon
  AND HS.MaLop = LOP.MaLop
  AND GV.MaGV = LOP.GVCN
  AND CTGD.MaLop = LOP.MaLop
END
GO

CREATE PROC DANGNHAP1
 AS 
 BEGIN 
 SELECT MaGV,SDT FROM tblGiaoVien
 END
 
 CREATE PROC DANGNHAP2
 AS 
 BEGIN
 SELECT MaHS FROM tblHocSinh
 END
 GO

CREATE PROC XEMGIAOVIEN_ADMIN 
AS 
BEGIN
SELECT * FROM tblGiaoVien
END
GO 

 
CREATE PROC THEMGIAOVIEN_ADMIN
(
 @MAGV nchar(10),
 @Hoten nvarchar(50),
 @GT nchar(3),
 @NgaySinh date,
 @DiaChi nvarchar(50),
 @SDT int,
 @Luong bigint,
 @TrinhDo nvarchar(10),
 @MaMon nchar(10)
 )
 as
 begin
 insert into tblGiaoVien values (@MAGV,@Hoten,@GT,@NgaySinh,@DiaChi,@SDT,@Luong,@TrinhDo,@MaMon)
 end
 GO

 CREATE PROC SUAGIAOVIEN_ADMIN
(
 @MAGV nchar(10),
 @Hoten nvarchar(50),
 @GT nchar(3),
 @NgaySinh date,
 @DiaChi nvarchar(50),
 @SDT int,
 @Luong bigint,
 @TrinhDo nvarchar(10),
 @MaMon nchar(10)
 )
 AS 
 BEGIN
 UPDATE tblGiaoVien SET MaGV = @MAGV,HoTen = @Hoten , GT = @GT,NgaySinh = @NgaySinh, DiaChi = @DiaChi, SDT = @SDT,LuongCung = @Luong,MaTrinhDo = @TrinhDo,MaMon = @MaMon WHERE MaGV = @MAGV
 END
 GO

 CREATE PROC XOAGIAOVIEN_ADMIN (@MAGV NCHAR(10))
 AS
 BEGIN
 DELETE tblGiaoVien WHERE MaGV = @MAGV
 DELETE tblCTGD WHERE MaGV = @MAGV
 END
 GO

 CREATE PROC THONGTIN_GIAOVIEN(@MAGV NCHAR(10))
 AS
 BEGIN
 SELECT * FROM tblGiaoVien WHERE MaGV = @MAGV
 END

 CREATE PROC TIMGIAOVIEN_ADMIN( @text NVARCHAR(100))
 AS
 BEGIN
 	DECLARE @pattern NVARCHAR(100)
	SET @pattern = '%'+TRIM(@text)+'%'
	SELECT * FROM tblGiaoVien 
	WHERE MaGV LIKE @pattern OR HoTen LIKE @pattern OR GT LIKE @pattern OR NgaySinh LIKE @pattern OR DiaChi LIKE @pattern OR SDT LIKE @pattern OR LuongCung LIKE @pattern OR MaTrinhDo LIKE @pattern OR MaMon LIKE @pattern 
	END

  





