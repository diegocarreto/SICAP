create table [payment] (
  [id] int IDENTITY(1,1) NOT NULL ,
  [idLoan] int  NOT NULL ,
  [amount] money  NULL ,
  [deleted] bit  NOT NULL DEFAULT ((0)),
  [date] date  NOT NULL ,
  [createDate] datetime  NOT NULL DEFAULT (getdate()),
  [updateDate] datetime  NULL ,
  [deletedDate] datetime  NULL 
)
