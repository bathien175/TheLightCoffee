USE [master]
GO
/****** Object:  Database [TheLightCoffee]    Script Date: 04/02/2023 10:13:48 SA ******/
CREATE DATABASE [TheLightCoffee]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TheLightCoffee', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\TheLightCoffee.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TheLightCoffee_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\TheLightCoffee_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TheLightCoffee] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TheLightCoffee].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TheLightCoffee] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TheLightCoffee] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TheLightCoffee] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TheLightCoffee] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TheLightCoffee] SET ARITHABORT OFF 
GO
ALTER DATABASE [TheLightCoffee] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TheLightCoffee] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TheLightCoffee] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TheLightCoffee] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TheLightCoffee] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TheLightCoffee] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TheLightCoffee] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TheLightCoffee] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TheLightCoffee] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TheLightCoffee] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TheLightCoffee] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TheLightCoffee] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TheLightCoffee] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TheLightCoffee] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TheLightCoffee] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TheLightCoffee] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TheLightCoffee] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TheLightCoffee] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TheLightCoffee] SET  MULTI_USER 
GO
ALTER DATABASE [TheLightCoffee] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TheLightCoffee] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TheLightCoffee] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TheLightCoffee] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TheLightCoffee] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TheLightCoffee] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [TheLightCoffee] SET QUERY_STORE = ON
GO
ALTER DATABASE [TheLightCoffee] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [TheLightCoffee]
GO
/****** Object:  Table [dbo].[Bill_Info]    Script Date: 04/02/2023 10:13:48 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill_Info](
	[BI_ID] [int] IDENTITY(1,1) NOT NULL,
	[BI_Bill] [int] NOT NULL,
	[BI_Product] [int] NOT NULL,
	[BI_Quantity] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[BI_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 04/02/2023 10:13:48 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Product_ID] [int] IDENTITY(1,1) NOT NULL,
	[Product_Name] [nvarchar](100) NOT NULL,
	[Product_Category] [int] NOT NULL,
	[Product_Unit] [nvarchar](10) NULL,
	[Product_Price] [bigint] NOT NULL,
	[Product_isActive] [bit] NOT NULL,
	[Product_Image] [varbinary](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[Product_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[Staticscal_Product_bottom]    Script Date: 04/02/2023 10:13:48 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[Staticscal_Product_bottom]
as
	select top 3 p.Product_Name, sum(b.BI_Quantity) as [count_buy]
	from Product as p,Bill_Info as b
	where b.BI_Product = p.Product_ID
	group by p.Product_Name
	order by [count_buy] asc 
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 04/02/2023 10:13:48 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[Bill_ID] [int] IDENTITY(1,1) NOT NULL,
	[Bill_Table] [varchar](10) NULL,
	[Bill_Staff] [varchar](10) NOT NULL,
	[Bill_TimeFrom] [datetime] NOT NULL,
	[Bill_TimeTo] [datetime] NULL,
	[Bill_Discount] [bigint] NOT NULL,
	[Bill_isTakeAway] [bit] NOT NULL,
	[Bill_TotalMoney] [bigint] NOT NULL,
	[Bill_Status] [bit] NOT NULL,
	[Bill_ExtraFee] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[Bill_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Staticscal_Product_byDate]    Script Date: 04/02/2023 10:13:48 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[Staticscal_Product_byDate]
	as
		select top 3 p.Product_Name, sum(b.BI_Quantity) as [count_buy]
		from Product as p,Bill_Info as b,Bill as bi
		where b.BI_Product = p.Product_ID and bi.Bill_ID = b.BI_Bill and day(bi.Bill_TimeFrom) = DAY(GETDATE()) and month(bi.Bill_TimeFrom) = month(GETDATE()) and year(bi.Bill_TimeFrom) = year(GETDATE())
		group by p.Product_Name
		order by [count_buy] desc 
GO
/****** Object:  Table [dbo].[Category]    Script Date: 04/02/2023 10:13:48 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Category_ID] [int] IDENTITY(1,1) NOT NULL,
	[Category_Name] [nvarchar](255) NOT NULL,
	[Category_isActive] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Category_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Staticscal_Category]    Script Date: 04/02/2023 10:13:48 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[Staticscal_Category]
	as
		select c.Category_Name, sum(1) as [count_buy]
		from Category as c,Product as p,Bill_Info as b
		where p.Product_Category = c.Category_ID and b.BI_Product = p.Product_ID
		group by Category_Name
GO
/****** Object:  View [dbo].[Staticscal_Product]    Script Date: 04/02/2023 10:13:48 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[Staticscal_Product]
	as
		select top 5 p.Product_Name, sum(b.BI_Quantity) as [count_buy]
		from Product as p,Bill_Info as b
		where b.BI_Product = p.Product_ID
		group by p.Product_Name
		order by [count_buy] desc
GO
/****** Object:  Table [dbo].[ApplyDiscount]    Script Date: 04/02/2023 10:13:48 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ApplyDiscount](
	[Discount_ID] [int] NOT NULL,
	[Discount_Product] [int] NOT NULL,
 CONSTRAINT [PK_ApllyDiscount] PRIMARY KEY CLUSTERED 
(
	[Discount_ID] ASC,
	[Discount_Product] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bill_Surcharge]    Script Date: 04/02/2023 10:13:48 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill_Surcharge](
	[Bill_ID] [int] NOT NULL,
	[Surcharge_ID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Bill_ID] ASC,
	[Surcharge_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DBTable]    Script Date: 04/02/2023 10:13:48 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DBTable](
	[Table_Code] [varchar](10) NOT NULL,
	[Table_Location] [nvarchar](50) NOT NULL,
	[Table_Status] [int] NOT NULL,
	[isActive] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Table_Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Discount]    Script Date: 04/02/2023 10:13:48 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Discount](
	[Discount_ID] [int] IDENTITY(1,1) NOT NULL,
	[Discount_name] [nvarchar](200) NULL,
	[Discount_allProduct] [bit] NULL,
	[Discount_DateStart] [smalldatetime] NULL,
	[Discount_DateEnd] [smalldatetime] NULL,
	[Discount_Per] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Discount_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Import]    Script Date: 04/02/2023 10:13:48 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Import](
	[Import_ID] [int] IDENTITY(1,1) NOT NULL,
	[Import_Date] [datetime] NOT NULL,
	[Import_Staff] [varchar](10) NOT NULL,
	[Import_TotalMoney] [bigint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Import_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Import_Info]    Script Date: 04/02/2023 10:13:48 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Import_Info](
	[ImportInfo_ID] [int] IDENTITY(1,1) NOT NULL,
	[Import_ID] [int] NULL,
	[Info_Quantity] [float] NULL,
	[Info_Ingredient] [int] NULL,
	[info_Price] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[ImportInfo_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ingredient]    Script Date: 04/02/2023 10:13:48 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ingredient](
	[Ingredient_ID] [int] IDENTITY(1,1) NOT NULL,
	[Ingredient_Name] [nvarchar](100) NOT NULL,
	[Ingredient_Unit] [nvarchar](100) NOT NULL,
	[Ingredient_PriceImport] [bigint] NOT NULL,
	[Ingredient_isActive] [bit] NOT NULL,
	[Ingredient_Reserved] [float] NULL,
	[Ingredient_Image] [varbinary](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[Ingredient_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Payment]    Script Date: 04/02/2023 10:13:48 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payment](
	[Payment_ID] [int] IDENTITY(1,1) NOT NULL,
	[Payment_name] [nvarchar](200) NULL,
	[Payment_time] [smalldatetime] NULL,
	[Payment_Staff] [varchar](10) NULL,
	[Payment_money] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[Payment_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[receipts]    Script Date: 04/02/2023 10:13:48 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[receipts](
	[receipt_ID] [int] IDENTITY(1,1) NOT NULL,
	[receipt_name] [nvarchar](200) NULL,
	[receipt_time] [smalldatetime] NULL,
	[receipt_Staff] [varchar](10) NULL,
	[receipt_money] [bigint] NULL,
	[receipt_isMoneyImport] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[receipt_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Recipe]    Script Date: 04/02/2023 10:13:48 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Recipe](
	[Recipe_ID] [int] IDENTITY(1,1) NOT NULL,
	[Recipe_Info] [nvarchar](max) NULL,
	[Recipe_Product] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Recipe_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staff]    Script Date: 04/02/2023 10:13:48 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff](
	[Staff_Code] [varchar](10) NOT NULL,
	[Staff_Name] [nvarchar](100) NOT NULL,
	[Staff_Datebirth] [date] NULL,
	[Staff_Gender] [nvarchar](6) NULL,
	[Staff_Phone] [varchar](12) NULL,
	[Staff_Address] [nvarchar](max) NULL,
	[Staff_Password] [varchar](30) NOT NULL,
	[Staff_isAdmin] [bit] NOT NULL,
	[Staff_isActive] [bit] NOT NULL,
	[Staff_Image] [varbinary](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[Staff_Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Surcharge]    Script Date: 04/02/2023 10:13:48 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Surcharge](
	[Surcharge_ID] [int] IDENTITY(1,1) NOT NULL,
	[Surcharge_Name] [nvarchar](100) NOT NULL,
	[Surcharge_Price] [bigint] NOT NULL,
	[Surcharge_DateStart] [date] NOT NULL,
	[Surcharge_DateEnd] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[Surcharge_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Index [Bill_Bill_ID]    Script Date: 04/02/2023 10:13:48 SA ******/
