create table [provider] (
  [id] int IDENTITY(1,1) NOT NULL ,
  [name] varchar(200)  NOT NULL ,
  [address] varchar(500)  NULL ,
  [phone1] varchar(20)  NULL ,
  [phone2] varchar(20)  NULL ,
  [email] varchar(50)  NULL ,
  [active] bit  NOT NULL DEFAULT ((1)),
  [deleted] bit  NOT NULL DEFAULT ((0)),
  [createDate] datetime  NOT NULL DEFAULT (getdate()),
  [updateDate] datetime  NULL ,
  [deletedDate] datetime  NULL ,
  PRIMARY KEY (
   [id]
  )
)
