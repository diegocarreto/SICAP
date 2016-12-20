create table [income] (
  [id] int IDENTITY(1,1) NOT NULL ,
  [idCategoryIncome] int  NOT NULL ,
  [name] varchar(100)  NOT NULL ,
  [description] varchar(2000)  NOT NULL ,
  [amount] money  NOT NULL ,
  [deleted] bit  NOT NULL DEFAULT ((0)),
  [createdDate] datetime  NOT NULL DEFAULT (getdate()),
  [deletedDate] datetime  NOT NULL DEFAULT (getdate()),
  [updateDate] datetime  NULL ,
  PRIMARY KEY (
   [id]
  )
)