CREATE NONCLUSTERED INDEX [Bill_Bill_ID] ON [dbo].[Bill]
(
	[Bill_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [Bill_Info_BI_ID]    Script Date: 04/02/2023 10:13:48 SA ******/
CREATE NONCLUSTERED INDEX [Bill_Info_BI_ID] ON [dbo].[Bill_Info]
(
	[BI_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [Category_Category_ID]    Script Date: 04/02/2023 10:13:48 SA ******/
CREATE NONCLUSTERED INDEX [Category_Category_ID] ON [dbo].[Category]
(
	[Category_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [Import_Import_ID]    Script Date: 04/02/2023 10:13:48 SA ******/
CREATE NONCLUSTERED INDEX [Import_Import_ID] ON [dbo].[Import]
(
	[Import_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [Ingredient_Ingredient_ID]    Script Date: 04/02/2023 10:13:48 SA ******/
CREATE NONCLUSTERED INDEX [Ingredient_Ingredient_ID] ON [dbo].[Ingredient]
(
	[Ingredient_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [Product_Product_ID]    Script Date: 04/02/2023 10:13:48 SA ******/
CREATE NONCLUSTERED INDEX [Product_Product_ID] ON [dbo].[Product]
(
	[Product_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [Staff_Staff_Code]    Script Date: 04/02/2023 10:13:48 SA ******/
CREATE NONCLUSTERED INDEX [Staff_Staff_Code] ON [dbo].[Staff]
(
	[Staff_Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [Surcharge_Surcharge_ID]    Script Date: 04/02/2023 10:13:48 SA ******/
CREATE NONCLUSTERED INDEX [Surcharge_Surcharge_ID] ON [dbo].[Surcharge]
(
	[Surcharge_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Bill] ADD  DEFAULT ((0)) FOR [Bill_Discount]
GO
ALTER TABLE [dbo].[Bill] ADD  DEFAULT ((0)) FOR [Bill_TotalMoney]
GO
ALTER TABLE [dbo].[Bill] ADD  DEFAULT ((0)) FOR [Bill_Status]
GO
ALTER TABLE [dbo].[Category] ADD  DEFAULT ((1)) FOR [Category_isActive]
GO
ALTER TABLE [dbo].[DBTable] ADD  DEFAULT ((0)) FOR [Table_Status]
GO
ALTER TABLE [dbo].[Ingredient] ADD  DEFAULT ((1)) FOR [Ingredient_isActive]
GO
ALTER TABLE [dbo].[Product] ADD  DEFAULT ((1)) FOR [Product_isActive]
GO
ALTER TABLE [dbo].[Staff] ADD  DEFAULT ((1)) FOR [Staff_isActive]
GO
ALTER TABLE [dbo].[ApplyDiscount]  WITH CHECK ADD  CONSTRAINT [FK_DiscountID] FOREIGN KEY([Discount_ID])
REFERENCES [dbo].[Discount] ([Discount_ID])
GO
ALTER TABLE [dbo].[ApplyDiscount] CHECK CONSTRAINT [FK_DiscountID]
GO
ALTER TABLE [dbo].[ApplyDiscount]  WITH CHECK ADD  CONSTRAINT [FK_DiscountProduct] FOREIGN KEY([Discount_Product])
REFERENCES [dbo].[Product] ([Product_ID])
GO
ALTER TABLE [dbo].[ApplyDiscount] CHECK CONSTRAINT [FK_DiscountProduct]
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD  CONSTRAINT [FKBill122024] FOREIGN KEY([Bill_Staff])
REFERENCES [dbo].[Staff] ([Staff_Code])
GO
ALTER TABLE [dbo].[Bill] CHECK CONSTRAINT [FKBill122024]
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD  CONSTRAINT [FKBill723377] FOREIGN KEY([Bill_Table])
REFERENCES [dbo].[DBTable] ([Table_Code])
GO
ALTER TABLE [dbo].[Bill] CHECK CONSTRAINT [FKBill723377]
GO
ALTER TABLE [dbo].[Bill_Info]  WITH CHECK ADD  CONSTRAINT [FKBill_Info16588] FOREIGN KEY([BI_Bill])
REFERENCES [dbo].[Bill] ([Bill_ID])
GO
ALTER TABLE [dbo].[Bill_Info] CHECK CONSTRAINT [FKBill_Info16588]
GO
ALTER TABLE [dbo].[Bill_Info]  WITH CHECK ADD  CONSTRAINT [FKBill_Info640249] FOREIGN KEY([BI_Product])
REFERENCES [dbo].[Product] ([Product_ID])
GO
ALTER TABLE [dbo].[Bill_Info] CHECK CONSTRAINT [FKBill_Info640249]
GO
ALTER TABLE [dbo].[Bill_Surcharge]  WITH CHECK ADD  CONSTRAINT [FKBill_Surch454692] FOREIGN KEY([Surcharge_ID])
REFERENCES [dbo].[Surcharge] ([Surcharge_ID])
GO
ALTER TABLE [dbo].[Bill_Surcharge] CHECK CONSTRAINT [FKBill_Surch454692]
GO
ALTER TABLE [dbo].[Bill_Surcharge]  WITH CHECK ADD  CONSTRAINT [FKBill_Surch974873] FOREIGN KEY([Bill_ID])
REFERENCES [dbo].[Bill] ([Bill_ID])
GO
ALTER TABLE [dbo].[Bill_Surcharge] CHECK CONSTRAINT [FKBill_Surch974873]
GO
ALTER TABLE [dbo].[Import]  WITH CHECK ADD  CONSTRAINT [FKImport434180] FOREIGN KEY([Import_Staff])
REFERENCES [dbo].[Staff] ([Staff_Code])
GO
ALTER TABLE [dbo].[Import] CHECK CONSTRAINT [FKImport434180]
GO
ALTER TABLE [dbo].[Import_Info]  WITH CHECK ADD  CONSTRAINT [FK_infoImport] FOREIGN KEY([Import_ID])
REFERENCES [dbo].[Import] ([Import_ID])
GO
ALTER TABLE [dbo].[Import_Info] CHECK CONSTRAINT [FK_infoImport]
GO
ALTER TABLE [dbo].[Import_Info]  WITH CHECK ADD  CONSTRAINT [FK_infoIngredient] FOREIGN KEY([Info_Ingredient])
REFERENCES [dbo].[Ingredient] ([Ingredient_ID])
GO
ALTER TABLE [dbo].[Import_Info] CHECK CONSTRAINT [FK_infoIngredient]
GO
ALTER TABLE [dbo].[Payment]  WITH CHECK ADD  CONSTRAINT [FK_Payment_staff] FOREIGN KEY([Payment_Staff])
REFERENCES [dbo].[Staff] ([Staff_Code])
GO
ALTER TABLE [dbo].[Payment] CHECK CONSTRAINT [FK_Payment_staff]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FKProduct568957] FOREIGN KEY([Product_Category])
REFERENCES [dbo].[Category] ([Category_ID])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FKProduct568957]
GO
ALTER TABLE [dbo].[receipts]  WITH CHECK ADD  CONSTRAINT [FK_receipts_staff] FOREIGN KEY([receipt_Staff])
REFERENCES [dbo].[Staff] ([Staff_Code])
GO
ALTER TABLE [dbo].[receipts] CHECK CONSTRAINT [FK_receipts_staff]
GO
ALTER TABLE [dbo].[Recipe]  WITH CHECK ADD  CONSTRAINT [FK_RecipeProduct] FOREIGN KEY([Recipe_Product])
REFERENCES [dbo].[Product] ([Product_ID])
GO
ALTER TABLE [dbo].[Recipe] CHECK CONSTRAINT [FK_RecipeProduct]
GO
/****** Object:  StoredProcedure [dbo].[addDiscountApply]    Script Date: 04/02/2023 10:13:48 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[addDiscountApply]
@DiscountID int, @ProductID int
as
	begin
		insert into ApplyDiscount values (@DiscountID,@ProductID)
	end
GO
/****** Object:  StoredProcedure [dbo].[addSurchange]    Script Date: 04/02/2023 10:13:48 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[addSurchange]
@billid int, @surid int
as
	begin
		insert into Bill_Surcharge values (@billid,@surid)
	end
GO
/****** Object:  StoredProcedure [dbo].[checkSurcharge]    Script Date: 04/02/2023 10:13:48 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[checkSurcharge]
@billid int
as
	begin
		select count(*) from Bill_Surcharge where Bill_ID = @billid
	end
GO
/****** Object:  StoredProcedure [dbo].[deleteDiscountApply]    Script Date: 04/02/2023 10:13:48 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[deleteDiscountApply]
@DiscountID int
as
	begin
	delete from ApplyDiscount where Discount_ID = @DiscountID
	end
GO
/****** Object:  StoredProcedure [dbo].[exportBillNoTakeAway]    Script Date: 04/02/2023 10:13:48 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[exportBillNoTakeAway]
@BillID int
as
	begin
		select b.Bill_ID as 'Bill_Code',s.Staff_Name as 'Bill_Staff',p.Product_Name as 'Bill_Product',bi.BI_Quantity as 'Bill_Quantity',p.Product_Price as 'Bill_UnitPrice' ,b.Bill_ExtraFee,b.Bill_Discount,b.Bill_TotalMoney,b.Bill_Table,b.Bill_TimeFrom,b.Bill_TimeTo
		from Bill as b,Staff as s , Bill_Info as bi, Product as p
		where b.Bill_ID = @BillID and s.Staff_Code = b.Bill_Staff and  bi.BI_Bill =  b.Bill_ID and p.Product_ID = bi.BI_Product
	end
GO
/****** Object:  StoredProcedure [dbo].[exportBillTakeAway]    Script Date: 04/02/2023 10:13:48 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[exportBillTakeAway]
@BillID  int
as
	begin
		select b.Bill_ID as 'Bill_Code',s.Staff_Name as 'Bill_Staff',p.Product_Name as 'Bill_Product',bi.BI_Quantity as 'Bill_Quantity',p.Product_Price as 'Bill_UnitPrice' ,b.Bill_ExtraFee,b.Bill_Discount,b.Bill_TotalMoney
		from Bill as b,Staff as s , Bill_Info as bi, Product as p
		where b.Bill_ID = @BillID and s.Staff_Code = b.Bill_Staff and  bi.BI_Bill =  b.Bill_ID and p.Product_ID = bi.BI_Product
	end
GO
/****** Object:  StoredProcedure [dbo].[exportbyDate]    Script Date: 04/02/2023 10:13:48 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[exportbyDate]
@dayexport int, @monexport int, @yearexport int
 as
	begin
	   (select  r.receipt_ID as 'IDExport',r.receipt_name as 'NameExport',s.Staff_Name as 'StaffExport',r.receipt_isMoneyImport as 'TypeExport',r.receipt_money as 'MoneyExport'
	   from  Staff as s , receipts as r
	   where Day(r.receipt_time) = @dayexport and MONTH(r.receipt_time) = @monexport and YEAR(r.receipt_time) = @yearexport and s.Staff_Code = r.receipt_Staff)
	   union
	   (select  p.Payment_ID as 'IDExport',p.Payment_name as 'NameExport',s.Staff_Name as 'StaffExport',2 as 'TypeExport',p.Payment_money as 'MoneyExport'
	   from  Staff as s , Payment as p
	   where Day(p.Payment_time) = @dayexport and MONTH(p.Payment_time) = @monexport and YEAR(p.Payment_time) = @yearexport and s.Staff_Code = p.Payment_Staff)
	end
GO
/****** Object:  StoredProcedure [dbo].[exportDate]    Script Date: 04/02/2023 10:13:48 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[exportDate]
 as
	begin
	   declare @dayexport int, @monexport int, @yearexport int
	   set @dayexport = DAY(GETDATE())
	   set @monexport = month(GETDATE())
	   set @yearexport = year(GETDATE())
	   (select  r.receipt_ID as 'IDExport',r.receipt_name as 'NameExport',s.Staff_Name as 'StaffExport',r.receipt_isMoneyImport as 'TypeExport',r.receipt_money as 'MoneyExport'
	   from  Staff as s , receipts as r
	   where Day(r.receipt_time) = @dayexport and MONTH(r.receipt_time) = @monexport and YEAR(r.receipt_time) = @yearexport and s.Staff_Code = r.receipt_Staff)
	   union
	   (select  p.Payment_ID as 'IDExport',p.Payment_name as 'NameExport',s.Staff_Name as 'StaffExport',2 as 'TypeExport',p.Payment_money as 'MoneyExport'
	   from  Staff as s , Payment as p
	   where Day(p.Payment_time) = @dayexport and MONTH(p.Payment_time) = @monexport and YEAR(p.Payment_time) = @yearexport and s.Staff_Code = p.Payment_Staff)
	end
GO
/****** Object:  StoredProcedure [dbo].[exportDatebyStaff]    Script Date: 04/02/2023 10:13:48 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[exportDatebyStaff]
@staffid varchar(10)
 as
	begin
	   declare @dayexport int, @monexport int, @yearexport int
	   set @dayexport = DAY(GETDATE())
	   set @monexport = month(GETDATE())
	   set @yearexport = year(GETDATE())
	   (select  r.receipt_ID as 'IDExport',r.receipt_name as 'NameExport',s.Staff_Name as 'StaffExport',r.receipt_isMoneyImport as 'TypeExport',r.receipt_money as 'MoneyExport'
	   from  Staff as s , receipts as r
	   where Day(r.receipt_time) = @dayexport and MONTH(r.receipt_time) = @monexport and YEAR(r.receipt_time) = @yearexport and s.Staff_Code = @staffid and s.Staff_Code = r.receipt_Staff) 
	   union
	   (select  p.Payment_ID as 'IDExport',p.Payment_name as 'NameExport',s.Staff_Name as 'StaffExport',2 as 'TypeExport',p.Payment_money as 'MoneyExport'
	   from  Staff as s , Payment as p
	   where Day(p.Payment_time) = @dayexport and MONTH(p.Payment_time) = @monexport and YEAR(p.Payment_time) = @yearexport and s.Staff_Code = @staffid and s.Staff_Code = p.Payment_Staff)
	end
GO
/****** Object:  StoredProcedure [dbo].[exportIImport]    Script Date: 04/02/2023 10:13:48 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[exportIImport]
@ImportID int
as
	begin
		select i.Import_ID,i.Import_Date,s.Staff_Name as 'Import_Staff',ing.Ingredient_Name as 'Import_Ingredient',ii.Info_Quantity as 'Import_Quantity',ing.Ingredient_Unit as 'Import_Unit',ii.Info_Price as 'Import_Price',i.Import_TotalMoney
		from Import as i, Import_Info as ii, Ingredient as ing, Staff as s
		where i.Import_ID = @ImportID and ii.Import_ID = i.Import_ID and ing.Ingredient_ID = ii.Info_Ingredient and s.Staff_Code = i.Import_Staff
	end
GO
/****** Object:  StoredProcedure [dbo].[FindDiscount]    Script Date: 04/02/2023 10:13:48 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	create proc [dbo].[FindDiscount]
	@DiscountID int
	as
		begin
			select * from ApplyDiscount where Discount_ID = @DiscountID
		end
GO
/****** Object:  StoredProcedure [dbo].[getListDiscount]    Script Date: 04/02/2023 10:13:48 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getListDiscount]
@DiscountID int
as
	begin
		select * from ApplyDiscount where Discount_ID = @DiscountID
	end
GO
/****** Object:  StoredProcedure [dbo].[getSurcharge]    Script Date: 04/02/2023 10:13:48 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  create proc [dbo].[getSurcharge]
  @billId int
  as
	begin
		select * from Bill_Surcharge where Bill_ID = @billId
	end
GO
/****** Object:  StoredProcedure [dbo].[removeFullSurchange]    Script Date: 04/02/2023 10:13:48 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[removeFullSurchange]
@billid int
as
	begin
		delete from Bill_Surcharge where Bill_ID = @billid
	end
GO
/****** Object:  StoredProcedure [dbo].[removeSurchange]    Script Date: 04/02/2023 10:13:48 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[removeSurchange]
@billid int, @surid int
as
	begin
		delete from Bill_Surcharge where Bill_ID = @billid and Surcharge_ID = @surid
	end
GO
/****** Object:  StoredProcedure [dbo].[TotalMoney]    Script Date: 04/02/2023 10:13:48 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TotalMoney]
@BillID int
as
	begin
		select SUM(BI_Quantity*Product_Price) from Bill_Info,Product where BI_Bill = @BillID and Product_ID=BI_Product group by BI_Bill
	end
GO
USE [master]
GO
ALTER DATABASE [TheLightCoffee] SET  READ_WRITE 
GO
