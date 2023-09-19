CREATE TABLE [dbo].[LOC_City](
	[CityID] [int] IDENTITY(1,1) NOT NULL,
	[CityName] [varchar](100) NOT NULL,
	[StateID] [int] NOT NULL,
	[CountryID] [int] NOT NULL,
	[Citycode] [varchar](50) NOT NULL,
	[CreationDate] [datetime] NOT NULL,
	[Modified] [datetime] NOT NULL,
 CONSTRAINT [PK_LOC_City] PRIMARY KEY CLUSTERED 
(
	[CityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOC_Country]    Script Date: 24-Jul-23 9:49:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LOC_Country](
	[CountryID] [int] IDENTITY(1,1) NOT NULL,
	[CountryName] [varchar](100) NOT NULL,
	[CountryCode] [varchar](50) NOT NULL,
	[Created] [datetime] NOT NULL,
	[Modified] [datetime] NOT NULL,
 CONSTRAINT [PK_LOC_Country] PRIMARY KEY CLUSTERED 
(
	[CountryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOC_State]    Script Date: 24-Jul-23 9:49:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LOC_State](
	[StateID] [int] IDENTITY(1,1) NOT NULL,
	[StateName] [varchar](100) NOT NULL,
	[CountryID] [int] NOT NULL,
	[StateCode] [varchar](50) NOT NULL,
	[Created] [datetime] NOT NULL,
	[Modified] [datetime] NOT NULL,
 CONSTRAINT [PK_LOC_State] PRIMARY KEY CLUSTERED 
(
	[StateID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MST_Branch]    Script Date: 24-Jul-23 9:49:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MST_Branch](
	[BranchID] [int] IDENTITY(1,1) NOT NULL,
	[BranchName] [varchar](100) NOT NULL,
	[BranchCode] [varchar](100) NOT NULL,
	[Created] [datetime] NOT NULL,
	[Modified] [datetime] NOT NULL,
 CONSTRAINT [PK_MST_Branch] PRIMARY KEY CLUSTERED 
(
	[BranchID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MST_Student]    Script Date: 24-Jul-23 9:49:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MST_Student](
	[StudentID] [int] IDENTITY(1,1) NOT NULL,
	[BranchID] [int] NOT NULL,
	[CityID] [int] NOT NULL,
	[StudentName] [varchar](100) NOT NULL,
	[MobileNoStudent] [varchar](100) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[MobileNoFather] [varchar](100) NULL,
	[Address] [varchar](500) NULL,
	[BirthDate] [datetime] NULL,
	[Age] [int] NULL,
	[IsActive] [bit] NULL,
	[Gender] [varchar](50) NULL,
	[Password] [varchar](100) NULL,
	[Created] [datetime] NOT NULL,
	[Modified] [datetime] NOT NULL
	
 CONSTRAINT [PK_MST_Student] PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[LOC_City] ADD  CONSTRAINT [DF_LOC_City_CreationDate]  DEFAULT (getdate()) FOR [CreationDate]
GO
ALTER TABLE [dbo].[LOC_City] ADD  CONSTRAINT [DF_LOC_City_Modified]  DEFAULT (getdate()) FOR [Modified]
GO
ALTER TABLE [dbo].[LOC_Country] ADD  CONSTRAINT [DF_LOC_Country_Created]  DEFAULT (getdate()) FOR [Created]
GO
ALTER TABLE [dbo].[LOC_Country] ADD  CONSTRAINT [DF_LOC_Country_Modified]  DEFAULT (getdate()) FOR [Modified]
GO
ALTER TABLE [dbo].[LOC_State] ADD  CONSTRAINT [DF_LOC_State_Created]  DEFAULT (getdate()) FOR [Created]
GO
ALTER TABLE [dbo].[LOC_State] ADD  CONSTRAINT [DF_LOC_State_Modified]  DEFAULT (getdate()) FOR [Modified]
GO
ALTER TABLE [dbo].[MST_Branch] ADD  CONSTRAINT [DF_MST_Branch_Created]  DEFAULT (getdate()) FOR [Created]
GO
ALTER TABLE [dbo].[MST_Branch] ADD  CONSTRAINT [DF_MST_Branch_Modified]  DEFAULT (getdate()) FOR [Modified]
GO
ALTER TABLE [dbo].[MST_Student] ADD  CONSTRAINT [DF_MST_Student_Created]  DEFAULT (getdate()) FOR [Created]
GO
ALTER TABLE [dbo].[MST_Student] ADD  CONSTRAINT [DF_MST_Student_Modified]  DEFAULT (getdate()) FOR [Modified]
GO
ALTER TABLE [dbo].[LOC_City]  WITH CHECK ADD  CONSTRAINT [FK_LOC_City_LOC_Country] FOREIGN KEY([CountryID])
REFERENCES [dbo].[LOC_Country] ([CountryID])
GO
ALTER TABLE [dbo].[LOC_City] CHECK CONSTRAINT [FK_LOC_City_LOC_Country]
GO
ALTER TABLE [dbo].[LOC_City]  WITH CHECK ADD  CONSTRAINT [FK_LOC_City_LOC_State] FOREIGN KEY([StateID])
REFERENCES [dbo].[LOC_State] ([StateID])
GO
ALTER TABLE [dbo].[LOC_City] CHECK CONSTRAINT [FK_LOC_City_LOC_State]
GO
ALTER TABLE [dbo].[LOC_State]  WITH CHECK ADD  CONSTRAINT [FK_LOC_State_LOC_Country] FOREIGN KEY([CountryID])
REFERENCES [dbo].[LOC_Country] ([CountryID])
GO
ALTER TABLE [dbo].[LOC_State] CHECK CONSTRAINT [FK_LOC_State_LOC_Country]
GO
ALTER TABLE [dbo].[MST_Student]  WITH CHECK ADD  CONSTRAINT [FK_MST_Student_LOC_City] FOREIGN KEY([CityID])
REFERENCES [dbo].[LOC_City] ([CityID])
GO
ALTER TABLE [dbo].[MST_Student] CHECK CONSTRAINT [FK_MST_Student_LOC_City]
GO
ALTER TABLE [dbo].[MST_Student]  WITH CHECK ADD  CONSTRAINT [FK_MST_Student_MST_Branch] FOREIGN KEY([BranchID])
REFERENCES [dbo].[MST_Branch] ([BranchID])
GO
ALTER TABLE [dbo].[MST_Student] CHECK CONSTRAINT [FK_MST_Student_MST_Branch]

select * from LOC_City
select * from LOC_State
select * from LOC_Country

//------------------City Table procedure-------------------

CREATE PROCEDURE [dbo].[PR_City_SelectAll]
AS
SELECT [dbo].[LOC_City].[CityID]
 ,[dbo].[LOC_City].[CityName]
 ,[dbo].[LOC_City].[StateID]
 ,[dbo].[LOC_City].[CountryID]
 ,[dbo].[LOC_State].[StateName]
 ,[dbo].[LOC_Country].[CountryName]
 ,[dbo].[LOC_City].[CreationDate]
 ,[dbo].[LOC_City].[Modified]
FROM [dbo].[LOC_City]
INNER JOIN [dbo].[LOC_State]
ON [dbo].[LOC_State].[StateID] = [dbo].[LOC_City].[StateID]
INNER JOIN [dbo].[LOC_Country]
ON [dbo].[LOC_Country].[CountryID] = [dbo].[LOC_State].[CountryID]
ORDER BY [dbo].[LOC_Country].[CountryName]
 ,[dbo].[LOC_State].[StateName]
 ,[dbo].[LOC_City].[CityName]

exec PR_City_SelectAll


CREATE PROCEDURE [dbo].[PR_City_SelectByPK] 
@CityID int
AS
SELECT
 [dbo].[LOC_City].[CityID]
 ,[dbo].[LOC_City].[CityName]
 ,[dbo].[LOC_City].[StateID]
 ,[dbo].[LOC_City].[CountryID]
 ,[dbo].[LOC_State].[StateName]
 ,[dbo].[LOC_Country].[CountryName]
 ,[dbo].[LOC_City].[CreationDate]
 ,[dbo].[LOC_City].[Modified]
FROM [dbo].[LOC_City]
INNER JOIN [dbo].[LOC_State]
ON [dbo].[LOC_State].[StateID] = [dbo].[LOC_City].[StateID]
INNER JOIN [dbo].[LOC_Country]
ON [dbo].[LOC_Country].[CountryID] = [dbo].[LOC_City].[CountryID]
WHERE [dbo].[LOC_City].[CityID] = @CityID
ORDER BY
[dbo].[LOC_Country].[CountryName]
,[dbo].[LOC_State].[StateName]
,[dbo].[LOC_City].[CityName]

exec PR_City_SelectByPK 3


CREATE PROCEDURE [dbo].[PR_City_Insert]
@CityName varchar(100),
@StateID int,
@CountryID int,
@Citycode varchar(100)
AS
INSERT INTO [dbo].[LOC_City]
(
[CityName]
,[StateID]
,[CountryID]
,[Citycode]
)
VALUES
(
@CityName,
@StateID,
@CountryID,
@Citycode
)

exec PR_City_Insert "Mumbai",2,1,"MU"


CREATE PROCEDURE [dbo].[PR_City_UpdateByPK]
@CityID int,
@CityName varchar(100),
@StateID int,
@CountryID int,
@Citycode varchar(100)
AS
UPDATE [dbo].[LOC_City]
 SET [CityName] = @CityName,
 [StateID] = @StateID,
 [CountryID] = @CountryID,
 [Citycode]=@Citycode,
 [Modified]=getdate()
WHERE [dbo].[LOC_City].[CityID] = @CityID

exec PR_City_UpdateByPK 6,"Delhi",1,1,"DH"


CREATE PROCEDURE [dbo].[PR_City_DeleteByPK]
@CityID int
AS
DELETE
FROM [dbo].[LOC_City]
WHERE [dbo].[LOC_City].[CityID] = @CityID

exec PR_City_DeleteByPK 6




//--------------State table----------------------
CREATE PROCEDURE [dbo].[PR_State_SelectAll]
AS
SELECT
[dbo].[LOC_State].[StateID]
 ,[dbo].[LOC_State].[StateName]
 ,[dbo].[LOC_State].[StateCode]
 ,[dbo].[LOC_Country].[CountryID]
 ,[dbo].[LOC_Country].[CountryName]
  ,[dbo].[LOC_State].[Created]
    ,[dbo].[LOC_State].[Modified]
FROM [dbo].[LOC_State]
INNER JOIN [dbo].[LOC_Country]
ON [dbo].[LOC_Country].[CountryID] = [dbo].[LOC_State].[CountryID]
ORDER BY [dbo].[LOC_Country].[CountryName]
 ,[dbo].[LOC_State].[StateName]

exec PR_State_SelectAll


CREATE PROCEDURE [dbo].[PR_State_SelectByPK] 
@StateID int
AS
SELECT
[dbo].[LOC_State].[StateID]
 ,[dbo].[LOC_State].[StateName]
 ,[dbo].[LOC_State].[StateCode]
 ,[dbo].[LOC_State].[CountryID]
 ,[dbo].[LOC_Country].[CountryName]
 ,[dbo].[LOC_State].[Created]
 ,[dbo].[LOC_State].[Modified]
FROM [dbo].[LOC_State]
INNER JOIN [dbo].[LOC_Country]
ON [dbo].[LOC_Country].[CountryID] = [dbo].[LOC_State].[CountryID]
WHERE [dbo].[LOC_State].[StateID] = @StateID
ORDER BY
[dbo].[LOC_Country].[CountryName]
,[dbo].[LOC_State].[StateName]

exec PR_State_SelectByPK 2


CREATE PROCEDURE [dbo].[PR_State_Insert]
@StateName varchar(100),
@Statecode varchar(100),
@CountryID int
AS
INSERT INTO [dbo].[LOC_State]
(
[StateName],
[StateCode],
[CountryID]
)
VALUES
(
@StateName,
@Statecode,
@CountryID
)

exec PR_State_Insert "Panjab","PU",2


CREATE PROCEDURE [dbo].[PR_State_UpdateByPK]
@StateID int,
@StateName varchar(100),
@Statecode varchar(100),
@CountryID int
AS
UPDATE [dbo].[LOC_State]
 SET [StateName]=@StateName,
 [Statecode]=@Statecode,
 [CountryID]=@CountryID,
 [Modified]=getdate()
WHERE [dbo].[LOC_State].[StateID] = @StateID

exec PR_State_UpdateByPK 5,"hello","HE",1


CREATE PROCEDURE [dbo].[PR_State_DeleteByPK]
@StateID int
AS
DELETE
FROM [dbo].[LOC_State]
WHERE [dbo].[LOC_State].[StateID] = @StateID

exec PR_State_DeleteByPK 5



//--------------Country table--------------
 CREATE PROCEDURE [dbo].[PR_Country_SelectAll]
AS
SELECT
[dbo].[LOC_Country].[CountryID]
 ,[dbo].[LOC_Country].[CountryName]
 ,[dbo].[LOC_Country].[CountryCode]
  ,[dbo].[LOC_Country].[Created]
  ,[dbo].[LOC_Country].[Modified]
FROM [dbo].[LOC_Country]
ORDER BY [dbo].[LOC_Country].[CountryName]

exec PR_Country_SelectAll

CREATE PROCEDURE [dbo].[PR_Country_SelectByPK] 
@CountryID int
AS
SELECT
[dbo].[LOC_Country].[CountryID]
 ,[dbo].[LOC_Country].[CountryName]
 ,[dbo].[LOC_Country].[CountryCode]
  ,[dbo].[LOC_Country].[Created]
  ,[dbo].[LOC_Country].[Modified]
FROM [dbo].[LOC_Country]
WHERE [dbo].[LOC_Country].[CountryID] = @CountryID
ORDER BY
[dbo].[LOC_Country].[CountryName]

exec PR_Country_SelectByPK 2

CREATE PROCEDURE [dbo].[PR_Country_Insert]
@CountryName varchar(100),
@CountryCode varchar(100)
AS
INSERT INTO [dbo].[LOC_Country]
(
[CountryName]
,[CountryCode]
)
VALUES
(
@CountryName,
@CountryCode
)

exec PR_Country_Insert "Dubai","DU2"


CREATE PROCEDURE [dbo].[PR_Country_UpdateByPK]
@CountryID int,
@CountryName varchar(100),
@CountryCode varchar(100)
AS
UPDATE [dbo].[LOC_Country]
 SET 
 [CountryName] = @CountryName,
 [CountryCode] = @CountryCode,
 [Modified]=getdate()
WHERE [dbo].[LOC_Country].[CountryID] = @CountryID

exec PR_Country_UpdateByPK 2,"Rasia3","RU3"


CREATE PROCEDURE [dbo].[PR_Country_DeleteByPK]
@CountryID int
AS
DELETE
FROM [dbo].[LOC_Country]
WHERE [dbo].[LOC_Country].[CountryID] = @CountryID

exec PR_Country_DeleteByPK 4




//------------ Branch table---------
 CREATE PROCEDURE [dbo].[PR_Branch_SelectAll]
AS
SELECT
[dbo].[MST_Branch].[BranchID],
[dbo].[MST_Branch].[BranchName],
[dbo].[MST_Branch].[BranchCode],
[dbo].[MST_Branch].[Created],
[dbo].[MST_Branch].[Modified]
from [dbo].[MST_Branch]
ORDER By [dbo].[MST_Branch].[BranchName]


CREATE PROCEDURE [dbo].[PR_Branch_SelectByPK] 
@BranchID int
as
SELECT
[dbo].[MST_Branch].[BranchID],
[dbo].[MST_Branch].[BranchName],
[dbo].[MST_Branch].[BranchCode],
[dbo].[MST_Branch].[Created],
[dbo].[MST_Branch].[Modified]
from [dbo].[MST_Branch]
where [dbo].[MST_Branch].[BranchID]=@BranchID
ORDER By [dbo].[MST_Branch].[BranchName]

exec [dbo].[PR_Branch_SelectByPK] 2

CREATE PROCEDURE [dbo].[PR_Branch_Insert]
@BranchName varchar(100),
@BranchCode varchar(100)
as
Insert 
into [dbo].[MST_Branch]
(
[BranchName],
[BranchCode]
)
VALUES
(
@BranchName,
@BranchCode
)

exec [dbo].[PR_Branch_Insert] "Micanical","ME"



CREATE PROCEDURE [dbo].[PR_Branch_UpdateByPK]
@BranchID int,
@BranchName varchar(100),
@BranchCode varchar(100)
as
UPDATE [dbo].[MST_Branch]
set
[BranchName]=@BranchName,
[BranchCode]=@BranchCode,
[Modified]=GETDATE()
where [dbo].[MST_Branch].[BranchID]=@BranchID

exec [dbo].[PR_Branch_UpdateByPK] 3 ,"Micanical","ME"


CREATE PROCEDURE [dbo].[PR_Branch_DeleteByPK]
@BranchID int
as
DELETE
from [dbo].[MST_Branch] 
where [dbo].[MST_Branch].[BranchID]=@BranchID

exec [dbo].[PR_Branch_DeleteByPK] 3



//----------------------student table-----------------------


Create PROCEDURE [dbo].[PR_Student_SelectAll]
as
select
[dbo].[MST_Student].[StudentID]
,[dbo].[MST_Student].[BranchID]
,[dbo].[MST_Student].[CityID]
,[dbo].[MST_Student].[StudentName]
,[dbo].[MST_Branch].[BranchName]
,[dbo].[LOC_City].[CityName]
,[dbo].[LOC_State].[StateName]
,[dbo].[LOC_Country].[CountryName]
,[dbo].[MST_Student].[MobileNoStudent]
,[dbo].[MST_Student].[Email]
,[dbo].[MST_Student].[MobileNoFather]
,[dbo].[MST_Student].[Address]
,[dbo].[MST_Student].[BirthDate]
,[dbo].[MST_Student].[Age]
,[dbo].[MST_Student].[IsActive]
,[dbo].[MST_Student].[Gender]
,[dbo].[MST_Student].[Password]
,[dbo].[MST_Student].[Created]
,[dbo].[MST_Student].[Modified]
from [dbo].[MST_Student]
inner join [dbo].[LOC_City]
on [dbo].[MST_Student].[CityID]=[dbo].[LOC_City].[CityID]
inner join [dbo].[LOC_State]
on [dbo].[LOC_City].[StateID]=[dbo].[LOC_State].[StateID]
inner join [dbo].[LOC_Country]
on [dbo].[LOC_City].[CountryID]=[dbo].[LOC_Country].[CountryID]
inner join [dbo].[MST_Branch]
on [dbo].[MST_Student].[BranchID]=[dbo].[MST_Branch].[BranchID]
order by 
[dbo].[MST_Student].[StudentName]
,[dbo].[MST_Branch].[BranchName]
,[dbo].[LOC_City].[CityName]
,[dbo].[LOC_State].[StateName]
,[LOC_Country].[CountryName]



CREATE PROCEDURE [dbo].[PR_Student_SelectByPK]
@StudentID int
as
select
 [dbo].[MST_Student].[StudentID]
,[dbo].[MST_Student].[BranchID]
,[dbo].[MST_Student].[CityID]
,[dbo].[MST_Student].[StudentName]
,[dbo].[MST_Branch].[BranchName]
,[dbo].[LOC_City].[CityName]
,[dbo].[LOC_State].[StateName]
,[dbo].[LOC_Country].[CountryName]
,[dbo].[MST_Student].[MobileNoStudent]
,[dbo].[MST_Student].[Email]
,[dbo].[MST_Student].[MobileNoFather]
,[dbo].[MST_Student].[Address]
,[dbo].[MST_Student].[BirthDate]
,[dbo].[MST_Student].[Age]
,[dbo].[MST_Student].[IsActive]
,[dbo].[MST_Student].[Gender]
,[dbo].[MST_Student].[Password]
,[dbo].[MST_Student].[Created]
,[dbo].[MST_Student].[Modified]
from [dbo].[MST_Student]
inner join [dbo].[LOC_City]
on [dbo].[MST_Student].[CityID]=[dbo].[LOC_City].[CityID]
inner join [dbo].[LOC_State]
on [dbo].[LOC_City].[StateID]=[dbo].[LOC_State].[StateID]
inner join [dbo].[LOC_Country]
on [dbo].[LOC_State].[CountryID]=[dbo].[LOC_Country].[CountryID]
inner join [dbo].[MST_Branch]
on [dbo].[MST_Student].[BranchID]=[dbo].[MST_Branch].[BranchID]
where [dbo].[MST_Student].[StudentID]=@StudentID
order by 
[dbo].[MST_Student].[StudentName]
,[dbo].[MST_Branch].[BranchName]
,[dbo].[LOC_City].[CityName]
,[dbo].[LOC_State].[StateName]
,[LOC_Country].[CountryName]

exec [dbo].[PR_Student_SelectByPK] 1



CREATE PROCEDURE [dbo].[PR_Student_Insert]
@BranchID			int, 
@CityID				int,
@StudentName		varchar(100),
@MobileNoStudent	varchar(100),
@Email				varchar(100),
@MobileNoFather		varchar(100),
@Address			varchar(100),
@BirthDate			datetime,
@Age				int,
@IsActive			bit,
@Gender				varchar(100),
@Password			varchar(100)
as 
Insert Into [dbo].[MST_Student]
(
[BranchID],
[CityID],
[StudentName],
[MobileNoStudent],
[Email],
[MobileNoFather],
[Address],
[BirthDate],
[Age],
[IsActive],
[Gender],
[Password]
)
values
(	
@BranchID		,
@CityID			,
@StudentName	,
@MobileNoStudent,
@Email			,
@MobileNoFather	,
@Address		,
@BirthDate		,
@Age			,
@IsActive		,
@Gender			,
@Password		
)

exec [dbo].[PR_Student_Insert] 2,3,"hello2","hello3","hello","hello","hello",'2012/04/06 12:23:45',2,true,"hello","hello"

CREATE PROCEDURE [dbo].[PR_Student_UpdateByPK]
@StudentID			int,
@BranchID			int, 
@CityID				int,
@StudentName		varchar(100),
@MobileNoStudent	varchar(100),
@Email				varchar(100),
@MobileNoFather		varchar(100),
@Address			varchar(100),
@BirthDate			datetime,
@Age				int,
@IsActive			bit,
@Gender				varchar(100),
@Password			varchar(100)
as 
UPDATE  [dbo].[MST_Student]
set
[BranchID]				=@BranchID		,
[CityID]				=@CityID			,
[StudentName]			=@StudentName	,
[MobileNoStudent]		=@MobileNoStudent,
[Email]					=@Email			,
[MobileNoFather]		=@MobileNoFather	,
[Address]				=@Address		,
[BirthDate]				=@BirthDate		,
[Age]					=@Age			,
[IsActive]				=@IsActive		,
[Gender]				=@Gender			,
[Password]				=@Password		,
[Modified]				=getdate()
where [dbo].[MST_Student].[StudentID]=@StudentID

exec [dbo].[PR_Student_UpdateByPK]  2,1,4,"hello2","hello2","hello2","hello2","hello2",'2011/04/06 12:23:45',3,false,"hello2","hello2"


CREATE PROCEDURE [dbo].[PR_Student_DeleteByPK] 
@StudentID int
as
delete 
from [dbo].[MST_Student]
where [dbo].[MST_Student].[StudentID]=@StudentID

exec [dbo].[PR_Student_DeleteByPK]  2 



select * from MST_Student
select * from MST_Branch



//-----------search------------


 CREATE PROCEDURE [dbo].[PR_Country_Search] "d","1"
 @CountryName varchar(50)=null,
 @CountryCode varchar(50)=null
AS
SELECT
[dbo].[LOC_Country].[CountryID]
 ,[dbo].[LOC_Country].[CountryName]
 ,[dbo].[LOC_Country].[CountryCode]
  ,[dbo].[LOC_Country].[Created]
  ,[dbo].[LOC_Country].[Modified]
FROM [dbo].[LOC_Country]
where (@CountryName is null or [dbo].[LOC_Country].[CountryName] like '%'+@CountryName+'%')
		and
		(@CountryCode is null or [dbo].[LOC_Country].[CountryCode] like '%'+@CountryCode+'%')
ORDER BY [dbo].[LOC_Country].[CountryName]




CREATE PROCEDURE [dbo].[PR_State_Search]
 @StateName varchar(50)=null,
 @StateCode varchar(50)=null
AS
SELECT
[dbo].[LOC_State].[StateID]
 ,[dbo].[LOC_State].[StateName]
 ,[dbo].[LOC_State].[StateCode]
 ,[dbo].[LOC_Country].[CountryID]
 ,[dbo].[LOC_Country].[CountryName]
  ,[dbo].[LOC_State].[Created]
    ,[dbo].[LOC_State].[Modified]
FROM [dbo].[LOC_State]
INNER JOIN [dbo].[LOC_Country]
ON [dbo].[LOC_Country].[CountryID] = [dbo].[LOC_State].[CountryID]
where (@StateName is null or [dbo].[LOC_State].[StateName] like '%'+@StateName+'%')
		and
		(@StateCode is null or [dbo].[LOC_State].[StateCode] like '%'+@StateCode+'%')
ORDER BY [dbo].[LOC_Country].[CountryName]
 ,[dbo].[LOC_State].[StateName]





CREATE PROCEDURE [dbo].[PR_City_Search]
 @CityName varchar(50)=null,
 @CityCode varchar(50)=null
AS
SELECT [dbo].[LOC_City].[CityID]
 ,[dbo].[LOC_City].[CityName]
 ,[dbo].[LOC_City].[CityCode]
 ,[dbo].[LOC_City].[StateID]
 ,[dbo].[LOC_City].[CountryID]
 ,[dbo].[LOC_State].[StateName]
 ,[dbo].[LOC_Country].[CountryName]
 ,[dbo].[LOC_City].[Created]
 ,[dbo].[LOC_City].[Modified]
FROM [dbo].[LOC_City]
INNER JOIN [dbo].[LOC_State]
ON [dbo].[LOC_State].[StateID] = [dbo].[LOC_City].[StateID]
INNER JOIN [dbo].[LOC_Country]
ON [dbo].[LOC_Country].[CountryID] = [dbo].[LOC_State].[CountryID]
where (@CityName is null or [dbo].[LOC_City].[CityName] like '%'+@CityName+'%')
		and
		(@CityCode is null or [dbo].[LOC_City].[CityCode] like '%'+@CityCode+'%')
ORDER BY [dbo].[LOC_Country].[CountryName]
 ,[dbo].[LOC_State].[StateName]
 ,[dbo].[LOC_City].[CityName]



  CREATE PROCEDURE [dbo].[PR_Branch_Search]
 @BranchName varchar(50)=null,
 @BranchCode varchar(50)=null
AS
SELECT
[dbo].[MST_Branch].[BranchID],
[dbo].[MST_Branch].[BranchName],
[dbo].[MST_Branch].[BranchCode],
[dbo].[MST_Branch].[Created],
[dbo].[MST_Branch].[Modified]
from [dbo].[MST_Branch]
where (@BranchName is null or [dbo].[MST_Branch].[BranchName] like '%'+@BranchName+'%')
		and
		(@BranchCode is null or [dbo].[MST_Branch].[BranchCode] like '%'+@BranchCode+'%')
ORDER By [dbo].[MST_Branch].[BranchName]



create PROCEDURE [dbo].[PR_Student_Search]
@StudentName varchar(50)=null,
 @BranchName varchar(50)=null
as
select
[dbo].[MST_Student].[StudentID]
,[dbo].[MST_Student].[BranchID]
,[dbo].[MST_Student].[CityID]
,[dbo].[MST_Student].[StudentName]
,[dbo].[MST_Branch].[BranchName]
,[dbo].[LOC_City].[CityName]
,[dbo].[LOC_State].[StateName]
,[dbo].[LOC_Country].[CountryName]
,[dbo].[MST_Student].[MobileNoStudent]
,[dbo].[MST_Student].[Email]
,[dbo].[MST_Student].[MobileNoFather]
,[dbo].[MST_Student].[Address]
,[dbo].[MST_Student].[BirthDate]
,[dbo].[MST_Student].[Age]
,[dbo].[MST_Student].[IsActive]
,[dbo].[MST_Student].[Gender]
,[dbo].[MST_Student].[Password]
,[dbo].[MST_Student].[Created]
,[dbo].[MST_Student].[Modified]
from [dbo].[MST_Student]
inner join [dbo].[LOC_City]
on [dbo].[MST_Student].[CityID]=[dbo].[LOC_City].[CityID]
inner join [dbo].[LOC_State]
on [dbo].[LOC_City].[StateID]=[dbo].[LOC_State].[StateID]
inner join [dbo].[LOC_Country]
on [dbo].[LOC_City].[CountryID]=[dbo].[LOC_Country].[CountryID]
inner join [dbo].[MST_Branch]
on [dbo].[MST_Student].[BranchID]=[dbo].[MST_Branch].[BranchID]
where (@BranchName is null or [dbo].[MST_Branch].[BranchName] like '%'+@BranchName+'%')
		and
		(@StudentName is null or [dbo].[MST_Student].[StudentName] like '%'+@StudentName+'%')
order by 
[dbo].[MST_Student].[StudentName]
,[dbo].[MST_Branch].[BranchName]
,[dbo].[LOC_City].[CityName]
,[dbo].[LOC_State].[StateName]
,[LOC_Country].[CountryName]