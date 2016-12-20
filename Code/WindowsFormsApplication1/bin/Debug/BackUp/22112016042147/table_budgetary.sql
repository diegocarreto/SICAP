create table [budgetary] (
  [id] int IDENTITY(1,1) NOT NULL ,
  [total] money  NOT NULL ,
  [clientName] varchar(200)  NULL ,
  [deleted] bit  NOT NULL DEFAULT ((0)),
  [createDate] datetime  NOT NULL DEFAULT (getdate()),
  [deletedDate] datetime  NULL ,
  PRIMARY KEY (
   [id]
  )
)
