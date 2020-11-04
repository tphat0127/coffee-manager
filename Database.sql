USE master
GO

IF EXISTS(SELECT * FROM sys.sysdatabases WHERE name='QLCF_NTP')
DROP DATABASE QLCF_NTP
GO

CREATE DATABASE QLCF_NTP
GO

USE QLCF_NTP
GO

CREATE TABLE Account
(
	UserName NVARCHAR(100) PRIMARY KEY,
	PassWord NVARCHAR(1000) NOT NULL DEFAULT 0,
	Type INT NOT NULL  DEFAULT 0
)
GO


CREATE TABLE [Table]
(
	Id INT IDENTITY PRIMARY KEY,
	Name NVARCHAR(100),
	[Status] BIT NOT NULL DEFAULT 0 --0 : Trống
)
GO

CREATE TABLE Category
(
	Id INT IDENTITY PRIMARY KEY,
	Name NVARCHAR(100) NOT NULL,
	[Image] NVARCHAR(100) NOT NULL DEFAULT 'default'
)
GO
CREATE TABLE Menu
(
	Id INT IDENTITY PRIMARY KEY,
	Name NVARCHAR(100) NOT NULL,
	CategoryId INT NOT NULL,
	Price FLOAT NOT NULL DEFAULT 0,
	[Image] VARCHAR(100) NOT NULL DEFAULT 'default'
	
	FOREIGN KEY (CategoryId) REFERENCES dbo.Category(id)
)
GO

CREATE TABLE Bill
(
	Id INT IDENTITY PRIMARY KEY,
	DateCheckIn DATE NOT NULL DEFAULT GETDATE(),
	DateCheckOut DATE,
	TableId INT NOT NULL,
	Status INT NOT NULL DEFAULT 0,
	UserName NVARCHAR(100) NOT NULL,
	Discount INT DEFAULT 0,
	TotalPrice FLOAT DEFAULT 0

	FOREIGN KEY (TableId) REFERENCES dbo.[TABLE](id),
	FOREIGN KEY (UserName) REFERENCES dbo.Account(UserName)
)
GO
CREATE TABLE BillInfo
(
	Id INT IDENTITY PRIMARY KEY,
	BillId INT NOT NULL,
	MenuId INT NOT NULL,
	Count INT NOT NULL DEFAULT 0
	
	FOREIGN KEY (BillId) REFERENCES dbo.Bill(id),
	FOREIGN KEY (MenuId) REFERENCES dbo.Menu(id)
)
GO



-------THÊM DỮ LIỆU

-- Thêm table 
DECLARE @TableName INT;
SET @TableName = 1;

WHILE @TableName <= 20
BEGIN
   INSERT dbo.[Table]
        ( Name, Status )
	VALUES  ( N'Bàn '+CAST(@TableName AS NVARCHAR(10)), 0 -- Name - nvarchar(100)
          )

   SET @TableName = @TableName + 1;
END

INSERT [dbo].[Account] ([UserName], [PassWord], [Type]) VALUES (N'Admin', N'1', 1)
INSERT [dbo].[Account] ([UserName], [PassWord], [Type]) VALUES (N'NV1', N'1', 1)
INSERT [dbo].[Account] ([UserName], [PassWord], [Type]) VALUES (N'NV2', N'1', 0)

SET IDENTITY_INSERT [dbo].[Category] ON

INSERT [dbo].[Category] ([Id], [Name], [Image]) VALUES (1, N'Cà Phê ', N'icons8-cafe-64.png')
INSERT [dbo].[Category] ([Id], [Name], [Image]) VALUES (2, N'Nước Ép - Sinh Tố', N'icons8-vegetarian-food-64.png')
INSERT [dbo].[Category] ([Id], [Name], [Image]) VALUES (3, N'Điểm Tâmm', N'icons8-sandwich-with-fried-egg-64.png')
INSERT [dbo].[Category] ([Id], [Name], [Image]) VALUES (7, N'Khác', N'default.png')
INSERT [dbo].[Category] ([Id], [Name], [Image]) VALUES (14, N'TEST', N'default.png')
SET IDENTITY_INSERT [dbo].[Category] OFF
SET IDENTITY_INSERT [dbo].[Menu] ON  

