USE [master]
GO
/****** Object:  Database [NavAssignment]    Script Date: 20-04-2021 09:02:32 ******/
CREATE DATABASE [NavAssignment]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'NavAssignment', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\NavAssignment.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'NavAssignment_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\NavAssignment_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [NavAssignment] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [NavAssignment].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [NavAssignment] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [NavAssignment] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [NavAssignment] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [NavAssignment] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [NavAssignment] SET ARITHABORT OFF 
GO
ALTER DATABASE [NavAssignment] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [NavAssignment] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [NavAssignment] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [NavAssignment] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [NavAssignment] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [NavAssignment] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [NavAssignment] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [NavAssignment] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [NavAssignment] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [NavAssignment] SET  ENABLE_BROKER 
GO
ALTER DATABASE [NavAssignment] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [NavAssignment] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [NavAssignment] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [NavAssignment] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [NavAssignment] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [NavAssignment] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [NavAssignment] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [NavAssignment] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [NavAssignment] SET  MULTI_USER 
GO
ALTER DATABASE [NavAssignment] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [NavAssignment] SET DB_CHAINING OFF 
GO
ALTER DATABASE [NavAssignment] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [NavAssignment] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [NavAssignment] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [NavAssignment] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [NavAssignment] SET QUERY_STORE = OFF
GO
USE [NavAssignment]
GO
/****** Object:  User [PG]    Script Date: 20-04-2021 09:02:33 ******/
CREATE USER [PG] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [Ganesh]    Script Date: 20-04-2021 09:02:33 ******/
CREATE USER [Ganesh] FOR LOGIN [Ganesh] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 20-04-2021 09:02:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[customerId] [int] IDENTITY(1,1) NOT NULL,
	[customername] [varchar](256) NULL,
	[mobileNumber] [varchar](256) NULL,
	[emailId] [varchar](256) NULL,
	[gender] [bit] NULL,
	[customerAddress] [varchar](256) NULL,
	[isStatus] [bit] NULL,
	[createdDate] [datetime] NULL,
	[updatedDate] [datetime] NULL,
	[createdUserBy] [varchar](256) NULL,
	[updatedUserBy] [varchar](256) NULL,
PRIMARY KEY CLUSTERED 
(
	[customerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderItems]    Script Date: 20-04-2021 09:02:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderItems](
	[ItemID] [int] IDENTITY(1,1) NOT NULL,
	[OrderID] [int] NULL,
	[productId] [int] NULL,
	[itemPrice] [float] NULL,
	[ItemQuantity] [int] NULL,
	[DiscountAmount] [float] NULL,
	[GrandTotal] [float] NULL,
	[Remarks] [varchar](200) NULL,
	[isStatus] [bit] NULL,
	[createdDate] [datetime] NULL,
	[updatedDate] [datetime] NULL,
	[createdUserBy] [varchar](256) NULL,
	[updatedUserBy] [varchar](256) NULL,
PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 20-04-2021 09:02:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[orderId] [int] IDENTITY(1,1) NOT NULL,
	[CustomerId] [int] NULL,
	[OrderDate] [datetime] NULL,
	[OrderType] [varchar](256) NULL,
	[TotalAmount] [float] NULL,
	[DiscountAmount] [float] NULL,
	[GrandTotal] [float] NULL,
	[PaymentType] [varchar](256) NULL,
	[PaymentDate] [datetime] NULL,
	[deliveryDate] [datetime] NULL,
	[noofItems] [int] NULL,
	[deliveryType] [varchar](256) NULL,
	[isStatus] [bit] NULL,
	[createdDate] [datetime] NULL,
	[updatedDate] [datetime] NULL,
	[createdUserBy] [varchar](256) NULL,
	[updatedUserBy] [varchar](256) NULL,
PRIMARY KEY CLUSTERED 
(
	[orderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 20-04-2021 09:02:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[productId] [int] IDENTITY(1,1) NOT NULL,
	[productName] [varchar](256) NULL,
	[code] [varchar](256) NULL,
	[productDescription] [varchar](256) NULL,
	[stocksLeft] [int] NULL,
	[stockQuantity] [int] NULL,
	[actualPrice] [float] NULL,
	[offeredPrice] [float] NULL,
	[isStatus] [bit] NULL,
	[createdDate] [datetime] NULL,
	[updatedDate] [datetime] NULL,
	[createdUserBy] [varchar](256) NULL,
	[updatedUserBy] [varchar](256) NULL,
PRIMARY KEY CLUSTERED 
(
	[productId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[OrderItems]  WITH CHECK ADD FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([orderId])
GO
ALTER TABLE [dbo].[OrderItems]  WITH CHECK ADD FOREIGN KEY([productId])
REFERENCES [dbo].[Products] ([productId])
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([customerId])
GO
/****** Object:  StoredProcedure [dbo].[GetCustomerOrderItemList]    Script Date: 20-04-2021 09:02:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[GetCustomerOrderItemList]
As
begin

select 
C.customerId, 
C.customername,
O.orderId,
O.deliveryDate,
O.deliveryType,
O.GrandTotal,
O.noofItems,
O.PaymentType,
C.emailId,
O.OrderDate,
O.createdDate
from [dbo].[Customer] C 
inner join [dbo].[Orders] O on O.CustomerId=C.customerId
inner join [dbo].[OrderItems] OI on OI.OrderID=O.orderId 
end




GO
/****** Object:  StoredProcedure [dbo].[GetCustomerOrderList]    Script Date: 20-04-2021 09:02:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[GetCustomerOrderList]
As
begin

select 
C.customerId, 
C.customername,
O.orderId,
O.deliveryDate,
O.deliveryType,
O.GrandTotal,
O.noofItems,
O.PaymentType,
C.emailId,
O.OrderDate,
O.createdDate
from [dbo].[Customer] C 
inner join [dbo].[Orders] O on O.CustomerId=C.customerId

end
GO
USE [master]
GO
ALTER DATABASE [NavAssignment] SET  READ_WRITE 
GO
