USE [StudentRegistration]
GO
/****** Object:  Table [dbo].[Course]    Script Date: 12.01.2022 09:41:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Course](
	[CourseId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NULL,
	[Code] [nvarchar](3) NULL,
 CONSTRAINT [PK_Course] PRIMARY KEY CLUSTERED 
(
	[CourseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Instructor]    Script Date: 12.01.2022 09:41:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Instructor](
	[InstructorId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](20) NULL,
	[Surname] [nvarchar](20) NULL,
	[Adress] [nvarchar](200) NULL,
	[Phone] [nvarchar](15) NULL,
	[BloodType] [nvarchar](10) NULL,
	[Email] [nvarchar](50) NULL,
	[BirthDate] [datetime] NULL,
	[EntryDate] [datetime] NULL,
	[LeavingDate] [datetime] NULL,
	[UserId] [int] NULL,
 CONSTRAINT [PK_Instructor] PRIMARY KEY CLUSTERED 
(
	[InstructorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Semester]    Script Date: 12.01.2022 09:41:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Semester](
	[SemesterId] [int] IDENTITY(1,1) NOT NULL,
	[Year] [nvarchar](12) NOT NULL,
	[SemesterType] [nvarchar](10) NOT NULL,
	[CanAddCourse] [bit] NULL,
 CONSTRAINT [PK_Semester] PRIMARY KEY CLUSTERED 
(
	[SemesterId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SemesterCourse]    Script Date: 12.01.2022 09:41:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SemesterCourse](
	[SemesterCourseId] [int] IDENTITY(1,1) NOT NULL,
	[SemesterId] [int] NOT NULL,
	[CourseId] [int] NOT NULL,
	[InstructorId] [int] NOT NULL,
 CONSTRAINT [PK_SemesterCourse] PRIMARY KEY CLUSTERED 
(
	[SemesterCourseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 12.01.2022 09:41:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[StudentId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](20) NULL,
	[Surname] [nvarchar](20) NULL,
	[Adress] [nvarchar](200) NULL,
	[Phone] [nvarchar](15) NULL,
	[BloodType] [nvarchar](10) NULL,
	[Email] [nvarchar](50) NULL,
	[BirthDate] [datetime] NULL,
	[EntryDate] [datetime] NULL,
	[LeavingDate] [datetime] NULL,
	[Gender] [nvarchar](10) NULL,
	[UserId] [int] NULL,
	[AdvisorId] [int] NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudentSemesterCourse]    Script Date: 12.01.2022 09:41:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentSemesterCourse](
	[RegisterId] [int] IDENTITY(1,1) NOT NULL,
	[SemesterCourseId] [int] NOT NULL,
	[StudentId] [int] NOT NULL,
	[Midterm1] [int] NOT NULL,
	[Midterm2] [int] NOT NULL,
	[FinalGrade] [int] NOT NULL,
	[Average] [nvarchar](5) NOT NULL,
	[SuccessStatus] [nvarchar](12) NOT NULL,
	[Status] [nvarchar](50) NULL,
 CONSTRAINT [PK_StudentSemesterCourse] PRIMARY KEY CLUSTERED 
(
	[RegisterId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 12.01.2022 09:41:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[UserType] [int] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Course] ON 

INSERT [dbo].[Course] ([CourseId], [Name], [Code]) VALUES (3, N'Test', N'wee')
INSERT [dbo].[Course] ([CourseId], [Name], [Code]) VALUES (4, N'Yeni Ders', N'YD')
SET IDENTITY_INSERT [dbo].[Course] OFF
SET IDENTITY_INSERT [dbo].[Instructor] ON 

INSERT [dbo].[Instructor] ([InstructorId], [Name], [Surname], [Adress], [Phone], [BloodType], [Email], [BirthDate], [EntryDate], [LeavingDate], [UserId]) VALUES (1, N'aaaa', N'aaa', N'0', N'1', N'3', N'2', CAST(N'2021-05-17T14:40:12.000' AS DateTime), CAST(N'2021-05-17T14:40:12.000' AS DateTime), NULL, 3)
INSERT [dbo].[Instructor] ([InstructorId], [Name], [Surname], [Adress], [Phone], [BloodType], [Email], [BirthDate], [EntryDate], [LeavingDate], [UserId]) VALUES (2, N'Name', N'sur', N'1', N'2', N'4', N'3', CAST(N'2021-05-10T14:40:12.000' AS DateTime), CAST(N'2021-05-17T14:40:12.000' AS DateTime), NULL, 3)
SET IDENTITY_INSERT [dbo].[Instructor] OFF
SET IDENTITY_INSERT [dbo].[Semester] ON 

INSERT [dbo].[Semester] ([SemesterId], [Year], [SemesterType], [CanAddCourse]) VALUES (1, N'2020-2021', N'Fall', 0)
INSERT [dbo].[Semester] ([SemesterId], [Year], [SemesterType], [CanAddCourse]) VALUES (2, N'2020-2021', N'Spring', 0)
INSERT [dbo].[Semester] ([SemesterId], [Year], [SemesterType], [CanAddCourse]) VALUES (4, N'2021-2022', N'Fall', 1)
SET IDENTITY_INSERT [dbo].[Semester] OFF
SET IDENTITY_INSERT [dbo].[SemesterCourse] ON 

INSERT [dbo].[SemesterCourse] ([SemesterCourseId], [SemesterId], [CourseId], [InstructorId]) VALUES (1, 1, 3, 2)
INSERT [dbo].[SemesterCourse] ([SemesterCourseId], [SemesterId], [CourseId], [InstructorId]) VALUES (2, 2, 3, 2)
INSERT [dbo].[SemesterCourse] ([SemesterCourseId], [SemesterId], [CourseId], [InstructorId]) VALUES (4, 4, 3, 2)
INSERT [dbo].[SemesterCourse] ([SemesterCourseId], [SemesterId], [CourseId], [InstructorId]) VALUES (5, 4, 4, 1)
SET IDENTITY_INSERT [dbo].[SemesterCourse] OFF
SET IDENTITY_INSERT [dbo].[Student] ON 

INSERT [dbo].[Student] ([StudentId], [Name], [Surname], [Adress], [Phone], [BloodType], [Email], [BirthDate], [EntryDate], [LeavingDate], [Gender], [UserId], [AdvisorId]) VALUES (1, N'1', N'3', N'2', N'5', N'7', N'6', CAST(N'2021-05-17T15:08:28.000' AS DateTime), CAST(N'2021-05-17T15:08:28.000' AS DateTime), NULL, N'', 2, 1)
SET IDENTITY_INSERT [dbo].[Student] OFF
SET IDENTITY_INSERT [dbo].[StudentSemesterCourse] ON 

INSERT [dbo].[StudentSemesterCourse] ([RegisterId], [SemesterCourseId], [StudentId], [Midterm1], [Midterm2], [FinalGrade], [Average], [SuccessStatus], [Status]) VALUES (5, 1, 1, 0, 0, 0, N'0', N'0', N'APPROVED')
INSERT [dbo].[StudentSemesterCourse] ([RegisterId], [SemesterCourseId], [StudentId], [Midterm1], [Midterm2], [FinalGrade], [Average], [SuccessStatus], [Status]) VALUES (7, 2, 1, 0, 0, 0, N'0', N'', N'WAITING')
SET IDENTITY_INSERT [dbo].[StudentSemesterCourse] OFF
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([UserId], [UserName], [Password], [UserType]) VALUES (1, N'admin', N'admin', 0)
INSERT [dbo].[User] ([UserId], [UserName], [Password], [UserType]) VALUES (2, N'student', N'student', 1)
INSERT [dbo].[User] ([UserId], [UserName], [Password], [UserType]) VALUES (3, N'instructor', N'instructor', 2)
SET IDENTITY_INSERT [dbo].[User] OFF
ALTER TABLE [dbo].[Instructor]  WITH CHECK ADD  CONSTRAINT [FK_Instructor_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[Instructor] CHECK CONSTRAINT [FK_Instructor_User]
GO
ALTER TABLE [dbo].[SemesterCourse]  WITH CHECK ADD  CONSTRAINT [FK_SemesterCourse_Course_CourseId] FOREIGN KEY([CourseId])
REFERENCES [dbo].[Course] ([CourseId])
GO
ALTER TABLE [dbo].[SemesterCourse] CHECK CONSTRAINT [FK_SemesterCourse_Course_CourseId]
GO
ALTER TABLE [dbo].[SemesterCourse]  WITH CHECK ADD  CONSTRAINT [FK_SemesterCourse_InstructorId] FOREIGN KEY([InstructorId])
REFERENCES [dbo].[Instructor] ([InstructorId])
GO
ALTER TABLE [dbo].[SemesterCourse] CHECK CONSTRAINT [FK_SemesterCourse_InstructorId]
GO
ALTER TABLE [dbo].[SemesterCourse]  WITH CHECK ADD  CONSTRAINT [FK_SemesterCourse_Semester_SemesterId] FOREIGN KEY([SemesterId])
REFERENCES [dbo].[Semester] ([SemesterId])
GO
ALTER TABLE [dbo].[SemesterCourse] CHECK CONSTRAINT [FK_SemesterCourse_Semester_SemesterId]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Instructor] FOREIGN KEY([AdvisorId])
REFERENCES [dbo].[Instructor] ([InstructorId])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Instructor]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_User]
GO
ALTER TABLE [dbo].[StudentSemesterCourse]  WITH CHECK ADD  CONSTRAINT [FK_StudentSemesterCourse_SemesterCourse] FOREIGN KEY([SemesterCourseId])
REFERENCES [dbo].[SemesterCourse] ([SemesterCourseId])
GO
ALTER TABLE [dbo].[StudentSemesterCourse] CHECK CONSTRAINT [FK_StudentSemesterCourse_SemesterCourse]
GO
ALTER TABLE [dbo].[StudentSemesterCourse]  WITH CHECK ADD  CONSTRAINT [FK_StudentSemesterCourse_Student] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Student] ([StudentId])
GO
ALTER TABLE [dbo].[StudentSemesterCourse] CHECK CONSTRAINT [FK_StudentSemesterCourse_Student]
GO
