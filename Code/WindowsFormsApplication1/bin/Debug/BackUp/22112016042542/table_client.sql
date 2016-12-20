create table [client] (
  [id] int IDENTITY(1,1) NOT NULL ,
  [name] varchar(150)  NOT NULL ,
  [phone1] varchar(10)  NOT NULL ,
  [phone2] varchar(10)  NULL ,
  [street] varchar(250)  NOT NULL ,
  [number1] varchar(10)  NULL ,
  [number2] varchar(10)  NULL ,
  [colony] varchar(30)  NOT NULL ,
  [municipality] varchar(30)  NOT NULL ,
  [state] varchar(30)  NOT NULL ,
  [zip] varchar(6)  NULL ,
  [others] varchar(2000)  NULL ,
  [active] bit  NOT NULL DEFAULT ((1)),
  [deleted] bit  NOT NULL DEFAULT ((0)),
  [createDate] datetime  NOT NULL DEFAULT (getdate()),
  [updateDate] datetime  NULL ,
  [deletedDate] datetime  NULL ,
  PRIMARY KEY (
   [id]
  )
)
