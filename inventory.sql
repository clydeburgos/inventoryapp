USE [Inventory]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 02/02/2020 2:15:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](150) NULL,
	[CategoryId] [int] NULL,
	[Description] [nvarchar](550) NULL,
	[Price] [decimal](18, 2) NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([Id], [Name], [CategoryId], [Description], [Price]) VALUES (1, N'Microsoft Surface Laptop 3', 1, N'Best laptop for Microsoft Stack Development', CAST(2000.00 AS Decimal(18, 2)))
INSERT [dbo].[Product] ([Id], [Name], [CategoryId], [Description], [Price]) VALUES (2, N'Hammer', 2, N'Aluminum, Black Rubber handle', CAST(150.00 AS Decimal(18, 2)))
INSERT [dbo].[Product] ([Id], [Name], [CategoryId], [Description], [Price]) VALUES (3, N'Hawaiian Pizza 12 inches', 4, N'Fucking pizza with Pineapples', CAST(50.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Product] OFF