INSERT [dbo].[Menu] ([Id], [Name], [CategoryId], [Price], [Image]) VALUES (1, N'Cà phê đá', 1, 15000, N'icons8-coffee-64.png')
INSERT [dbo].[Menu] ([Id], [Name], [CategoryId], [Price], [Image]) VALUES (2, N'Cà phê sữa', 1, 20000, N'icons8-tea-cup-64.png')
INSERT [dbo].[Menu] ([Id], [Name], [CategoryId], [Price], [Image]) VALUES (3, N'Sinh tố BƠ', 2, 25000, N'icons8-avocado-64.png')
INSERT [dbo].[Menu] ([Id], [Name], [CategoryId], [Price], [Image]) VALUES (4, N'Dừa tươi', 2, 15000, N'icons8-coconut-64.png')
INSERT [dbo].[Menu] ([Id], [Name], [CategoryId], [Price], [Image]) VALUES (5, N'Chanh TTươi', 2, 15000, N'icons8-citrus-64.png')
INSERT [dbo].[Menu] ([Id], [Name], [CategoryId], [Price], [Image]) VALUES (6, N'Nước cam', 2, 15000, N'icons8-orange-64.png')
INSERT [dbo].[Menu] ([Id], [Name], [CategoryId], [Price], [Image]) VALUES (7, N'Mì', 3, 15000, N'icons8-double-chocolate-cake-64.png')
INSERT [dbo].[Menu] ([Id], [Name], [CategoryId], [Price], [Image]) VALUES (9, N'Cơm tấm', 2, 15000, N'icons8-sunny-side-up-eggs-64.png')
INSERT [dbo].[Menu] ([Id], [Name], [CategoryId], [Price], [Image]) VALUES (10, N'Sữa chua', 2, 6000, N'default.png')
INSERT [dbo].[Menu] ([Id], [Name], [CategoryId], [Price], [Image]) VALUES (11, N'Thuốc lá 555', 7, 40000, N'default.png')
INSERT [dbo].[Menu] ([Id], [Name], [CategoryId], [Price], [Image]) VALUES (12, N'Bạc Sỉu đá', 1, 20000, N'default.png')
SET IDENTITY_INSERT [dbo].[Menu] OFF 
SET IDENTITY_INSERT [dbo].[Bill] ON 


