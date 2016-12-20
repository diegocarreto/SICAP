create table [loan] (
  [id] int IDENTITY(1,1) NOT NULL ,
  [idEmployee] int  NOT NULL ,
  [amount] money  NOT NULL ,
  [date] date  NOT NULL ,
  [deleted] bit  NOT NULL DEFAULT ((0)),
  [createDate] datetime  NOT NULL DEFAULT (getdate()),
  [updateDate] date  NULL ,
  [deletedDate] date  NULL ,
  [detail] varchar(5000)  NULL ,
  PRIMARY KEY (
   [id]
  )
)
