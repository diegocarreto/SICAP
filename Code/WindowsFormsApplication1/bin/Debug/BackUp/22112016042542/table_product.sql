create table [product] (
  [id] int IDENTITY(1,1) NOT NULL ,
  [idGroup] int  NOT NULL ,
  [idLabel] int  NOT NULL ,
  [idMaterial] int  NULL ,
  [pathImage] varchar(500)  NULL ,
  [active] bit  NOT NULL DEFAULT ((1)),
  [deleted] bit  NOT NULL DEFAULT ((0)),
  [createDate] datetime  NOT NULL DEFAULT (getdate()),
  [updateDate] datetime  NULL ,
  [deleteDate] datetime  NULL ,
  PRIMARY KEY (
   [id]
  )
)
