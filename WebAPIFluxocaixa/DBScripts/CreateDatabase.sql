USE [master]
GO

/********* Create database first*************/
CREATE DATABASE [webapifluxocaixa]
GO

USE [webapifluxocaixa]
GO

/****** Object:  Table [dbo].[ServerData]    Script Date: 9/21/2014 7:06:40 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Lancamentos](
	[IdLancamento] [int] IDENTITY(1,1) NOT NULL,
	[DataLancamento] [date] NULL,
	[TipoLancamento] [nvarchar](1) NULL,
	[ValorLancamento] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdLancamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Lancamentos] ADD  CONSTRAINT [DF_lancamentos_DataLancamento] DEFAULT (getdate()) FOR [DataLancamento]
GO

ALTER TABLE [dbo].[Lancamentos] ADD  CONSTRAINT [DF_lancamentos_TipoLancamento] DEFAULT (('E')) FOR [TipoLancamento]
GO

ALTER TABLE [dbo].[Lancamentos] ADD  CONSTRAINT [DF_lancamentos_ValorLancamento]  DEFAULT ((0)) FOR [ValorLancamento]
GO

INSERT INTO webapifluxocaixa.dbo.Lancamentos
(DataLancamento, TipoLancamento, ValorLancamento)
VALUES(getdate()-1, N'E', 125.0);
GO
INSERT INTO webapifluxocaixa.dbo.Lancamentos
(DataLancamento, TipoLancamento, ValorLancamento)
VALUES(getdate()-1, N'E', 225.0);
GO
INSERT INTO webapifluxocaixa.dbo.Lancamentos
(DataLancamento, TipoLancamento, ValorLancamento)
VALUES(getdate()-1, N'E', 325.0);
GO
INSERT INTO webapifluxocaixa.dbo.Lancamentos
(DataLancamento, TipoLancamento, ValorLancamento)
VALUES(getdate()-1, N'S', 425.0);
GO
INSERT INTO webapifluxocaixa.dbo.Lancamentos
( DataLancamento, TipoLancamento, ValorLancamento)
VALUES(getdate()-1, N'S', 25.0);
GO
INSERT INTO webapifluxocaixa.dbo.Lancamentos
(DataLancamento, TipoLancamento, ValorLancamento)
VALUES(getdate()-1, N'S', 99.0);
GO
INSERT INTO webapifluxocaixa.dbo.Lancamentos
(DataLancamento, TipoLancamento, ValorLancamento)
VALUES(getdate(), N'E', 125.0);
GO
INSERT INTO webapifluxocaixa.dbo.Lancamentos
(DataLancamento, TipoLancamento, ValorLancamento)
VALUES(getdate(), N'E', 225.0);
GO
INSERT INTO webapifluxocaixa.dbo.Lancamentos
(DataLancamento, TipoLancamento, ValorLancamento)
VALUES(getdate(), N'E', 325.0);
GO
INSERT INTO webapifluxocaixa.dbo.Lancamentos
(DataLancamento, TipoLancamento, ValorLancamento)
VALUES(getdate(), N'S', 425.0);
GO
INSERT INTO webapifluxocaixa.dbo.Lancamentos
( DataLancamento, TipoLancamento, ValorLancamento)
VALUES(getdate(), N'S', 25.0);
GO
INSERT INTO webapifluxocaixa.dbo.Lancamentos
(DataLancamento, TipoLancamento, ValorLancamento)
VALUES(getdate(), N'S', 99.0);
GO

INSERT INTO webapifluxocaixa.dbo.Lancamentos
(DataLancamento, TipoLancamento, ValorLancamento)
VALUES(getdate()+1, N'E', 125.0);
GO
INSERT INTO webapifluxocaixa.dbo.Lancamentos
(DataLancamento, TipoLancamento, ValorLancamento)
VALUES(getdate()+1, N'E', 225.0);
GO
INSERT INTO webapifluxocaixa.dbo.Lancamentos
(DataLancamento, TipoLancamento, ValorLancamento)
VALUES(getdate()+1, N'E', 325.0);
GO
INSERT INTO webapifluxocaixa.dbo.Lancamentos
(DataLancamento, TipoLancamento, ValorLancamento)
VALUES(getdate()+1, N'S', 425.0);
GO
INSERT INTO webapifluxocaixa.dbo.Lancamentos
( DataLancamento, TipoLancamento, ValorLancamento)
VALUES(getdate()+1, N'S', 25.0);
GO
INSERT INTO webapifluxocaixa.dbo.Lancamentos
(DataLancamento, TipoLancamento, ValorLancamento)
VALUES(getdate()+1, N'S', 99.0);
GO

