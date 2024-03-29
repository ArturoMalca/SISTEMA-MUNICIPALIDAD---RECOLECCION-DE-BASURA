USE [master]
GO
/****** Object:  Database [bd_soft_fran]    Script Date: 15/07/2022 22:04:13 ******/
CREATE DATABASE [bd_soft_fran]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'bd_soft_fran', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\bd_soft_fran.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'bd_soft_fran_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\bd_soft_fran_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [bd_soft_fran] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [bd_soft_fran].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [bd_soft_fran] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [bd_soft_fran] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [bd_soft_fran] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [bd_soft_fran] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [bd_soft_fran] SET ARITHABORT OFF 
GO
ALTER DATABASE [bd_soft_fran] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [bd_soft_fran] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [bd_soft_fran] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [bd_soft_fran] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [bd_soft_fran] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [bd_soft_fran] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [bd_soft_fran] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [bd_soft_fran] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [bd_soft_fran] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [bd_soft_fran] SET  DISABLE_BROKER 
GO
ALTER DATABASE [bd_soft_fran] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [bd_soft_fran] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [bd_soft_fran] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [bd_soft_fran] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [bd_soft_fran] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [bd_soft_fran] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [bd_soft_fran] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [bd_soft_fran] SET RECOVERY FULL 
GO
ALTER DATABASE [bd_soft_fran] SET  MULTI_USER 
GO
ALTER DATABASE [bd_soft_fran] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [bd_soft_fran] SET DB_CHAINING OFF 
GO
ALTER DATABASE [bd_soft_fran] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [bd_soft_fran] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [bd_soft_fran] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [bd_soft_fran] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'bd_soft_fran', N'ON'
GO
ALTER DATABASE [bd_soft_fran] SET QUERY_STORE = OFF
GO
USE [bd_soft_fran]
GO
/****** Object:  Table [dbo].[lugar]    Script Date: 15/07/2022 22:04:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lugar](
	[lug_id] [int] IDENTITY(1,1) NOT NULL,
	[lug_nom] [varchar](120) NOT NULL,
 CONSTRAINT [PK_lugar] PRIMARY KEY CLUSTERED 
(
	[lug_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[recorrido]    Script Date: 15/07/2022 22:04:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[recorrido](
	[rec_id] [int] IDENTITY(1,1) NOT NULL,
	[rec_reg_id] [int] NOT NULL,
	[rec_lug_id] [int] NOT NULL,
 CONSTRAINT [PK_recorrido] PRIMARY KEY CLUSTERED 
(
	[rec_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[v_recorrido]    Script Date: 15/07/2022 22:04:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE view [dbo].[v_recorrido]
as
select rec.rec_id, rec.rec_reg_id,lug.lug_nom  from  recorrido as rec inner join lugar as lug ON rec.rec_lug_id=lug.lug_id
GO
/****** Object:  Table [dbo].[chofer]    Script Date: 15/07/2022 22:04:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chofer](
	[cho_id] [int] IDENTITY(1,1) NOT NULL,
	[cho_nom] [varchar](80) NOT NULL,
	[cho_apel] [varchar](80) NOT NULL,
	[cho_est] [char](1) NOT NULL,
 CONSTRAINT [PK_chofer] PRIMARY KEY CLUSTERED 
(
	[cho_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[v_chofer]    Script Date: 15/07/2022 22:04:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE view [dbo].[v_chofer]
as
select cho.cho_id,cho.cho_nom ,cho.cho_apel, cho.cho_apel+' '+cho.cho_nom as chofer,cho.cho_est  from chofer as cho
GO
/****** Object:  Table [dbo].[patente]    Script Date: 15/07/2022 22:04:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[patente](
	[pat_id] [int] IDENTITY(1,1) NOT NULL,
	[pat_nom] [varchar](80) NOT NULL,
	[pat_est] [char](1) NOT NULL,
 CONSTRAINT [PK_patente] PRIMARY KEY CLUSTERED 
(
	[pat_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[registro]    Script Date: 15/07/2022 22:04:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[registro](
	[reg_id] [int] NOT NULL,
	[reg_pat_id] [int] NOT NULL,
	[reg_cho_id] [int] NOT NULL,
	[reg_fecs] [datetime] NOT NULL,
	[reg_fece] [datetime] NOT NULL,
	[reg_pesb] [varchar](20) NOT NULL,
	[reg_pest] [varchar](20) NOT NULL,
 CONSTRAINT [PK_registro_] PRIMARY KEY CLUSTERED 
(
	[reg_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[v_registro_s]    Script Date: 15/07/2022 22:04:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO












CREATE view [dbo].[v_registro_s]
as
select r.reg_id, p.pat_nom, c.cho_apel + ' '+c.cho_nom as chofer,datename(dw,r.reg_fecs) as fecs_nomday, FORMAT (r.reg_fecs,'dd') as fecs_d,FORMAT (r.reg_fecs,'MM') as fecs_m, FORMAT (r.reg_fecs,'yyyy') as fecs_y, FORMAT (r.reg_fecs,'HH') as fecs_h,FORMAT (r.reg_fecs,'mm') as fecs_min,datename(dw,r.reg_fece) as fece_nomday, FORMAT (r.reg_fece,'dd') as fece_d,FORMAT (r.reg_fece,'MM') as fece_m, FORMAT (r.reg_fece,'yyyy') as fece_y,FORMAT (r.reg_fece,'HH') as fece_h,FORMAT (r.reg_fece,'mm') as fece_min, r.reg_pesb as pesobruto, r.reg_pest as pesotara,r.reg_fecs, r.reg_fece  from registro as r inner join patente as p on r.reg_pat_id =p.pat_id  inner join chofer  as c on r.reg_cho_id =c.cho_id 
GO
/****** Object:  Table [dbo].[prueba]    Script Date: 15/07/2022 22:04:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[prueba](
	[p_fec] [date] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[recorrido]  WITH CHECK ADD  CONSTRAINT [FK_recorrido_lugar] FOREIGN KEY([rec_lug_id])
REFERENCES [dbo].[lugar] ([lug_id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[recorrido] CHECK CONSTRAINT [FK_recorrido_lugar]
GO
ALTER TABLE [dbo].[recorrido]  WITH CHECK ADD  CONSTRAINT [FK_recorrido_registro] FOREIGN KEY([rec_reg_id])
REFERENCES [dbo].[registro] ([reg_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[recorrido] CHECK CONSTRAINT [FK_recorrido_registro]
GO
ALTER TABLE [dbo].[registro]  WITH CHECK ADD  CONSTRAINT [FK_registro_chofer] FOREIGN KEY([reg_cho_id])
REFERENCES [dbo].[chofer] ([cho_id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[registro] CHECK CONSTRAINT [FK_registro_chofer]
GO
ALTER TABLE [dbo].[registro]  WITH CHECK ADD  CONSTRAINT [FK_registro_patente] FOREIGN KEY([reg_pat_id])
REFERENCES [dbo].[patente] ([pat_id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[registro] CHECK CONSTRAINT [FK_registro_patente]
GO
/****** Object:  StoredProcedure [dbo].[chofer_delete]    Script Date: 15/07/2022 22:04:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[chofer_delete]
@cho_id as int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	delete from chofer where cho_id=@cho_id 
END
GO
/****** Object:  StoredProcedure [dbo].[chofer_insert]    Script Date: 15/07/2022 22:04:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[chofer_insert]
     @cho_nom varchar(80),
	 @cho_apel varchar(80)
AS
BEGIN
	SET NOCOUNT ON;
insert into chofer (cho_nom,cho_apel ,cho_est ) values (@cho_nom,@cho_apel ,'A')
END
GO
/****** Object:  StoredProcedure [dbo].[chofer_search]    Script Date: 15/07/2022 22:04:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[chofer_search]
	-- Add the parameters for the stored procedure here
	@val_busca as varchar(120)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	--SELECT * from chofer where cho_nom like '%'+@val_busca+'%' or cho_apel like '%'+@val_busca +'%' order by cho_id desc
	SELECT * from v_chofer where chofer like '%'+@val_busca+'%' order by cho_id desc
END
GO
/****** Object:  StoredProcedure [dbo].[chofer_select]    Script Date: 15/07/2022 22:04:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[chofer_select]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT *from chofer  order by cho_id desc
END
GO
/****** Object:  StoredProcedure [dbo].[chofer_update]    Script Date: 15/07/2022 22:04:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[chofer_update]
@condi as int,
@cho_id as int,
@cho_nom as varchar(100),
@cho_apel as varchar (100),
@cho_est as char(1)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
if @condi =0
begin
update chofer set cho_nom=@cho_nom ,cho_apel =@cho_apel,cho_est = @cho_est where cho_id =@cho_id
end 
if @condi =1
begin
update chofer set cho_nom=@cho_nom where cho_id =@cho_id 
end
if @condi =2
begin
update chofer set cho_apel=@cho_apel  where cho_id =@cho_id 
end
if @condi =3
begin
update chofer set cho_est =@cho_est  where cho_id =@cho_id 
end
END
GO
/****** Object:  StoredProcedure [dbo].[lugar_delete]    Script Date: 15/07/2022 22:04:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[lugar_delete] 
	-- Add the parameters for the stored procedure here
	@lug_id as int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	delete from lugar where lug_id=@lug_id
END
GO
/****** Object:  StoredProcedure [dbo].[lugar_insert]    Script Date: 15/07/2022 22:04:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[lugar_insert]
	-- Add the parameters for the stored procedure here
@lug_nom as varchar(120)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into lugar (lug_nom) values (@lug_nom)
END
GO
/****** Object:  StoredProcedure [dbo].[lugar_search]    Script Date: 15/07/2022 22:04:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[lugar_search]
	-- Add the parameters for the stored procedure here
	@lug_nom as varchar (120)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT *from lugar where lug_nom like '%'+@lug_nom+'%' order by lug_id desc
END
GO
/****** Object:  StoredProcedure [dbo].[lugar_select]    Script Date: 15/07/2022 22:04:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[lugar_select]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from lugar order by lug_nom
END
GO
/****** Object:  StoredProcedure [dbo].[lugar_update]    Script Date: 15/07/2022 22:04:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE   PROCEDURE [dbo].[lugar_update]
	-- Add the parameters for the stored procedure here
	@lug_id as int,
	@lug_nom as varchar(120)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update lugar set lug_nom=@lug_nom where lug_id=@lug_id
END
GO
/****** Object:  StoredProcedure [dbo].[patente_delete]    Script Date: 15/07/2022 22:04:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[patente_delete]
@pat_id int
AS
BEGIN
	SET NOCOUNT ON;
delete from patente where pat_id=@pat_id
END
GO
/****** Object:  StoredProcedure [dbo].[patente_insert]    Script Date: 15/07/2022 22:04:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[patente_insert]
	@patente varchar(50) 
AS
BEGIN
    -- Insert statements for procedure here
	SET NOCOUNT ON;
	insert into patente(pat_nom,pat_est) VALUES (@patente,'A');
END

GO
/****** Object:  StoredProcedure [dbo].[patente_search]    Script Date: 15/07/2022 22:04:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[patente_search]
	@param varchar(80)
AS
BEGIN
SET NOCOUNT ON;
SELECT*FROM patente where pat_nom like '%'+@param+'%'
END
GO
/****** Object:  StoredProcedure [dbo].[patente_select]    Script Date: 15/07/2022 22:04:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[patente_select]
AS
BEGIN
SET NOCOUNT ON;
      SELECT pat_id,pat_nom,pat_est  FROM patente order by pat_id desc
END

GO
/****** Object:  StoredProcedure [dbo].[patente_update]    Script Date: 15/07/2022 22:04:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[patente_update]
	-- Add the parameters for the stored procedure here
	@condicion int,
	@pat_id int,
	@pat_nom varchar(80),
	@pat_est char(1)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	if (@condicion =0)
	begin
	update patente set pat_nom=@pat_nom, pat_est =@pat_est where pat_id =@pat_id 
	end

	if (@condicion =1)
	begin
	update patente set pat_nom=@pat_nom where pat_id =@pat_id 
	end

	if (@condicion =2)
	begin
	update patente set pat_est=@pat_est where pat_id =@pat_id 
	end
END
GO
/****** Object:  StoredProcedure [dbo].[recorrido_coun]    Script Date: 15/07/2022 22:04:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--use bd_soft_fran 

CREATE procedure [dbo].[recorrido_coun]
as
declare @count as int
--@count= 
select @count= count(*) From v_recorrido --group by rec_reg_id 
--select @count
select @count as cuenta, * from v_recorrido 
GO
/****** Object:  StoredProcedure [dbo].[recorrido_insert]    Script Date: 15/07/2022 22:04:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[recorrido_insert]
@reg_id as int,
@lugar as varchar (200)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
		declare @lug_id as int
    --select @pat_id =pat_id  from patente where CHARINDEX(pat_nom,@patente)>0
	select @lug_id =lug_id  from lugar where lug_nom=@lugar 
	INSERT INTO [dbo].[recorrido]
           ([rec_reg_id]
           ,[rec_lug_id])
     VALUES
           (@reg_id,@lug_id )

END
GO
/****** Object:  StoredProcedure [dbo].[recorrido_select]    Script Date: 15/07/2022 22:04:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[recorrido_select]
	-- Add the parameters for the stored procedure here
	@reg_id as int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from v_recorrido where rec_reg_id= @reg_id 
END
GO
/****** Object:  StoredProcedure [dbo].[recorrido_update]    Script Date: 15/07/2022 22:04:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[recorrido_update]
	-- Add the parameters for the stored procedure here
@num as int,
@rec_id as int,
@reg_id as int, 
--@lug_v as varchar(120),
@lug_n as varchar (120)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

if @lug_n <>''
begin
declare @lug_id_n as int 
select @lug_id_n =lug_id  from lugar where lug_nom =@lug_n 
end

if @num=0
begin
update recorrido set rec_lug_id =@lug_id_n where rec_id =@rec_id
end

if @num=1
begin
insert into recorrido (rec_reg_id,rec_lug_id ) values (@reg_id ,@lug_id_n )
end

if @num=2
begin
delete from recorrido where rec_id =@rec_id 
end

END
GO
/****** Object:  StoredProcedure [dbo].[registro_count]    Script Date: 15/07/2022 22:04:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--use bd_soft_fran 

CREATE procedure [dbo].[registro_count]
@pat_id as int,
@cho_id as int,
@lug_id as int
as
begin
if @pat_id <>''
begin
select count(*) as cantidad from registro where reg_pat_id=@pat_id 
end 

if @cho_id <>''
begin
select count(*) as cantidad from registro where reg_cho_id=@cho_id
end 

if @lug_id <>''
begin
select count(*) as cantidad from recorrido where rec_lug_id=@lug_id
end 

end

--select*from patente 
GO
/****** Object:  StoredProcedure [dbo].[registro_report]    Script Date: 15/07/2022 22:04:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[registro_report]
@nomday as varchar(50),
@fec_y as varchar(5),
@fec_m as varchar(5),
@fecha_desde as varchar(50),
@fecha_hasta as varchar(50)

as begin
if @fecha_hasta =''
begin
select*from v_registro_s where pesobruto<>'' and fece_nomday like '%'+@nomday +'%' and fece_y=@fec_y  and fece_m like '%'+@fec_m +'%' order by reg_fece
end
else
begin
select*from v_registro_s where pesobruto<>'' and fece_nomday like '%'+@nomday +'%' and reg_fece >=@fecha_desde   and  reg_fece <=@fecha_hasta order by reg_fece
end
end 
GO
/****** Object:  StoredProcedure [dbo].[registroE_update]    Script Date: 15/07/2022 22:04:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[registroE_update]
@reg_id as int,
@fecha as varchar(50),
@pesb as varchar(10),
@pest as varchar(10)

as
BEGIN
if @fecha=''
begin
set @fecha= getdate()
end

update registro set reg_fece =@fecha, reg_pesb =@pesb, reg_pest =@pest where reg_id=@reg_id
END

GO
/****** Object:  StoredProcedure [dbo].[registroS_delete]    Script Date: 15/07/2022 22:04:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[registroS_delete]
	-- Add the parameters for the stored procedure here
	@reg_id as int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	delete from registro where reg_id=@reg_id 
END
GO
/****** Object:  StoredProcedure [dbo].[registroS_insert]    Script Date: 15/07/2022 22:04:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[registroS_insert]
	-- Add the parameters for the stored procedure here
	@reg_id as int,
	@patente as varchar(80),
	@chofer as varchar (200),
	@fecha as varchar(40)
	AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
--------------------------------------------------------------------------------------------------------------
	declare @pat_id as int
    --select @pat_id =pat_id  from patente where CHARINDEX(pat_nom,@patente)>0
	select @pat_id =pat_id  from patente where pat_nom=@patente
--------------------------------------------------------------------------------------------------------------
declare @cho_id as int
--select @cho_id =cho_id  from chofer where @chofer  like '%'+cho_nom+'%' and  @chofer  like '%'+cho_apel+'%'
select @cho_id =cho_id  from v_chofer where chofer =@chofer 
--------------------------------------------------------------------------------------------------------------

	--declare @reg_fecs as datetime
	--set @reg_fecs=  FORMAT(getdate(),'dd-MM-yyyy HH:mm')
    -- Insert statements for procedure here
	if @fecha =''
	begin
	INSERT INTO [dbo].[registro]
           ([reg_id]
		   ,[reg_pat_id]
           ,[reg_cho_id]
           ,[reg_fecs]
           ,[reg_fece]
           ,[reg_pesb]
           ,[reg_pest])
     VALUES (@reg_id ,@pat_id, @cho_id,getdate(),'','','')  --DAY(getdate())+'/'+month(getdate())+'/'+year(getdate())
	end
	else
	begin
	INSERT INTO [dbo].[registro]
           ([reg_id]
		   ,[reg_pat_id]
           ,[reg_cho_id]
           ,[reg_fecs]
           ,[reg_fece]
           ,[reg_pesb]
           ,[reg_pest])
     VALUES (@reg_id ,@pat_id,@cho_id , @fecha,'','','')
  end
--------------------------------------------------------------------------------------------------------------
END
GO
/****** Object:  StoredProcedure [dbo].[registroS_search]    Script Date: 15/07/2022 22:04:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[registroS_search]
	-- Add the parameters for the stored procedure here
	@control as int,
	@patente as varchar(50),
	@chofer as varchar(80),
	@fec_y as varchar(10), 
	@fec_m as varchar(10), 
	@fec_d as varchar(5), 
	@fec_nomday as varchar(20),
	@fec_h as varchar(5),
	@fec_min as varchar(5)
AS
BEGIN
if @control=0
begin
select*from v_registro_s where pat_nom like '%'+@patente +'%' and chofer like '%'+@chofer +'%' and fecs_y like '%'+@fec_y+'%' and fecs_m like '%'+@fec_m+'%' and fecs_d like '%'+@fec_d+'%' and fecs_nomday like '%'+@fec_nomday +'%' and fecs_h like '%'+@fec_h+'%' and fecs_min like '%'+@fec_min+'%' order by reg_fecs desc
end

if @control=1
begin
select*from v_registro_s where pat_nom like '%'+@patente +'%' and chofer like '%'+@chofer +'%' and fece_y like '%'+@fec_y+'%' and fece_m like '%'+@fec_m+'%' and fece_d like '%'+@fec_d+'%' and fece_nomday like '%'+@fec_nomday +'%' and fece_h like '%'+@fec_h+'%' and fece_min like '%'+@fec_min+'%' order by reg_fecs desc
END
end
GO
/****** Object:  StoredProcedure [dbo].[registroS_update]    Script Date: 15/07/2022 22:04:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[registroS_update]
	-- Add the parameters for the stored procedure here
	@reg_id as int,
	@patente as varchar(80),
	@chofer as varchar (200),
	@fecha as varchar(40)
	AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
--------------------------------------------------------------------------------------------------------------
if len(@patente)>0
begin
	declare @pat_id as int
    --select @pat_id =pat_id  from patente where CHARINDEX(pat_nom,@patente)>0
	select @pat_id =pat_id  from patente where pat_nom=@patente
    UPDATE [dbo].[registro] SET [reg_pat_id] = @pat_id WHERE reg_id =@reg_id 
end 
----------------------------------------------------------------------------------------------------------------
if len(@chofer)>0
begin
declare @cho_id as int
--select @cho_id =cho_id  from chofer where @chofer  like '%'+cho_nom+'%' and  @chofer  like '%'+cho_apel+'%'
select @cho_id =cho_id  from v_chofer where chofer= @chofer
UPDATE [dbo].[registro] SET [reg_cho_id] = @cho_id WHERE reg_id =@reg_id 
end

if @fecha =''
begin
UPDATE [dbo].[registro] SET reg_fecs = getdate() WHERE reg_id =@reg_id 
end 
else
begin 
UPDATE [dbo].[registro] SET reg_fecs = @fecha WHERE reg_id =@reg_id 
end
-----------------------------------------------------------------------------------------------------------------
END
GO
USE [master]
GO
ALTER DATABASE [bd_soft_fran] SET  READ_WRITE 
GO