INSERT [dbo].[Bill] ([Id], [DateCheckIn], [DateCheckOut], [TableId], [Status], [UserName], [Discount], [TotalPrice]) VALUES (1, CAST(N'2018-12-26' AS Date), CAST(N'2018-12-26' AS Date), 1, 1, N'Admin', 0, 60)
INSERT [dbo].[Bill] ([Id], [DateCheckIn], [DateCheckOut], [TableId], [Status], [UserName], [Discount], [TotalPrice]) VALUES (2, CAST(N'2018-12-26' AS Date), CAST(N'2018-12-26' AS Date), 5, 1, N'Admin', 50, 50)
INSERT [dbo].[Bill] ([Id], [DateCheckIn], [DateCheckOut], [TableId], [Status], [UserName], [Discount], [TotalPrice]) VALUES (3, CAST(N'2018-12-26' AS Date), CAST(N'2018-12-26' AS Date), 4, 1, N'Admin', 50, 37500)
INSERT [dbo].[Bill] ([Id], [DateCheckIn], [DateCheckOut], [TableId], [Status], [UserName], [Discount], [TotalPrice]) VALUES (4, CAST(N'2018-12-27' AS Date), CAST(N'2018-12-27' AS Date), 6, 1, N'Admin', 20, 36000)
INSERT [dbo].[Bill] ([Id], [DateCheckIn], [DateCheckOut], [TableId], [Status], [UserName], [Discount], [TotalPrice]) VALUES (5, CAST(N'2018-12-27' AS Date), NULL, 1, 0, N'Admin', 0, NULL)
INSERT [dbo].[Bill] ([Id], [DateCheckIn], [DateCheckOut], [TableId], [Status], [UserName], [Discount], [TotalPrice]) VALUES (6, CAST(N'2018-12-27' AS Date), NULL, 1, 0, N'Admin', 0, NULL)
INSERT [dbo].[Bill] ([Id], [DateCheckIn], [DateCheckOut], [TableId], [Status], [UserName], [Discount], [TotalPrice]) VALUES (7, CAST(N'2018-12-28' AS Date), NULL, 1, 0, N'Admin', 0, NULL)
INSERT [dbo].[Bill] ([Id], [DateCheckIn], [DateCheckOut], [TableId], [Status], [UserName], [Discount], [TotalPrice]) VALUES (8, CAST(N'2018-12-28' AS Date), NULL, 1, 0, N'Admin', 0, NULL)
INSERT [dbo].[Bill] ([Id], [DateCheckIn], [DateCheckOut], [TableId], [Status], [UserName], [Discount], [TotalPrice]) VALUES (9, CAST(N'2018-12-28' AS Date), NULL, 1, 0, N'Admin', 0, NULL)
INSERT [dbo].[Bill] ([Id], [DateCheckIn], [DateCheckOut], [TableId], [Status], [UserName], [Discount], [TotalPrice]) VALUES (10, CAST(N'2018-12-28' AS Date), NULL, 1, 0, N'Admin', 0, NULL)
INSERT [dbo].[Bill] ([Id], [DateCheckIn], [DateCheckOut], [TableId], [Status], [UserName], [Discount], [TotalPrice]) VALUES (11, CAST(N'2018-12-28' AS Date), NULL, 1, 0, N'Admin', 0, NULL)
INSERT [dbo].[Bill] ([Id], [DateCheckIn], [DateCheckOut], [TableId], [Status], [UserName], [Discount], [TotalPrice]) VALUES (12, CAST(N'2018-12-28' AS Date), CAST(N'2018-12-28' AS Date), 1, 1, N'Admin', 10, 37800)
INSERT [dbo].[Bill] ([Id], [DateCheckIn], [DateCheckOut], [TableId], [Status], [UserName], [Discount], [TotalPrice]) VALUES (13, CAST(N'2018-12-28' AS Date), NULL, 1, 0, N'Admin', 0, NULL)
INSERT [dbo].[Bill] ([Id], [DateCheckIn], [DateCheckOut], [TableId], [Status], [UserName], [Discount], [TotalPrice]) VALUES (14, CAST(N'2018-12-28' AS Date), CAST(N'2018-12-28' AS Date), 2, 1, N'Admin', 0, 26000)
INSERT [dbo].[Bill] ([Id], [DateCheckIn], [DateCheckOut], [TableId], [Status], [UserName], [Discount], [TotalPrice]) VALUES (15, CAST(N'2018-12-28' AS Date), CAST(N'2018-12-28' AS Date), 1, 1, N'Admin', 0, 160000)
INSERT [dbo].[Bill] ([Id], [DateCheckIn], [DateCheckOut], [TableId], [Status], [UserName], [Discount], [TotalPrice]) VALUES (16, CAST(N'2018-12-28' AS Date), NULL, 8, 0, N'Admin', 0, NULL)
INSERT [dbo].[Bill] ([Id], [DateCheckIn], [DateCheckOut], [TableId], [Status], [UserName], [Discount], [TotalPrice]) VALUES (17, CAST(N'2018-12-28' AS Date), CAST(N'2018-12-28' AS Date), 1, 1, N'Admin', 0, 15000)
INSERT [dbo].[Bill] ([Id], [DateCheckIn], [DateCheckOut], [TableId], [Status], [UserName], [Discount], [TotalPrice]) VALUES (18, CAST(N'2018-12-28' AS Date), CAST(N'2018-12-28' AS Date), 8, 1, N'Admin', 0, 70000)
INSERT [dbo].[Bill] ([Id], [DateCheckIn], [DateCheckOut], [TableId], [Status], [UserName], [Discount], [TotalPrice]) VALUES (19, CAST(N'2018-12-28' AS Date), CAST(N'2018-12-28' AS Date), 12, 1, N'Admin', 30, 10500)
INSERT [dbo].[Bill] ([Id], [DateCheckIn], [DateCheckOut], [TableId], [Status], [UserName], [Discount], [TotalPrice]) VALUES (20, CAST(N'2018-12-28' AS Date), NULL, 1, 0, N'Admin', 0, NULL)
INSERT [dbo].[Bill] ([Id], [DateCheckIn], [DateCheckOut], [TableId], [Status], [UserName], [Discount], [TotalPrice]) VALUES (68, CAST(N'2018-12-30' AS Date), CAST(N'2018-12-30' AS Date), 1, 1, N'Admin', 20, 20000)
INSERT [dbo].[Bill] ([Id], [DateCheckIn], [DateCheckOut], [TableId], [Status], [UserName], [Discount], [TotalPrice]) VALUES (69, CAST(N'2018-12-30' AS Date), CAST(N'2018-12-30' AS Date), 1, 1, N'Admin', 10, 18000)
INSERT [dbo].[Bill] ([Id], [DateCheckIn], [DateCheckOut], [TableId], [Status], [UserName], [Discount], [TotalPrice]) VALUES (70, CAST(N'2018-12-30' AS Date), NULL, 3, 0, N'Admin', 0, NULL)
INSERT [dbo].[Bill] ([Id], [DateCheckIn], [DateCheckOut], [TableId], [Status], [UserName], [Discount], [TotalPrice]) VALUES (71, CAST(N'2018-12-30' AS Date), NULL, 17, 0, N'Admin', 0, NULL)
INSERT [dbo].[Bill] ([Id], [DateCheckIn], [DateCheckOut], [TableId], [Status], [UserName], [Discount], [TotalPrice]) VALUES (72, CAST(N'2018-12-30' AS Date), CAST(N'2019-01-05' AS Date), 4, 1, N'Admin', 0, 30000)
INSERT [dbo].[Bill] ([Id], [DateCheckIn], [DateCheckOut], [TableId], [Status], [UserName], [Discount], [TotalPrice]) VALUES (73, CAST(N'2019-01-05' AS Date), CAST(N'2019-01-05' AS Date), 1, 1, N'Admin', 20, 32000)
INSERT [dbo].[Bill] ([Id], [DateCheckIn], [DateCheckOut], [TableId], [Status], [UserName], [Discount], [TotalPrice]) VALUES (74, CAST(N'2019-01-05' AS Date), CAST(N'2019-01-05' AS Date), 5, 1, N'Admin', 0, 45000)
INSERT [dbo].[Bill] ([Id], [DateCheckIn], [DateCheckOut], [TableId], [Status], [UserName], [Discount], [TotalPrice]) VALUES (75, CAST(N'2019-01-05' AS Date), NULL, 6, 0, N'Admin', 0, NULL)
INSERT [dbo].[Bill] ([Id], [DateCheckIn], [DateCheckOut], [TableId], [Status], [UserName], [Discount], [TotalPrice]) VALUES (76, CAST(N'2019-01-05' AS Date), NULL, 9, 0, N'Admin', 0, NULL)
INSERT [dbo].[Bill] ([Id], [DateCheckIn], [DateCheckOut], [TableId], [Status], [UserName], [Discount], [TotalPrice]) VALUES (77, CAST(N'2019-01-10' AS Date), CAST(N'2019-01-10' AS Date), 1, 1, N'Admin', 40, 12000)
INSERT [dbo].[Bill] ([Id], [DateCheckIn], [DateCheckOut], [TableId], [Status], [UserName], [Discount], [TotalPrice]) VALUES (78, CAST(N'2019-01-10' AS Date), CAST(N'2019-01-10' AS Date), 1, 1, N'Admin', 0, 15000)
INSERT [dbo].[Bill] ([Id], [DateCheckIn], [DateCheckOut], [TableId], [Status], [UserName], [Discount], [TotalPrice]) VALUES (79, CAST(N'2019-01-10' AS Date), CAST(N'2019-01-10' AS Date), 2, 1, N'Admin', 10, 76500)
INSERT [dbo].[Bill] ([Id], [DateCheckIn], [DateCheckOut], [TableId], [Status], [UserName], [Discount], [TotalPrice]) VALUES (80, CAST(N'2019-01-10' AS Date), CAST(N'2019-01-10' AS Date), 5, 1, N'Admin', 0, 135000)
SET IDENTITY_INSERT [dbo].[Bill] OFF 
SET IDENTITY_INSERT [dbo].[BillInfo] ON

