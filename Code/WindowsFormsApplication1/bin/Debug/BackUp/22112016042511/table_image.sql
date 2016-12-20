create table [image] (
  [id] int IDENTITY(1,1) NOT NULL ,
  [entityId] int  NOT NULL ,
  [entityName] varchar(50)  NOT NULL ,
  [image] image(2147483647)  NOT NULL ,
  [createDate] datetime  NOT NULL DEFAULT (getdate()),
  [updateDate] datetime  NULL DEFAULT (getdate()),
  PRIMARY KEY (
   [id]
  )
)
