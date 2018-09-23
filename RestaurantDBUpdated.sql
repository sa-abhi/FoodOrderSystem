USE [RestaurantDB]
GO

/****** Object:  Table [dbo].[OrderInfo]    Script Date: 3/6/2018 8:34:38 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[OrderInfo](
	[OrderID] [int] IDENTITY(100,1) NOT NULL,
	[Date] [date]  NOT NULL,
	[Cust_ID] [int] NOT NULL,
	[Item_ID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Unit_Price] [int] NOT NULL,
	[Bill] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[OrderInfo]  WITH CHECK ADD FOREIGN KEY([Cust_ID])
REFERENCES [dbo].[CustomerInfo] ([CustomerID])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[OrderInfo]  WITH CHECK ADD FOREIGN KEY([Item_ID])
REFERENCES [dbo].[ItemInfo] ([ItemID])
ON DELETE CASCADE
GO


drop table OrderInfo