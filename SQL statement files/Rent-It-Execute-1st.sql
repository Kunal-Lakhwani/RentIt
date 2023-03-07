use RentIt_DB;

/* Bill_Master */
CREATE TABLE [dbo].[Bill_Master](
	[b_id] [int] IDENTITY(1,1) NOT NULL,
	[biller_nme] [varchar](50) NOT NULL,
	[cst_nme] [varchar](20) NOT NULL,
	[cst_cont] [numeric](10, 0) NOT NULL,
	[b_Itm_Qty] [int] NOT NULL,
	[b_subtot] [int] NOT NULL,
	[b_disc] [int] NOT NULL,
	[b_gTot] [int] NOT NULL,
	[b_Dte] [date] NULL,
	[b_paymode] [varchar](23) NULL,
 CONSTRAINT [PK_Bill_Master] PRIMARY KEY CLUSTERED 
(
	[b_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY];

/* Customer_master */
CREATE TABLE [dbo].[Customer_master](
	[c_id] [int] IDENTITY(1,1) NOT NULL,
	[c_nme] [varchar](20) NOT NULL,
	[c_contact] [numeric](10, 0) NOT NULL,
	[c_opBal] [int] NOT NULL,
	[c_prev_Disc] [numeric](3, 0) NULL,
 CONSTRAINT [PK_Customer_master_1] PRIMARY KEY CLUSTERED 
(
	[c_contact] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY];

/* Items_master */
CREATE TABLE [dbo].[Items_master](
	[i_code] [varchar](15) NOT NULL,
	[i_name] [varchar](50) NOT NULL,
	[i_type] [varchar](50) NOT NULL,
	[i_qty] [numeric](2, 0) NOT NULL,
	[i_in_stk] [numeric](2, 0) NOT NULL,
	[i_rte] [int] NOT NULL,
 CONSTRAINT [PK_Items_master] PRIMARY KEY CLUSTERED 
(
	[i_code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY];

/* Logs_Master */
CREATE TABLE [dbo].[Logs_Master](
	[Log_id] [int] IDENTITY(1,1) NOT NULL,
	[Log_Emp] [varchar](50) NOT NULL,
	[Log_Role] [varchar](50) NOT NULL,
	[Log_action] [varchar](100) NOT NULL,
	[Log_date] [date] NOT NULL,
	[Log_time] [varchar](8) NOT NULL,
 CONSTRAINT [PK_Logs_Master] PRIMARY KEY CLUSTERED 
(
	[Log_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY];

/* Shop_Master */
CREATE TABLE [dbo].[Shop_Master](
	[Shop_Contact] [numeric](10, 0) NOT NULL,
	[Shop_Name] [varchar](20) NOT NULL,
	[Shop_GST_No] [numeric](15, 0) NOT NULL,
	[Shop_Address] [text] NOT NULL,
 CONSTRAINT [PK_Shop_Master] PRIMARY KEY CLUSTERED 
(
	[Shop_Contact] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY];

/* User_Master */
CREATE TABLE [dbo].[user_master](
	[E_mailID] [varchar](50) NOT NULL,
	[E_name] [varchar](50) NOT NULL,
	[E_Pass_wrd] [varchar](12) NOT NULL,
	[E_role] [varchar](50) NOT NULL,
 CONSTRAINT [PK_user_master] PRIMARY KEY CLUSTERED 
(
	[E_mailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY];

/* Vendor_Master */
CREATE TABLE [dbo].[Vendor_Master](
	[ven_nme] [varchar](50) NOT NULL,
	[ven_contact] [numeric](10, 0) NOT NULL,
	[ven_address] [text] NOT NULL,
	[ven_GST_No] [numeric](15, 0) NOT NULL,
 CONSTRAINT [PK_Vendor_Master] PRIMARY KEY CLUSTERED 
(
	[ven_contact] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UK_Ven_GSTNo] UNIQUE NONCLUSTERED 
(
	[ven_GST_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY];