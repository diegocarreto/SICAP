create table [employee] (
  [id] int IDENTITY(1,1) NOT NULL ,
  [idCompany] int  NULL ,
  [name] varchar(50)  NOT NULL ,
  [salary] money  NOT NULL ,
  [phone] varchar(50)  NOT NULL ,
  [deleted] bit  NOT NULL DEFAULT ((0)),
  [createDate] datetime  NOT NULL DEFAULT (getdate()),
  [updateDate] datetime  NULL ,
  [deletedDate] datetime  NULL 
)
