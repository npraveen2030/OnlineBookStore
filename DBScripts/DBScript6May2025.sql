USE [OnlineBookStore]
GO
ALTER TABLE [dbo].[Books] DROP CONSTRAINT [FK_Books_BookTypes]
GO
ALTER TABLE [dbo].[Wishlist] DROP CONSTRAINT [DF__Wishlist__AddedO__403A8C7D]
GO
/****** Object:  Table [dbo].[Wishlist]    Script Date: 06-05-2025 23:39:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Wishlist]') AND type in (N'U'))
DROP TABLE [dbo].[Wishlist]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 06-05-2025 23:39:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Users]') AND type in (N'U'))
DROP TABLE [dbo].[Users]
GO
/****** Object:  Table [dbo].[BookTypes]    Script Date: 06-05-2025 23:39:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BookTypes]') AND type in (N'U'))
DROP TABLE [dbo].[BookTypes]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 06-05-2025 23:39:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Books]') AND type in (N'U'))
DROP TABLE [dbo].[Books]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 06-05-2025 23:39:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[bookid] [int] IDENTITY(1,1) NOT NULL,
	[title] [varchar](255) NOT NULL,
	[authorName] [varchar](255) NULL,
	[price] [decimal](6, 2) NULL,
	[stockquantity] [int] NULL,
	[publisheddate] [date] NULL,
	[Isactive] [bit] NULL,
	[TypeId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[bookid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BookTypes]    Script Date: 06-05-2025 23:39:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookTypes](
	[TypeId] [int] IDENTITY(1,1) NOT NULL,
	[TypeName] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 06-05-2025 23:39:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[userid] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[Firstname] [varchar](50) NULL,
	[Lastname] [varchar](50) NULL,
	[Address] [varchar](255) NULL,
	[Phone] [varchar](20) NULL,
	[MailId] [varchar](100) NULL,
	[UserType] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[userid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Wishlist]    Script Date: 06-05-2025 23:39:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Wishlist](
	[WishlistId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[BookId] [int] NOT NULL,
	[AddedOn] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[WishlistId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Wishlist] ADD  DEFAULT (getdate()) FOR [AddedOn]
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_BookTypes] FOREIGN KEY([TypeId])
REFERENCES [dbo].[BookTypes] ([TypeId])
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_BookTypes]
GO
