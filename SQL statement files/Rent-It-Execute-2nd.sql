use RentIt_DB;

/* Items_on_rent references Items_Master */

CREATE TABLE [dbo].[Items_on_rent](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[i_code] [varchar](15) NOT NULL,
	[i_qty] [int] NOT NULL,
	[i_rte] [int] NOT NULL,
	[i_dur] [int] NOT NULL,
	[i_req_dte] [date] NOT NULL,
	[i_ret_dte] [date] NOT NULL,
	[i_Cst_con] [numeric](10, 0) NOT NULL,
	[i_bill_id] [int] NOT NULL,
	[i_returned] [numeric](1, 0) NOT NULL,
 CONSTRAINT [PK_Items_avail] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY];

ALTER TABLE [dbo].[Items_on_rent]  WITH CHECK ADD  CONSTRAINT [FK_Items_avail_Items_master] FOREIGN KEY([i_code])
REFERENCES [dbo].[Items_master] ([i_code])
GO

ALTER TABLE [dbo].[Items_on_rent] CHECK CONSTRAINT [FK_Items_avail_Items_master]
GO

ALTER TABLE [dbo].[Items_on_rent]  WITH CHECK ADD  CONSTRAINT [FK_Items_on_rent_Bill_Master] FOREIGN KEY([i_bill_id])
REFERENCES [dbo].[Bill_Master] ([b_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Items_on_rent] CHECK CONSTRAINT [FK_Items_on_rent_Bill_Master]
GO

ALTER TABLE [dbo].[Items_on_rent]  WITH CHECK ADD  CONSTRAINT [FK_Items_on_rent_Items_on_rent] FOREIGN KEY([id])
REFERENCES [dbo].[Items_on_rent] ([id])
GO

ALTER TABLE [dbo].[Items_on_rent] CHECK CONSTRAINT [FK_Items_on_rent_Items_on_rent]
GO

/* Purchase_Master references Vendor_Master */

CREATE TABLE [dbo].[Purchase_Master](
	[p_invno] [numeric](10, 0) NOT NULL,
	[p_vendor_contact] [numeric](10, 0) NOT NULL,
	[p_dte] [date] NOT NULL,
	[p_summary] [text] NOT NULL,
	[p_qty] [int] NOT NULL,
	[p_SubTot] [int] NOT NULL,
	[p_GST] [int] NOT NULL,
	[p_gTot] [int] NOT NULL,
	[p_pay_mode] [varchar](6) NOT NULL,
 CONSTRAINT [PK_purchase_Master_1] PRIMARY KEY CLUSTERED 
(
	[p_invno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Purchase_Master]  WITH CHECK ADD  CONSTRAINT [FK_purchase_Master_Vendor_Master] FOREIGN KEY([p_vendor_contact])
REFERENCES [dbo].[Vendor_Master] ([ven_contact])
GO

ALTER TABLE [dbo].[Purchase_Master] CHECK CONSTRAINT [FK_purchase_Master_Vendor_Master]
GO