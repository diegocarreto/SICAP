create table [pm] (
  [id] int IDENTITY(1,1) NOT NULL ,
  [idProduct] int  NOT NULL ,
  [idMeasure] int  NULL ,
  [idMeasure2] int  NULL ,
  [amountMeasure2] float  NULL DEFAULT ((0)),
  [idBrand] int  NULL ,
  [barcode] varchar(50)  NULL ,
  [active] bit  NOT NULL DEFAULT ((1)),
  [deleted] bit  NOT NULL DEFAULT ((0)),
  [createDate] datetime  NOT NULL DEFAULT (getdate()),
  [deletedDate] datetime  NULL ,
  [codeVendor] varchar(50)  NULL ,
  [freight] bit  NULL ,
  [idLocation] int  NULL ,
  [name] varchar(50)  NULL ,
  [max] int  NULL DEFAULT ((0)),
  [min] int  NULL DEFAULT ((0)),
  [idProvider] int  NULL ,
  [idCompany] int  NULL ,
  PRIMARY KEY (
   [id]
  )
)
