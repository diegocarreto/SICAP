create table [group] (
  [id] int IDENTITY(1,1) NOT NULL ,
  [name] varchar(100)  NOT NULL ,
  [prefix] varchar(10)  NOT NULL ,
  [active] bit  NOT NULL DEFAULT ((1)),
  [deleted] bit  NOT NULL DEFAULT ((0)),
  [createDate] datetime  NOT NULL DEFAULT (getdate()),
  [updateDate] datetime  NULL ,
  [deleteDate] datetime  NULL ,
  PRIMARY KEY (
   [id]
  )
)