INSERT [dbo].[BillInfo] ([Id], [BillId], [MenuId], [Count]) VALUES (117, 68, 3, 1)
INSERT [dbo].[BillInfo] ([Id], [BillId], [MenuId], [Count]) VALUES (118, 69, 12, 1)
INSERT [dbo].[BillInfo] ([Id], [BillId], [MenuId], [Count]) VALUES (119, 72, 1, 2)
INSERT [dbo].[BillInfo] ([Id], [BillId], [MenuId], [Count]) VALUES (121, 74, 1, 1)
INSERT [dbo].[BillInfo] ([Id], [BillId], [MenuId], [Count]) VALUES (122, 74, 7, 2)
INSERT [dbo].[BillInfo] ([Id], [BillId], [MenuId], [Count]) VALUES (124, 73, 2, 2)
INSERT [dbo].[BillInfo] ([Id], [BillId], [MenuId], [Count]) VALUES (126, 77, 2, 1)
INSERT [dbo].[BillInfo] ([Id], [BillId], [MenuId], [Count]) VALUES (127, 78, 1, 1)
INSERT [dbo].[BillInfo] ([Id], [BillId], [MenuId], [Count]) VALUES (128, 79, 6, 2)
INSERT [dbo].[BillInfo] ([Id], [BillId], [MenuId], [Count]) VALUES (129, 79, 5, 1)
INSERT [dbo].[BillInfo] ([Id], [BillId], [MenuId], [Count]) VALUES (130, 79, 11, 1)
INSERT [dbo].[BillInfo] ([Id], [BillId], [MenuId], [Count]) VALUES (131, 80, 4, 1)
INSERT [dbo].[BillInfo] ([Id], [BillId], [MenuId], [Count]) VALUES (132, 80, 3, 1)
INSERT [dbo].[BillInfo] ([Id], [BillId], [MenuId], [Count]) VALUES (133, 80, 6, 1)
INSERT [dbo].[BillInfo] ([Id], [BillId], [MenuId], [Count]) VALUES (134, 80, 11, 2)
SET IDENTITY_INSERT [dbo].[BillInfo] OFF 

