create table [paymentSale] (
  [id] int IDENTITY(1,1) NOT NULL ,
  [idSale] int  NOT NULL ,
  [type] varchar(30)  NOT NULL ,
  [amount] money  NOT NULL ,
  [cash] money  NOT NULL ,
  [change] money  NOT NULL ,
  [description] varchar(5000)  NULL ,
  [deleted] bit  NOT NULL DEFAULT ((0)),
  [date] date  NOT NULL ,
  [createDate] datetime  NOT NULL DEFAULT (getdate()),
  [updateDate] datetime  NULL ,
  [deletedDate] datetime  NULL ,
  PRIMARY KEY (
   [id]
  )
)
