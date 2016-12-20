create table [price] (
  [id] int IDENTITY(1,1) NOT NULL ,
  [idPM] int  NOT NULL ,
  [price] money  NOT NULL ,
  [deleted] bit  NOT NULL DEFAULT ((0)),
  [createDate] datetime  NOT NULL DEFAULT (getdate()),
  [deleteDate] datetime  NULL ,
  PRIMARY KEY (
   [id]
  )
)
