use RentIt_DB;

/* Items_Stock_Update_Decrement Trigger on Items_on_rent */

CREATE TRIGGER [dbo].[Items_Stock_Update_Decrement]
   ON  [dbo].[Items_on_rent]
   AFTER INSERT
AS 
BEGIN
	Update Items_master set i_in_stk = i_in_stk - (Select inserted.i_qty from inserted) where
	i_code = (Select inserted.i_code from inserted)
END
GO

ALTER TABLE [dbo].[Items_on_rent] ENABLE TRIGGER [Items_Stock_Update_Decrement]
GO

/* Items_Stock_Update_Increment Trigger on Items_on_rent */

CREATE TRIGGER [dbo].[Items_Stock_Update_Increment]
   ON  [dbo].[Items_on_rent]
   AFTER Update
AS 
BEGIN
	/* UPDATE(colname) returns whether the value of the column specified changed or not */
	If UPDATE(i_returned)
	BEGIN
		Update Items_master set i_in_stk = i_in_stk + (Select inserted.i_qty from inserted) where
		i_code = (Select inserted.i_code from inserted)
	END
END
GO

ALTER TABLE [dbo].[Items_on_rent] ENABLE TRIGGER [Items_Stock_Update_Increment]
GO

/* Purchase_Details references Purchase_Master */
CREATE TABLE [dbo].[Purchase_Details](
	[pur_id] [int] IDENTITY(1,1) NOT NULL,
	[pur_inv_no] [numeric](10, 0) NOT NULL,
	[pur_it_Code] [varchar](20) NOT NULL,
	[pur_it_qty] [int] NOT NULL,
	[pur_pc_Cst] [numeric](10, 0) NOT NULL,
 CONSTRAINT [PK_Purchase_Details] PRIMARY KEY CLUSTERED 
(
	[pur_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Purchase_Details]  WITH CHECK ADD  CONSTRAINT [FK_Purchase_Details_purchase_Master] FOREIGN KEY([pur_inv_no])
REFERENCES [dbo].[Purchase_Master] ([p_invno])
GO

ALTER TABLE [dbo].[Purchase_Details] CHECK CONSTRAINT [FK_Purchase_Details_purchase_Master]
GO
