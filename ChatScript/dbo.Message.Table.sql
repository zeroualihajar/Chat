USE [Chat]
GO
/****** Object:  Table [dbo].[Message]    Script Date: 05/07/2021 06:45:42 ******/
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
ALTER TABLE [dbo].[Message]  WITH CHECK ADD  CONSTRAINT [FK_Message_Participant] FOREIGN KEY([idparticipant])
REFERENCES [dbo].[participant] ([idparticipant])
GO
ALTER TABLE [dbo].[Message] CHECK CONSTRAINT [FK_Message_Participant]
GO
