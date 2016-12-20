create table [detailSaleDetailPurchase] (
  [id] int IDENTITY(1,1) NOT NULL ,
  [idDetailSale] int  NOT NULL ,
  [idDetailPurchase] int  NOT NULL ,
  PRIMARY KEY (
   [id]
  )
)
