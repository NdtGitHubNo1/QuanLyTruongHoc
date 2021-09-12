CREATE PROC QLHS_ADMIN 
AS 
BEGIN 
   SELECT HS.MaHS, HS.HoTen, HS.GT, HS.NgaySinh,  HS.DiaChi, HS.PhuHuynh, HS.DinhMucHocPhi, HS.MaLop
   FROM tblHocSinh AS HS, tblLop AS LOP
   WHERE HS.MaLop = LOP.MaLop
END
GO

EXEC QLHS_ADMIN 
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


  





