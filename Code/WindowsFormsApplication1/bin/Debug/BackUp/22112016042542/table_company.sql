create table [company] (
  [id] int IDENTITY(1,1) NOT NULL ,
  [name] varchar(150)  NOT NULL ,
  [phone1] varchar(10)  NOT NULL ,
  [phone2] varchar(10)  NULL ,
  [address] varchar(500)  NOT NULL ,
  [ShopName] varchar(150)  NOT NULL ,
  [TicketAddress1] varchar(100)  NOT NULL ,
  [TicketAddress2] varchar(100)  NOT NULL ,
  [TicketPhoneNumber] varchar(15)  NOT NULL ,
  [principal] bit  NOT NULL DEFAULT ((0)),
  [deleted] bit  NOT NULL DEFAULT ((0)),
  [createDate] datetime  NOT NULL DEFAULT (getdate()),
  [updateDate] datetime  NULL ,
  [deletedDate] datetime  NULL ,
  PRIMARY KEY (
   [id]
  )
)
