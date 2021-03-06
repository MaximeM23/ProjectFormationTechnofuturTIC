USE [master]
GO
/****** Object:  Database [WineSellingProject]    Script Date: 02-02-21 14:54:46 ******/
CREATE DATABASE [WineSellingProject]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'WineSellingProject', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\WineSellingProject.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'WineSellingProject_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\WineSellingProject_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [WineSellingProject] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [WineSellingProject].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [WineSellingProject] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [WineSellingProject] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [WineSellingProject] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [WineSellingProject] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [WineSellingProject] SET ARITHABORT OFF 
GO
ALTER DATABASE [WineSellingProject] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [WineSellingProject] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [WineSellingProject] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [WineSellingProject] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [WineSellingProject] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [WineSellingProject] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [WineSellingProject] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [WineSellingProject] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [WineSellingProject] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [WineSellingProject] SET  ENABLE_BROKER 
GO
ALTER DATABASE [WineSellingProject] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [WineSellingProject] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [WineSellingProject] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [WineSellingProject] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [WineSellingProject] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [WineSellingProject] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [WineSellingProject] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [WineSellingProject] SET RECOVERY FULL 
GO
ALTER DATABASE [WineSellingProject] SET  MULTI_USER 
GO
ALTER DATABASE [WineSellingProject] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [WineSellingProject] SET DB_CHAINING OFF 
GO
ALTER DATABASE [WineSellingProject] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [WineSellingProject] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [WineSellingProject] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [WineSellingProject] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'WineSellingProject', N'ON'
GO
ALTER DATABASE [WineSellingProject] SET QUERY_STORE = OFF
GO
USE [WineSellingProject]
GO
/****** Object:  Table [dbo].[Address]    Script Date: 02-02-21 14:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Address](
	[IdAddress] [int] IDENTITY(1,1) NOT NULL,
	[Street] [nvarchar](50) NOT NULL,
	[Number] [nvarchar](10) NOT NULL,
	[IdCity] [int] NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_Address] PRIMARY KEY CLUSTERED 
(
	[IdAddress] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Advertisement]    Script Date: 02-02-21 14:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Advertisement](
	[IdAdvertisement] [int] IDENTITY(1,1) NOT NULL,
	[Description] [text] NOT NULL,
	[DatePublication] [datetime] NOT NULL,
	[IdProvider] [int] NOT NULL,
	[IdPicture] [int] NOT NULL,
 CONSTRAINT [PK_Advertisement] PRIMARY KEY CLUSTERED 
(
	[IdAdvertisement] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 02-02-21 14:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[IdCategory] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](50) NOT NULL,
	[IdTag] [int] NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[IdCategory] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[City]    Script Date: 02-02-21 14:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[City](
	[IdCity] [int] IDENTITY(1,1) NOT NULL,
	[CityName] [nvarchar](50) NOT NULL,
	[PostalCode] [nvarchar](10) NULL,
	[Country] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_City] PRIMARY KEY CLUSTERED 
(
	[IdCity] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 02-02-21 14:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[IdClient] [int] IDENTITY(1,1) NOT NULL,
	[Firstname] [nvarchar](50) NULL,
	[Lastname] [nvarchar](50) NULL,
	[EmailAddress] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[Salt] [nvarchar](8) NOT NULL,
	[PhoneNumber] [nvarchar](20) NULL,
	[BirthDate] [date] NULL,
	[Active] [bit] NOT NULL,
	[IdRole] [int] NOT NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[IdClient] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [U_EmailAddress_Client] UNIQUE NONCLUSTERED 
(
	[EmailAddress] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ClientAddress]    Script Date: 02-02-21 14:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClientAddress](
	[IdClientAddress] [int] IDENTITY(1,1) NOT NULL,
	[IdAddress] [int] NOT NULL,
	[IdClient] [int] NOT NULL,
 CONSTRAINT [PK_ClientAddress] PRIMARY KEY CLUSTERED 
(
	[IdClientAddress] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Command]    Script Date: 02-02-21 14:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Command](
	[IdCommand] [int] IDENTITY(1,1) NOT NULL,
	[DateOfCommand] [datetime] NOT NULL,
	[IdClientAddress] [int] NOT NULL,
	[IdClient] [int] NOT NULL,
 CONSTRAINT [PK_Command] PRIMARY KEY CLUSTERED 
(
	[IdCommand] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CommandWine]    Script Date: 02-02-21 14:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CommandWine](
	[IdCommandWine] [int] IDENTITY(1,1) NOT NULL,
	[Quantity] [int] NOT NULL,
	[IdWine] [int] NOT NULL,
	[IdCommand] [int] NOT NULL,
 CONSTRAINT [PK_CommandWine] PRIMARY KEY CLUSTERED 
(
	[IdCommandWine] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comment]    Script Date: 02-02-21 14:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comment](
	[IdComment] [int] IDENTITY(1,1) NOT NULL,
	[Comment] [text] NULL,
	[Note] [tinyint] NOT NULL,
	[IdClient] [int] NOT NULL,
	[IdWine] [int] NOT NULL,
 CONSTRAINT [PK_Comment] PRIMARY KEY CLUSTERED 
(
	[IdComment] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Picture]    Script Date: 02-02-21 14:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Picture](
	[IdPicture] [int] IDENTITY(1,1) NOT NULL,
	[NameUrl] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Picture] PRIMARY KEY CLUSTERED 
(
	[IdPicture] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Price]    Script Date: 02-02-21 14:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Price](
	[DateOfPrice] [datetime] NOT NULL,
	[IdWine] [int] NOT NULL,
	[Price] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_Price] PRIMARY KEY CLUSTERED 
(
	[DateOfPrice] ASC,
	[IdWine] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Provider]    Script Date: 02-02-21 14:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provider](
	[IdProvider] [int] IDENTITY(1,1) NOT NULL,
	[ProviderName] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](500) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[Salt] [nvarchar](8) NOT NULL,
	[EmailAddress] [nvarchar](50) NOT NULL,
	[PhoneNumber] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Provider] PRIMARY KEY CLUSTERED 
(
	[IdProvider] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [U_EmailAddress_Provider] UNIQUE NONCLUSTERED 
(
	[EmailAddress] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProviderAddress]    Script Date: 02-02-21 14:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProviderAddress](
	[IdAddress] [int] NOT NULL,
	[IdProvider] [int] NOT NULL,
 CONSTRAINT [PK_ProviderAddress] PRIMARY KEY CLUSTERED 
(
	[IdAddress] ASC,
	[IdProvider] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProviderPicture]    Script Date: 02-02-21 14:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProviderPicture](
	[IdProvider] [int] NOT NULL,
	[IdPicture] [int] NOT NULL,
 CONSTRAINT [PK_ProviderPicture] PRIMARY KEY CLUSTERED 
(
	[IdProvider] ASC,
	[IdPicture] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 02-02-21 14:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[IdRole] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[IdRole] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [U_RoleName] UNIQUE NONCLUSTERED 
(
	[RoleName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tag]    Script Date: 02-02-21 14:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tag](
	[IdTag] [int] IDENTITY(1,1) NOT NULL,
	[TagName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_IdTag] PRIMARY KEY CLUSTERED 
(
	[IdTag] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Wine]    Script Date: 02-02-21 14:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Wine](
	[IdWine] [int] IDENTITY(1,1) NOT NULL,
	[WineName] [nvarchar](50) NOT NULL,
	[Description] [text] NOT NULL,
	[Year] [int] NOT NULL,
	[Disabled] [bit] NOT NULL,
	[IdProvider] [int] NOT NULL,
 CONSTRAINT [PK_Wine] PRIMARY KEY CLUSTERED 
(
	[IdWine] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WineCategory]    Script Date: 02-02-21 14:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WineCategory](
	[IdWine] [int] NOT NULL,
	[IdCategory] [int] NOT NULL,
 CONSTRAINT [PK_WineCategory] PRIMARY KEY CLUSTERED 
(
	[IdWine] ASC,
	[IdCategory] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WinePicture]    Script Date: 02-02-21 14:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WinePicture](
	[IdWine] [int] NOT NULL,
	[IdPicture] [int] NOT NULL,
 CONSTRAINT [PK_WinePicture] PRIMARY KEY CLUSTERED 
(
	[IdWine] ASC,
	[IdPicture] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Address] ADD  CONSTRAINT [DF_Address_Active]  DEFAULT ((1)) FOR [Active]
GO
ALTER TABLE [dbo].[Address]  WITH CHECK ADD  CONSTRAINT [FK_City_Address] FOREIGN KEY([IdCity])
REFERENCES [dbo].[City] ([IdCity])
GO
ALTER TABLE [dbo].[Address] CHECK CONSTRAINT [FK_City_Address]
GO
ALTER TABLE [dbo].[Advertisement]  WITH CHECK ADD  CONSTRAINT [FK_Picture_Advertisement] FOREIGN KEY([IdPicture])
REFERENCES [dbo].[Picture] ([IdPicture])
GO
ALTER TABLE [dbo].[Advertisement] CHECK CONSTRAINT [FK_Picture_Advertisement]
GO
ALTER TABLE [dbo].[Advertisement]  WITH CHECK ADD  CONSTRAINT [FK_Provider_Advertisement] FOREIGN KEY([IdProvider])
REFERENCES [dbo].[Provider] ([IdProvider])
GO
ALTER TABLE [dbo].[Advertisement] CHECK CONSTRAINT [FK_Provider_Advertisement]
GO
ALTER TABLE [dbo].[Category]  WITH CHECK ADD  CONSTRAINT [FK_Tag_Category] FOREIGN KEY([IdTag])
REFERENCES [dbo].[Tag] ([IdTag])
GO
ALTER TABLE [dbo].[Category] CHECK CONSTRAINT [FK_Tag_Category]
GO
ALTER TABLE [dbo].[Client]  WITH CHECK ADD  CONSTRAINT [FK_Role_Client] FOREIGN KEY([IdRole])
REFERENCES [dbo].[Role] ([IdRole])
GO
ALTER TABLE [dbo].[Client] CHECK CONSTRAINT [FK_Role_Client]
GO
ALTER TABLE [dbo].[ClientAddress]  WITH CHECK ADD  CONSTRAINT [FK_Address_ClientAddress] FOREIGN KEY([IdAddress])
REFERENCES [dbo].[Address] ([IdAddress])
GO
ALTER TABLE [dbo].[ClientAddress] CHECK CONSTRAINT [FK_Address_ClientAddress]
GO
ALTER TABLE [dbo].[ClientAddress]  WITH CHECK ADD  CONSTRAINT [FK_Client_ClientAddress] FOREIGN KEY([IdClient])
REFERENCES [dbo].[Client] ([IdClient])
GO
ALTER TABLE [dbo].[ClientAddress] CHECK CONSTRAINT [FK_Client_ClientAddress]
GO
ALTER TABLE [dbo].[Command]  WITH CHECK ADD  CONSTRAINT [FK_Client_Command] FOREIGN KEY([IdClient])
REFERENCES [dbo].[Client] ([IdClient])
GO
ALTER TABLE [dbo].[Command] CHECK CONSTRAINT [FK_Client_Command]
GO
ALTER TABLE [dbo].[Command]  WITH CHECK ADD  CONSTRAINT [FK_ClientAddress_Command] FOREIGN KEY([IdClientAddress])
REFERENCES [dbo].[ClientAddress] ([IdClientAddress])
GO
ALTER TABLE [dbo].[Command] CHECK CONSTRAINT [FK_ClientAddress_Command]
GO
ALTER TABLE [dbo].[CommandWine]  WITH CHECK ADD  CONSTRAINT [FK_Command_CommandWine] FOREIGN KEY([IdCommand])
REFERENCES [dbo].[Command] ([IdCommand])
GO
ALTER TABLE [dbo].[CommandWine] CHECK CONSTRAINT [FK_Command_CommandWine]
GO
ALTER TABLE [dbo].[CommandWine]  WITH CHECK ADD  CONSTRAINT [FK_Wine_CommandWine] FOREIGN KEY([IdWine])
REFERENCES [dbo].[Wine] ([IdWine])
GO
ALTER TABLE [dbo].[CommandWine] CHECK CONSTRAINT [FK_Wine_CommandWine]
GO
ALTER TABLE [dbo].[Comment]  WITH CHECK ADD  CONSTRAINT [FK_Client_Comment] FOREIGN KEY([IdClient])
REFERENCES [dbo].[Client] ([IdClient])
GO
ALTER TABLE [dbo].[Comment] CHECK CONSTRAINT [FK_Client_Comment]
GO
ALTER TABLE [dbo].[Comment]  WITH CHECK ADD  CONSTRAINT [FK_Wine_Comment] FOREIGN KEY([IdWine])
REFERENCES [dbo].[Wine] ([IdWine])
GO
ALTER TABLE [dbo].[Comment] CHECK CONSTRAINT [FK_Wine_Comment]
GO
ALTER TABLE [dbo].[Price]  WITH CHECK ADD  CONSTRAINT [FK_Wine_Price] FOREIGN KEY([IdWine])
REFERENCES [dbo].[Wine] ([IdWine])
GO
ALTER TABLE [dbo].[Price] CHECK CONSTRAINT [FK_Wine_Price]
GO
ALTER TABLE [dbo].[ProviderAddress]  WITH CHECK ADD  CONSTRAINT [FK_Address_ProviderAddress] FOREIGN KEY([IdAddress])
REFERENCES [dbo].[Address] ([IdAddress])
GO
ALTER TABLE [dbo].[ProviderAddress] CHECK CONSTRAINT [FK_Address_ProviderAddress]
GO
ALTER TABLE [dbo].[ProviderAddress]  WITH CHECK ADD  CONSTRAINT [FK_Provider_ProviderAddress] FOREIGN KEY([IdProvider])
REFERENCES [dbo].[Provider] ([IdProvider])
GO
ALTER TABLE [dbo].[ProviderAddress] CHECK CONSTRAINT [FK_Provider_ProviderAddress]
GO
ALTER TABLE [dbo].[ProviderPicture]  WITH CHECK ADD  CONSTRAINT [FK_Picture_ProviderPicture] FOREIGN KEY([IdPicture])
REFERENCES [dbo].[Picture] ([IdPicture])
GO
ALTER TABLE [dbo].[ProviderPicture] CHECK CONSTRAINT [FK_Picture_ProviderPicture]
GO
ALTER TABLE [dbo].[ProviderPicture]  WITH CHECK ADD  CONSTRAINT [FK_Provider_ProviderPicture] FOREIGN KEY([IdProvider])
REFERENCES [dbo].[Provider] ([IdProvider])
GO
ALTER TABLE [dbo].[ProviderPicture] CHECK CONSTRAINT [FK_Provider_ProviderPicture]
GO
ALTER TABLE [dbo].[Wine]  WITH CHECK ADD  CONSTRAINT [FK_Provider_Wine] FOREIGN KEY([IdProvider])
REFERENCES [dbo].[Provider] ([IdProvider])
GO
ALTER TABLE [dbo].[Wine] CHECK CONSTRAINT [FK_Provider_Wine]
GO
ALTER TABLE [dbo].[WineCategory]  WITH CHECK ADD  CONSTRAINT [FK_Category_WineCategory] FOREIGN KEY([IdCategory])
REFERENCES [dbo].[Category] ([IdCategory])
GO
ALTER TABLE [dbo].[WineCategory] CHECK CONSTRAINT [FK_Category_WineCategory]
GO
ALTER TABLE [dbo].[WineCategory]  WITH CHECK ADD  CONSTRAINT [FK_Wine_WineCategory] FOREIGN KEY([IdWine])
REFERENCES [dbo].[Wine] ([IdWine])
GO
ALTER TABLE [dbo].[WineCategory] CHECK CONSTRAINT [FK_Wine_WineCategory]
GO
ALTER TABLE [dbo].[WinePicture]  WITH CHECK ADD  CONSTRAINT [FK_Picture_WinePicture] FOREIGN KEY([IdPicture])
REFERENCES [dbo].[Picture] ([IdPicture])
GO
ALTER TABLE [dbo].[WinePicture] CHECK CONSTRAINT [FK_Picture_WinePicture]
GO
ALTER TABLE [dbo].[WinePicture]  WITH CHECK ADD  CONSTRAINT [FK_Wine_WinePicture] FOREIGN KEY([IdWine])
REFERENCES [dbo].[Wine] ([IdWine])
GO
ALTER TABLE [dbo].[WinePicture] CHECK CONSTRAINT [FK_Wine_WinePicture]
GO
ALTER TABLE [dbo].[CommandWine]  WITH CHECK ADD  CONSTRAINT [CK_QuantityGreaterThanZeroOrEquals] CHECK  (([Quantity]>=(0)))
GO
ALTER TABLE [dbo].[CommandWine] CHECK CONSTRAINT [CK_QuantityGreaterThanZeroOrEquals]
GO
ALTER TABLE [dbo].[Comment]  WITH CHECK ADD  CONSTRAINT [CK_NoteBetweenZeroAndFive] CHECK  (([Note]>=(0) AND [Note]<=(5)))
GO
ALTER TABLE [dbo].[Comment] CHECK CONSTRAINT [CK_NoteBetweenZeroAndFive]
GO
/****** Object:  StoredProcedure [dbo].[CreateAddress]    Script Date: 02-02-21 14:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CreateAddress]
	@IdCity INT,
	@Street NVARCHAR(50),
	@Number NVARCHAR(50)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO [Address](IdCity,Number,Street)
	OUTPUT inserted.IdAddress
	VALUES (@IdCity,@Number,@Street)
END
GO
/****** Object:  StoredProcedure [dbo].[CreateClient]    Script Date: 02-02-21 14:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CreateClient] 
	@fn NVARCHAR(50),
	@ln NVARCHAR(50),
	@EmailAddress NVARCHAR(50),
	@Password NVARCHAR(MAX),
	@PhoneNumber NVARCHAR(20),
	@BirthDate Date
AS
BEGIN

	DECLARE @IdRole int
	SET @IdRole = (SELECT IdRole FROM [Role] WHERE RoleName = 'Client')
    INSERT INTO Client(Firstname,Lastname,EmailAddress,[Password],PhoneNumber, BirthDate, Active, IdRole, Salt) 
	OUTPUT inserted.IdClient
				VALUES(@fn,@ln,@EmailAddress,@Password,@PhoneNumber,convert(date, @BirthDate, 105),'1','3', '0000000')
END
GO
/****** Object:  StoredProcedure [dbo].[CreateClientAddress]    Script Date: 02-02-21 14:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CreateClientAddress]
	@IdAddress INT,
	@IdClient INT
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO ClientAddress(IdAddress,IdClient) VALUES (@IdAddress,@IdClient)
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteAddress]    Script Date: 02-02-21 14:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteAddress]
	@IdAddress INT
AS
BEGIN
	UPDATE [Address]
	SET Active = 0
	WHERE IdAddress = @IdAddress
END
GO
/****** Object:  StoredProcedure [dbo].[DisableWine]    Script Date: 02-02-21 14:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DisableWine]
	@IdWine INT
AS
BEGIN
	UPDATE Wine
	SET [Disabled] = 1
	WHERE IdWine = @IdWine
END
GO
/****** Object:  StoredProcedure [dbo].[EnableWineById]    Script Date: 02-02-21 14:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EnableWineById] 
	@Id INT
AS
BEGIN
	UPDATE Wine
	SET [Disabled] = 0
	WHERE IdWine = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[FindEmail]    Script Date: 02-02-21 14:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[FindEmail]
	@email NVARCHAR(50),
	@idUser INT
AS
BEGIN
	SET NOCOUNT ON;
	SELECT IdClient
	FROM Client
	WHERE EmailAddress = @email AND IdClient != @idUser
END
GO
/****** Object:  StoredProcedure [dbo].[GetAddressByClientAddressId]    Script Date: 02-02-21 14:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAddressByClientAddressId] 
	@IdClientAddress INT
AS
BEGIN
	SELECT [Address].IdAddress,Street,Number,IdCity
	FROM [Address]
	JOIN ClientAddress ON ClientAddress.IdAddress = [Address].IdAddress
	WHERE IdClientAddress = @IdClientAddress
END
GO
/****** Object:  StoredProcedure [dbo].[GetAddressesForUser]    Script Date: 02-02-21 14:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAddressesForUser]
	@Id INT
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT [Address].IdAddress ,Street,Number,IdCity, Active
	FROM [Address]
	JOIN ClientAddress ON [Address].IdAddress = ClientAddress.IdAddress AND ClientAddress.IdClient = @Id
	WHERE Active = 1
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllCategoriesByIdType]    Script Date: 02-02-21 14:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllCategoriesByIdType] 
	@IdType INT
AS
BEGIN
	SELECT IdCategory, CategoryName,IdTag
	FROM Category
	WHERE IdTag = @IdType
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllCommandWineByCommandId]    Script Date: 02-02-21 14:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllCommandWineByCommandId]
	@IdCommand INT
AS
BEGIN
	SELECT IdCommand, IdWine,Quantity,IdCommandWine
	FROM CommandWine
	WHERE IdCommand = @IdCommand
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllWine]    Script Date: 02-02-21 14:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllWine]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT IdWine,WineName,[Description],[Year], IdProvider,[Disabled]
	FROM Wine
	WHERE [Disabled] = 0
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllWineTypeCategory]    Script Date: 02-02-21 14:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllWineTypeCategory]
	@idWine INT,
	@idTag INT
AS
BEGIN
	SELECT Category.IdCategory, CategoryName, IdTag
	FROM Category
	JOIN WineCategory ON Category.IdCategory = WineCategory.IdCategory
	WHERE WineCategory.IdWine = @idWine AND Category.IdTag = @idTag
END
GO
/****** Object:  StoredProcedure [dbo].[GetCities]    Script Date: 02-02-21 14:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetCities]
	
AS
BEGIN
	SET NOCOUNT ON;

	SELECT IdCity, Country, PostalCode, CityName
	FROM City
END
GO
/****** Object:  StoredProcedure [dbo].[GetCitiesByCountryName]    Script Date: 02-02-21 14:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetCitiesByCountryName]
	@name NVARCHAR(50)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT CityName
	FROM City
	WHERE Country = @name
END
GO
/****** Object:  StoredProcedure [dbo].[GetCitiesById]    Script Date: 02-02-21 14:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetCitiesById]
	@Id INT
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT IdCity,PostalCode,Country,CityName
	FROM City
	WHERE IdCity = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[GetCityIdByValues]    Script Date: 02-02-21 14:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetCityIdByValues]
@country NVARCHAR(50),
@cp NVARCHAR(50),
@city NVARCHAR(50)
AS
BEGIN
	SELECT IdCity
	FROM City
	WHERE Country = @country AND PostalCode = @cp AND CityName = @city
END
GO
/****** Object:  StoredProcedure [dbo].[GetClientByMailAndPasswordMatch]    Script Date: 02-02-21 14:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetClientByMailAndPasswordMatch]
	@email NVARCHAR(50),
	@password NVARCHAR(MAX)
AS
BEGIN
    -- Insert statements for procedure here
	SELECT IdClient,Firstname, Lastname,  EmailAddress, PhoneNumber,BirthDate, Active, IdRole, Salt
	FROM Client
	WHERE Active = 1 AND [password] = HASHBYTES('SHA2_512',Salt + @password) AND EmailAddress = @email

END
GO
/****** Object:  StoredProcedure [dbo].[GetCommandByIdCommand]    Script Date: 02-02-21 14:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetCommandByIdCommand]
	@IdCommand INT
AS
BEGIN
	SELECT IdClient,IdCommand,DateOfCommand,IdClientAddress
	FROM Command
	WHERE IdCommand = @IdCommand
END
GO
/****** Object:  StoredProcedure [dbo].[GetCommentByIdWine]    Script Date: 02-02-21 14:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetCommentByIdWine]
	@IdWine INT
AS
BEGIN
	SELECT IdComment,Comment,Note,IdClient,IdWine
	FROM Comment
	WHERE IdWine = @IdWine
END
GO
/****** Object:  StoredProcedure [dbo].[GetCountries]    Script Date: 02-02-21 14:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetCountries]
AS
BEGIN

    -- Insert statements for procedure here
	SELECT DISTINCT Country
	FROM City
END
GO
/****** Object:  StoredProcedure [dbo].[GetCPByCityName]    Script Date: 02-02-21 14:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetCPByCityName]
	@name NVARCHAR(50)
AS
BEGIN

	SELECT PostalCode
	FROM City
	WHERE CityName = @name
END
GO
/****** Object:  StoredProcedure [dbo].[GetProviderByMailAndPasswordMatch]    Script Date: 02-02-21 14:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetProviderByMailAndPasswordMatch]
	@email NVARCHAR(50),
	@password NVARCHAR(MAX)
AS
BEGIN
	SELECT IdProvider,ProviderName, [Description],  EmailAddress, PhoneNumber, Salt
		FROM [Provider]
		WHERE [password] = HASHBYTES('SHA2_512',Salt + @password) AND EmailAddress = @email
END
GO
/****** Object:  StoredProcedure [dbo].[GetRoleById]    Script Date: 02-02-21 14:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetRoleById]
	@Id INT
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT IdRole,RoleName
	FROM [Role]
	WHERE IdRole = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[GetWineById]    Script Date: 02-02-21 14:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetWineById]
	@id INT
AS
BEGIN
	SELECT IdWine,WineName,[Description],[Year], IdProvider, [Disabled]
		FROM Wine
		WHERE [Disabled] = 0 AND IdWine = @id
END
GO
/****** Object:  StoredProcedure [dbo].[GetWineByProviderId]    Script Date: 02-02-21 14:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetWineByProviderId]
	@IdProvider INT
AS
BEGIN
SELECT IdWine,WineName,[Description],[Year], IdProvider,[Disabled]
	FROM Wine
	WHERE IdProvider = @IdProvider
END
GO
/****** Object:  StoredProcedure [dbo].[GetWinePrices]    Script Date: 02-02-21 14:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetWinePrices]
	@IdWine INT
AS
BEGIN
	SELECT Price, DateOfPrice
	FROM Price
	WHERE IdWine = @IdWine
END
GO
/****** Object:  StoredProcedure [dbo].[InsertCommand]    Script Date: 02-02-21 14:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertCommand]
	@DateCommand DATE,
	@IdClient INT,
	@IdAddressBilling INT
AS
BEGIN
	
	INSERT INTO Command(IdClient,IdClientAddress,DateOfCommand)
	OUTPUT inserted.IdCommand
	VALUES (@IdClient,(SELECT IdClientAddress FROM ClientAddress WHERE IdAddress = @IdAddressBilling AND IdClient = @IdClient), @DateCommand)
END
GO
/****** Object:  StoredProcedure [dbo].[InsertCommandWine]    Script Date: 02-02-21 14:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertCommandWine]
	@IdCommand INT,
	@IdWine INT,
	@Quantity INT
AS
BEGIN
	INSERT INTO CommandWine(IdCommand,IdWine,Quantity)
	VALUES (@IdCommand,@IdWine,@Quantity)
END
GO
/****** Object:  StoredProcedure [dbo].[InsertNewCategoryForWine]    Script Date: 02-02-21 14:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertNewCategoryForWine]
	@IdWine INT,
	@IdCategory INT
AS
BEGIN
	INSERT INTO WineCategory(IdCategory,IdWine)
	VALUES (@IdCategory,@IdWine)
END
GO
/****** Object:  StoredProcedure [dbo].[InsertNewComment]    Script Date: 02-02-21 14:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertNewComment] 
	@IdClient INT,
	@Note TINYINT,
	@IdWine INT,
	@Comment TEXT
AS
BEGIN
	INSERT INTO Comment(IdClient,Note,IdWine,Comment)
	VALUES (@IdClient,@Note,@IdWine,@Comment)
END
GO
/****** Object:  StoredProcedure [dbo].[InsertNewProvider]    Script Date: 02-02-21 14:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertNewProvider]
	@providerName NVARCHAR(50), 
	@description NVARCHAR(500),
    @password NVARCHAR(50),
    @emailAddress NVARCHAR(50),
	@phoneNumber NVARCHAR(50)
AS
BEGIN

	DECLARE @salt NVARCHAR(8)
	Set @salt = (SUBSTRING(CONVERT(NVARCHAR,RAND()),3,8));
	INSERT INTO [dbo].[Provider]
			   ([ProviderName]
			   ,[Description]
			   ,[Password]
			   ,[Salt]
			   ,[EmailAddress]
			   ,[PhoneNumber])
		 VALUES
			   (@providerName,@description,  HASHBYTES('SHA2_512',@salt + @password), @salt,@emailAddress,@phoneNumber)
END
GO
/****** Object:  StoredProcedure [dbo].[InsertNewWine]    Script Date: 02-02-21 14:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertNewWine] 
@WineName NVARCHAR(50),
@Description TEXT,
@Year INT,
@IdProvider INT
AS
BEGIN
INSERT INTO [dbo].[Wine]
           ([WineName]
           ,[Description]
           ,[Year]
           ,[Disabled]
           ,[IdProvider])
		   OUTPUT inserted.IdWine
     VALUES
           (@WineName, @Description, @Year,0,@IdProvider)
END
GO
/****** Object:  StoredProcedure [dbo].[InsertNewWinePrice]    Script Date: 02-02-21 14:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertNewWinePrice]
	@Price DECIMAL,
	@IdWine INT
AS
BEGIN
	INSERT INTO Price(Price,DateOfPrice,IdWine)
	VALUES (@Price,GETDATE(),@IdWine)
END
GO
/****** Object:  StoredProcedure [dbo].[InsertProvider]    Script Date: 02-02-21 14:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertProvider]
	@ProviderName NVARCHAR(50),
	@Email NVARCHAR(50),
	@Password NVARCHAR(MAX),
	@Description TEXT,
	@PhoneNumber NVARCHAR(50)
AS
BEGIN		
	DECLARE @salt NVARCHAR(8)
	Set @salt = (SUBSTRING(CONVERT(NVARCHAR,RAND()),3,8));
	
	INSERT INTO Provider (ProviderName,[Description],PhoneNumber,EmailAddress,[Password], Salt)
	OUTPUT inserted.IdProvider
	VALUES (@ProviderName,@Description,@PhoneNumber,@Email, HASHBYTES('SHA2_512',@salt + @Password), @salt)
END
GO
/****** Object:  StoredProcedure [dbo].[InsertWineCategory]    Script Date: 02-02-21 14:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertWineCategory] 
	@IdWine INT,
	@IdCategory INT
AS
BEGIN
	INSERT INTO WineCategory(IdWine, IdCategory)
	VALUES(@IdWine,@IdCategory)
END
GO
/****** Object:  StoredProcedure [dbo].[RegisterClient]    Script Date: 02-02-21 14:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RegisterClient]
@Email NVARCHAR(50),
@Password NVARCHAR(50)
AS
BEGIN
	DECLARE @salt NVARCHAR(8)
	Set @salt = (SUBSTRING(CONVERT(NVARCHAR,RAND()),3,8));
	
	INSERT INTO Client (EmailAddress,[Password], Salt, IdRole,Active)
	OUTPUT inserted.IdClient
	VALUES (@Email, HASHBYTES('SHA2_512',@salt + @Password), @salt, 3, 1)
END
GO
/****** Object:  StoredProcedure [dbo].[SelectAllClient]    Script Date: 02-02-21 14:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectAllClient]
AS
BEGIN
    SELECT IdClient,Firstname, Lastname,  EmailAddress, PhoneNumber,BirthDate, Active
	FROM Client
	WHERE Active = 1
END
GO
/****** Object:  StoredProcedure [dbo].[SelectClientById]    Script Date: 02-02-21 14:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectClientById]
@Id INT
AS
BEGIN
    SELECT IdClient,Firstname, Lastname,  EmailAddress, PhoneNumber,BirthDate, Active, IdRole
	FROM Client
	WHERE Active = 1 AND IdClient = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateAddress]    Script Date: 02-02-21 14:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateAddress]
	@IdAddress INT,
	@IdCity int,
	@Number NVARCHAR(50),
	@Street NVARCHAR(50)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE [Address]
	SET IdCity = @IdCity, Number = @Number, Street = @Street
	FROM [Address]
	WHERE [Address].IdAddress = @IdAddress
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateClient]    Script Date: 02-02-21 14:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateClient]
	@IdUser INT,
	@fn NVARCHAR(50),
	@ln NVARCHAR(50),
	@EmailAddress NVARCHAR(50),
	@Password NVARCHAR(MAX),
	@PhoneNumber NVARCHAR(20),
	@BirthDate Date
AS
BEGIN
	SET NOCOUNT ON;
	
	DECLARE @salt NVARCHAR(8)
	Set @salt = (SUBSTRING(CONVERT(NVARCHAR,RAND()),3,8));

	UPDATE Client
	SET BirthDate = @BirthDate, EmailAddress = @EmailAddress, Firstname = @fn, Lastname = @ln, [Password] = HASHBYTES('SHA2_512',@salt + @Password), PhoneNumber = @PhoneNumber, Salt = @salt
	FROM Client
	WHERE Client.IdClient = @IdUser
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateClientWithoutPassword]    Script Date: 02-02-21 14:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateClientWithoutPassword]
	@IdUser INT,
	@fn NVARCHAR(50),
	@ln NVARCHAR(50),
	@EmailAddress NVARCHAR(50),
	@PhoneNumber NVARCHAR(20),
	@BirthDate Date
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE Client
	SET BirthDate = @BirthDate, EmailAddress = @EmailAddress, Firstname = @fn, Lastname = @ln, PhoneNumber = @PhoneNumber
	FROM Client
	WHERE Client.IdClient = @IdUser
END
GO
USE [master]
GO
ALTER DATABASE [WineSellingProject] SET  READ_WRITE 
GO
