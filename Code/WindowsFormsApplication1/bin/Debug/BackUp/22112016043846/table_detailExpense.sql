create table [detailExpense] (
  [id] int IDENTITY(1,1) NOT NULL ,
  [idExpense] int  NOT NULL ,
  [amount] money  NOT NULL ,
  [deleted] bit  NOT NULL DEFAULT ((0)),
  [date] datetime  NOT NULL ,
  [createDate] datetime  NOT NULL DEFAULT (getdate()),
  [updateDate] datetime  NULL ,
  [deletedDate] datetime  NULL ,
  [name] varchar(100)  NULL ,
  PRIMARY KEY (
   [id]
  )
)
