USE [master]
GO
/****** Object:  Database [Chat]    Script Date: 13/07/2021 23:26:40 ******/
CREATE DATABASE [Chat]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Chat', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Chat.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Chat_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Chat_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Chat] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Chat].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Chat] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Chat] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Chat] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Chat] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Chat] SET ARITHABORT OFF 
GO
ALTER DATABASE [Chat] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Chat] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Chat] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Chat] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Chat] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Chat] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Chat] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Chat] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Chat] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Chat] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Chat] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Chat] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Chat] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Chat] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Chat] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Chat] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Chat] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Chat] SET RECOVERY FULL 
GO
ALTER DATABASE [Chat] SET  MULTI_USER 
GO
ALTER DATABASE [Chat] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Chat] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Chat] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Chat] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Chat] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Chat] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Chat', N'ON'
GO
ALTER DATABASE [Chat] SET QUERY_STORE = OFF
GO
USE [Chat]
GO
/****** Object:  Table [dbo].[Message]    Script Date: 13/07/2021 23:26:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Message](
	[idmessage] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[contenu] [text] NULL,
	[idparticipant] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK_Message] PRIMARY KEY CLUSTERED 
(
	[idmessage] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[participant]    Script Date: 13/07/2021 23:26:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[participant](
	[idparticipant] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[pseudo] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_participant] PRIMARY KEY CLUSTERED 
(
	[idparticipant] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Message]  WITH CHECK ADD  CONSTRAINT [FK_Message_participant] FOREIGN KEY([idparticipant])
REFERENCES [dbo].[participant] ([idparticipant])
GO
ALTER TABLE [dbo].[Message] CHECK CONSTRAINT [FK_Message_participant]
GO
USE [master]
GO
ALTER DATABASE [Chat] SET  READ_WRITE 
GO