GO 
-- Cập nhật status table
CREATE TRIGGER UTG_UpdateBillInfo
ON dbo.BillInfo FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @idBill INT
	
	SELECT @idBill = Inserted.BillId FROM Inserted
	
	DECLARE @idTable INT
	
	SELECT @idTable = TableId FROM dbo.Bill WHERE id = @idBill AND status = 0
	
	UPDATE dbo.[Table] SET status = 1 WHERE id = @idTable
END
GO

CREATE TRIGGER UTG_UpdateBill
ON dbo.Bill FOR UPDATE
AS
BEGIN
	DECLARE @idBill INT
	
	SELECT @idBill = id FROM Inserted	
	
	DECLARE @idTable INT
	
	SELECT @idTable = TableId FROM dbo.Bill WHERE id = @idBill
	
	DECLARE @count int = 0
	
	SELECT @count = COUNT(*) FROM dbo.Bill WHERE TableId = @idTable AND status = 0
	
	IF (@count = 0)
		UPDATE dbo.[Table] SET status = 0 WHERE id = @idTable
END
GO
-----Lấy dữ liệu Table-------
CREATE PROC USP_GetTableInfo
@idTable INT
AS BEGIN
	SELECT t.Id, t.Status, t.Name, b.DateCheckIn FROM  dbo.Bill AS b, dbo.[Table]  AS t
END
GO

---- Chuyển Bàn---------------
CREATE PROC USP_SwitchTabble
@idTable1 INT, @idTable2 int
AS BEGIN

	DECLARE @idFirstBill int
	DECLARE @idSeconrdBill INT
	
	DECLARE @isFirstTablEmty INT = 1
	DECLARE @isSecondTablEmty INT = 1
	
	
	SELECT @idSeconrdBill = id FROM dbo.Bill WHERE TableId = @idTable2 AND status = 0
	SELECT @idFirstBill = id FROM dbo.Bill WHERE TableId = @idTable1 AND status = 0
	
	IF (@idFirstBill IS NULL)
	BEGIN
		INSERT dbo.Bill
		        ( DateCheckIn ,
		          DateCheckOut ,
		          TableId ,
		          status,
				  UserName,
				  Discount
		        )
		VALUES  ( GETDATE() , -- DateCheckIn - date
		          NULL , -- DateCheckOut - date
		          @idTable1 , -- idTable - int
		          0,  -- status - int
				  'Admin',
				  0
		        )
		        
		SELECT @idFirstBill = MAX(id) FROM dbo.Bill WHERE TableId = @idTable1 AND status = 0
		
	END
	
	SELECT @isFirstTablEmty = COUNT(*) FROM dbo.BillInfo WHERE BillId = @idFirstBill

	
	IF (@idSeconrdBill IS NULL)
	BEGIN
		INSERT dbo.Bill
		        ( DateCheckIn ,
		          DateCheckOut ,
		          TableId ,
		          status,
				  UserName,
				  Discount
		        )
		VALUES  ( GETDATE() , -- DateCheckIn - date
		          NULL , -- DateCheckOut - date
		          @idTable2 , -- idTable - int
		          0,  -- status - int
				  'Admin',
				  0
		        )
		SELECT @idSeconrdBill = MAX(id) FROM dbo.Bill WHERE TableId = @idTable2 AND status = 0
		
	END
	
	SELECT @isSecondTablEmty = COUNT(*) FROM dbo.BillInfo WHERE BillId = @idSeconrdBill

	SELECT id INTO IDBillInfoTable FROM dbo.BillInfo WHERE BillId = @idSeconrdBill
	
	UPDATE dbo.BillInfo SET BillId = @idSeconrdBill WHERE BillId = @idFirstBill
	
	UPDATE dbo.BillInfo SET BillId = @idFirstBill WHERE id IN (SELECT * FROM IDBillInfoTable)
	
	DROP TABLE IDBillInfoTable
	
	IF (@isFirstTablEmty = 0)
		UPDATE dbo.[Table] SET status = 0 WHERE id = @idTable2
		
	IF (@isSecondTablEmty= 0)
		UPDATE dbo.[Table] SET status = 0 WHERE id = @idTable1
