USE [master]
GO
IF EXISTS (SELECT [name] FROM [master].[sys].[databases] WHERE [name] = N'BookStore')
    DROP DATABASE [BookStore]
GO
CREATE DATABASE [BookStore]
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BookStore].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BookStore] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BookStore] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BookStore] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BookStore] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BookStore] SET ARITHABORT OFF 
GO
ALTER DATABASE [BookStore] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BookStore] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BookStore] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BookStore] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BookStore] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BookStore] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BookStore] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BookStore] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BookStore] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BookStore] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BookStore] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BookStore] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BookStore] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BookStore] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BookStore] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BookStore] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BookStore] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BookStore] SET RECOVERY FULL 
GO
ALTER DATABASE [BookStore] SET  MULTI_USER 
GO
ALTER DATABASE [BookStore] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BookStore] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BookStore] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BookStore] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [BookStore] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'BookStore', N'ON'
GO
USE [BookStore]
GO
/****** Object:  User [AZUREAD\gustavocastillo]    Script Date: 1/10/2019 4:42:08 p. m. ******/
CREATE USER [AZUREAD\gustavocastillo] FOR LOGIN [AZUREAD\gustavocastillo] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Book]    Script Date: 1/10/2019 4:42:08 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Book](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NULL,
	[Description] [varchar](510) NULL,
	[Created] [datetime] NULL,
	[Category] [int] NULL,
 CONSTRAINT [PK_Book] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Category]    Script Date: 1/10/2019 4:42:08 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NULL,
	[Description] [varchar](510) NULL,
	[Created] [datetime] NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Review]    Script Date: 1/10/2019 4:42:08 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Review](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Comment] [varchar](510) NULL,
	[IdLibro] [int] NULL,
	[votes] [int] NULL,
 CONSTRAINT [PK_Review] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Book] ON 

INSERT [dbo].[Book] ([Id], [Name], [Description], [Created], [Category]) VALUES (1, N'Principito', N'Cuento', CAST(N'2019-09-05 00:00:00.000' AS DateTime), 4)
INSERT [dbo].[Book] ([Id], [Name], [Description], [Created], [Category]) VALUES (4, N'sd', N'sd', CAST(N'2019-08-04 01:00:00.000' AS DateTime), 4)
INSERT [dbo].[Book] ([Id], [Name], [Description], [Created], [Category]) VALUES (5, N'Harry', N'Ficcion', CAST(N'2019-09-17 01:00:00.000' AS DateTime), 4)
SET IDENTITY_INSERT [dbo].[Book] OFF
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([Id], [Name], [Description], [Created]) VALUES (4, N'Ficcion', N'Literiatura de ficcion', NULL)
SET IDENTITY_INSERT [dbo].[Category] OFF
SET IDENTITY_INSERT [dbo].[Review] ON 

INSERT [dbo].[Review] ([Id], [Comment], [IdLibro], [votes]) VALUES (1, N'asda', 1, 2)
INSERT [dbo].[Review] ([Id], [Comment], [IdLibro], [votes]) VALUES (2, N'sds', 1, 3)
INSERT [dbo].[Review] ([Id], [Comment], [IdLibro], [votes]) VALUES (4, N'bgerer', 1, 2)
INSERT [dbo].[Review] ([Id], [Comment], [IdLibro], [votes]) VALUES (5, N'svr', 4, 5)
INSERT [dbo].[Review] ([Id], [Comment], [IdLibro], [votes]) VALUES (6, N'sad', 5, 3)
INSERT [dbo].[Review] ([Id], [Comment], [IdLibro], [votes]) VALUES (7, N'fsdf', 5, 5)
INSERT [dbo].[Review] ([Id], [Comment], [IdLibro], [votes]) VALUES (8, N'dgfgd', 5, 3)
SET IDENTITY_INSERT [dbo].[Review] OFF
ALTER TABLE [dbo].[Book]  WITH CHECK ADD  CONSTRAINT [FK_Book_Category] FOREIGN KEY([Category])
REFERENCES [dbo].[Category] ([Id])
GO
ALTER TABLE [dbo].[Book] CHECK CONSTRAINT [FK_Book_Category]
GO
ALTER TABLE [dbo].[Review]  WITH CHECK ADD  CONSTRAINT [FK_Review_Book] FOREIGN KEY([IdLibro])
REFERENCES [dbo].[Book] ([Id])
GO
ALTER TABLE [dbo].[Review] CHECK CONSTRAINT [FK_Review_Book]
GO
/****** Object:  StoredProcedure [dbo].[MostPopular]    Script Date: 1/10/2019 4:42:08 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[MostPopular] 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select Distinct b.name ,b.description,b.category, SUM(r.votes) as votes from Book b
inner join Review r on b.id = r.idLibro 
group by b.id,b.name ,b.description,b.category

END

GO
USE [master]
GO
ALTER DATABASE [BookStore] SET  READ_WRITE 
GO
