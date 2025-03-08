USE [master]
GO
/****** Object:  Database [dbhamburgueria] ******/
CREATE DATABASE [dbhamburgueria]
GO
USE [dbhamburgueria]
GO
/****** Object:  Table [dbo].[Administrador] ******/
CREATE TABLE [dbo].[Administrador](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](255) NULL,
	[Cpf] [varchar](11) NULL,
	[Login] [varchar](12) NOT NULL,
	[Senha] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Administrador] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Login] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
INSERT INTO [dbo].[Administrador]([Login], [Senha]) VALUES ('admin', 'admin')
GO
/****** Object:  Table [dbo].[ItensPedido] ******/
CREATE TABLE [dbo].[ItensPedido](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdPedido] [int] NOT NULL,
	[IdProduto] [int] NOT NULL,
	[NomeProduto] [varchar](50) NOT NULL,
	[PrecoProduto] [decimal](5, 2) NOT NULL,
 CONSTRAINT [PK_ItensPedido] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pedido] ******/
CREATE TABLE [dbo].[Pedido](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CpfUsuario] [varchar](11) NOT NULL,
	[Total] [decimal](10, 2) NOT NULL,
	[DataPedido] [datetime] NOT NULL,
	[Status] [char](1) NOT NULL,
	[MetPag] [char](1) NULL,
 CONSTRAINT [PK_Pedido] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Produto] ******/
CREATE TABLE [dbo].[Produto](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[Preco] [decimal](5, 2) NOT NULL,
	[Descricao] [varchar](431) NULL,
	[Ingredientes] [varchar](150) NULL,
	[Foto] [image] NULL,
	[Tipo] [char](1) NOT NULL,
 CONSTRAINT [PK_Produto] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
INSERT INTO [dbo].[Produto](Nome,Preco,Tipo) VALUES ('Lanche teste', 9.99, 'L')
INSERT INTO [dbo].[Produto](Nome,Preco,Tipo) VALUES ('Bebida teste', 9.99, 'B')
INSERT INTO [dbo].[Produto](Nome,Preco,Tipo) VALUES ('Acompanhamento teste', 9.99, 'A')
GO
/****** Object:  Table [dbo].[Usuario] ******/
CREATE TABLE [dbo].[Usuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NomeCompleto] [varchar](255) NULL,
	[NomeUsuario] [varchar](12) NULL,
	[Email] [varchar](256) NULL,
	[Cpf] [varchar](11) NOT NULL,
	[Telefone] [varchar](11) NULL,
	[Nascimento] [datetime] NULL,
	[Genero] [char](1) NULL,
	[Endereco] [varchar](150) NULL,
	[Pontos] [int] NULL,
	[Senha] [varchar](50) NULL,
	[Convidado] [bit] NOT NULL,
	[NomeHost] [varchar](15) NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Cpf] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UQConvidado_NomeHost] ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_UQConvidado_NomeHost] ON [dbo].[Usuario]
(
	[NomeHost] ASC
)
WHERE ([Convidado]=(1))
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Pedido] ADD  CONSTRAINT [DF_Pedido_DataPedido]  DEFAULT (sysdatetime()) FOR [DataPedido]
GO
ALTER TABLE [dbo].[Pedido] ADD  CONSTRAINT [DF_Pedido_Status]  DEFAULT ('A') FOR [Status]
GO
ALTER TABLE [dbo].[Produto] ADD  CONSTRAINT [DF_Produto_Tipo]  DEFAULT ('L') FOR [Tipo]
GO
ALTER TABLE [dbo].[Usuario] ADD  CONSTRAINT [DF_Usuario_NomeHost]  DEFAULT (host_name()) FOR [NomeHost]
GO
ALTER TABLE [dbo].[ItensPedido]  WITH CHECK ADD  CONSTRAINT [FK_ItensPedido_Pedido] FOREIGN KEY([IdPedido])
REFERENCES [dbo].[Pedido] ([Id])
GO
ALTER TABLE [dbo].[ItensPedido] CHECK CONSTRAINT [FK_ItensPedido_Pedido]
GO
USE [master]
GO
ALTER DATABASE [dbhamburgueria] SET  READ_WRITE 
GO

/****** Create login Aluno: ******/
USE [master]
GO
CREATE LOGIN [Aluno] WITH PASSWORD='Senac111', DEFAULT_DATABASE=[dbhamburgueria], DEFAULT_LANGUAGE=[Português (Brasil)], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
ALTER LOGIN [Aluno] DISABLE
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [Aluno]
GO
USE [dbhamburgueria]
GO
CREATE USER [Aluno] FOR LOGIN [Aluno] WITH DEFAULT_SCHEMA=[dbo]
GO