END
GO

---- Gộp Bàn---------------
CREATE PROC USP_GroupTable
@idTable1 INT, @idTable2 int
AS BEGIN

	DECLARE @idFirstBill int
	DECLARE @idSeconrdBill INT
	
	DECLARE @isFirstTablEmty INT = 1
	DECLARE @isSecondTablEmty INT = 1
	
	
	SELECT @idSeconrdBill = id FROM dbo.Bill WHERE TableId = @idTable2 AND status = 0
	SELECT @idFirstBill = id FROM dbo.Bill WHERE TableId = @idTable1 AND status = 0
	
	IF (@idFirstBill IS NULL)
	BEGIN
		INSERT dbo.Bill
		        ( DateCheckIn ,
		          DateCheckOut ,
		          TableId ,
		          status,
				  UserName,
				  Discount
		        )
		VALUES  ( GETDATE() , -- DateCheckIn - date
		          NULL , -- DateCheckOut - date
		          @idTable1 , -- idTable - int
		          0,  -- status - int
				  'Admin',
				  0
		        )
		        
		SELECT @idFirstBill = MAX(id) FROM dbo.Bill WHERE TableId = @idTable1 AND status = 0
		
	END
	
	SELECT @isFirstTablEmty = COUNT(*) FROM dbo.BillInfo WHERE BillId = @idFirstBill

	
	IF (@idSeconrdBill IS NULL)
	BEGIN
		INSERT dbo.Bill
		        ( DateCheckIn ,
		          DateCheckOut ,
		          TableId ,
		          status,
				  UserName,
				  Discount
		        )
		VALUES  ( GETDATE() , -- DateCheckIn - date
		          NULL , -- DateCheckOut - date
		          @idTable2 , -- idTable - int
		          0,  -- status - int
				  'Admin',
				  0
		        )
		SELECT @idSeconrdBill = MAX(id) FROM dbo.Bill WHERE TableId = @idTable2 AND status = 0
		
	END
	
	SELECT @isSecondTablEmty = COUNT(*) FROM dbo.BillInfo WHERE BillId = @idSeconrdBill

	SELECT id INTO IDBillInfoTable FROM dbo.BillInfo WHERE BillId = @idSeconrdBill
	
	UPDATE dbo.BillInfo SET BillId = @idSeconrdBill WHERE BillId = @idFirstBill
	
	UPDATE dbo.BillInfo SET BillId = @idFirstBill WHERE id IN (SELECT * FROM IDBillInfoTable)
	
	DROP TABLE IDBillInfoTable
	
	IF (@isFirstTablEmty = 0)
		UPDATE dbo.[Table] SET status = 0 WHERE id = @idTable2
		
	IF (@isSecondTablEmty= 0)
		UPDATE dbo.[Table] SET status = 0 WHERE id = @idTable1
END
GO
-- Function Thống kê
CREATE FUNCTION FN_ViewDoanThu (@DateCheckIn DATE, @DateCheckOut DATE ) 
RETURNS TABLE AS 

 RETURN SELECT t.Name, b.TotalPrice, b.DateCheckIn, b.DateCheckOut, b.Discount FROM dbo.Bill b, dbo.[Table] t
		WHERE t.Id = b.TableId
		AND b.DateCheckIn >= @DateCheckIn AND b.DateCheckOut < @DateCheckOut

GO

CREATE FUNCTION FN_ViewSanPham (@DateCheckIn DATE, @DateCheckOut DATE ) 
RETURNS TABLE AS 

 RETURN SELECT m.Name AS [Tên], SUM(bi.Count) AS [Số_Lượng] 
		FROM dbo.BillInfo bi, dbo.Bill b, dbo.Category c, dbo.Menu m
		WHERE bi.BillId = b.Id AND m.Id = bi.MenuId AND b.DateCheckIn >= @DateCheckIn AND b.DateCheckOut < @DateCheckOut
		GROUP BY m.Name
