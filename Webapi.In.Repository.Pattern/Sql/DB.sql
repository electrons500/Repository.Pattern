
CREATE DATABASE [EmployeeDB]
GO

USE [EmployeeDB]
GO

CREATE TABLE [dbo].[Employee](
	[EmployeeId] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeName] [varchar](200) NOT NULL,
	[City] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[EmployeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

---Data----
INSERT [dbo].[Employee] ([EmployeeId], [EmployeeName], [City]) VALUES (1, N'Kwame Nkrumah', N'Nkroful')
GO
INSERT [dbo].[Employee] ([EmployeeId], [EmployeeName], [City]) VALUES (3, N'Richard Mensah', N'Accra')
GO
