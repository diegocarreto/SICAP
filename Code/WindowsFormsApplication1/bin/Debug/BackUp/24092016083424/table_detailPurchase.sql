create table [detailPurchase] (
  [id] int IDENTITY(1,1) NOT NULL ,
  [idPurchase] int  NOT NULL ,
  [idPM] int  NOT NULL ,
  [amount] float  NOT NULL ,
  [unitary] money  NOT NULL ,
  [price] money  NOT NULL ,
  [soldout] bit  NOT NULL DEFAULT ((0)),
  PRIMARY KEY (
   [idPurchase],
   [idPM]
  )
)
