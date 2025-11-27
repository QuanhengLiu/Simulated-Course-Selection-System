CREATE DATABASE  [student];
GO
USE [student]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[class](
	[claid] [bigint] IDENTITY(1,1) NOT NULL,
	[claname] [varchar](30) NULL,
	[term] [varchar](30) NULL,
	[teacher] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[claid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[manager](
	[manid] [bigint] IDENTITY(1,1) NOT NULL,
	[manname] [varchar](30) NOT NULL,
	[role] [varchar](30) NULL,
	[manpasswd] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[manid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sc](
	[scid] [bigint] IDENTITY(1,1) NOT NULL,
	[stuid] [bigint] NULL,
	[claid] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[scid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sctime](
	[sctimeid] [bigint] IDENTITY(1,1) NOT NULL,
	[claid] [bigint] NULL,
	[sctime] [varchar](30) NULL,
	[location] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[sctimeid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[student](
	[stuid] [bigint] IDENTITY(1,1) NOT NULL,
	[stuname] [varchar](30) NULL,
	[stuxuehao] [varchar](30) NOT NULL,
	[stupasswd] [varchar](30) NOT NULL,
	[stugrade] [varchar](30) NULL,
	[stumajor] [varchar](30) NULL,
	[stusex] [varchar](2) NULL,
	[stuborn] [varchar](30) NULL,
	[role] [varchar](30) NULL,
	[stuhometown] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[stuid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[class] ON 

INSERT [dbo].[class] ([claid], [claname], [term], [teacher]) VALUES (1, N'大学英语四级', N'2425第一学期', N'孙丹')
INSERT [dbo].[class] ([claid], [claname], [term], [teacher]) VALUES (2, N'电气技术基础', N'2324第二学期', N'袁弘良')
INSERT [dbo].[class] ([claid], [claname], [term], [teacher]) VALUES (3, N'电子学与数字技术2', N'2425第一学期', N'霍勇')
INSERT [dbo].[class] ([claid], [claname], [term], [teacher]) VALUES (4, N'机械设计基础', N'2425第一学期', N'谢春')
INSERT [dbo].[class] ([claid], [claname], [term], [teacher]) VALUES (5, N'数据库技术与应用', N'2425第一学期', N'王睿智')
INSERT [dbo].[class] ([claid], [claname], [term], [teacher]) VALUES (6, N'人工智能技术与应用', N'2425第二学期', N'王睿智')
SET IDENTITY_INSERT [dbo].[class] OFF
GO
SET IDENTITY_INSERT [dbo].[manager] ON 

INSERT [dbo].[manager] ([manid], [manname], [role], [manpasswd]) VALUES (2259999, N'clj', N'管理员', N'4321')

SET IDENTITY_INSERT [dbo].[manager] OFF
GO
SET IDENTITY_INSERT [dbo].[sc] ON 

INSERT [dbo].[sc] ([scid], [stuid], [claid]) VALUES (7, 2251115, 1)
INSERT [dbo].[sc] ([scid], [stuid], [claid]) VALUES (8, 2251115, 2)
INSERT [dbo].[sc] ([scid], [stuid], [claid]) VALUES (9, 2251115, 4)
SET IDENTITY_INSERT [dbo].[sc] OFF
GO
SET IDENTITY_INSERT [dbo].[sctime] ON 

INSERT [dbo].[sctime] ([sctimeid], [claid], [sctime], [location]) VALUES (1, 1, N'星期一第一节', N'A102')
INSERT [dbo].[sctime] ([sctimeid], [claid], [sctime], [location]) VALUES (2, 1, N'星期一第二节', N'A102')
INSERT [dbo].[sctime] ([sctimeid], [claid], [sctime], [location]) VALUES (3, 2, N'星期一第三节', N'B102')
INSERT [dbo].[sctime] ([sctimeid], [claid], [sctime], [location]) VALUES (4, 3, N'星期一第一节', N'A104')
INSERT [dbo].[sctime] ([sctimeid], [claid], [sctime], [location]) VALUES (5, 3, N'星期一第二节', N'A104')
INSERT [dbo].[sctime] ([sctimeid], [claid], [sctime], [location]) VALUES (6, 4, N'星期三第一节', N'B102')
INSERT [dbo].[sctime] ([sctimeid], [claid], [sctime], [location]) VALUES (7, 4, N'星期三第二节', N'B102')
INSERT [dbo].[sctime] ([sctimeid], [claid], [sctime], [location]) VALUES (8, 5, N'星期一第一节', N'A203')
INSERT [dbo].[sctime] ([sctimeid], [claid], [sctime], [location]) VALUES (9, 5, N'星期一第二节', N'A203')
INSERT [dbo].[sctime] ([sctimeid], [claid], [sctime], [location]) VALUES (10, 6, N'星期一第三节', N'A103')
INSERT [dbo].[sctime] ([sctimeid], [claid], [sctime], [location]) VALUES (11, 6, N'星期一第四节', N'A103')
SET IDENTITY_INSERT [dbo].[sctime] OFF
GO
SET IDENTITY_INSERT [dbo].[student] ON 

INSERT [dbo].[student] ([stuid], [stuname], [stuxuehao], [stupasswd], [stugrade], [stumajor], [stusex], [stuborn], [role], [stuhometown]) VALUES (1, N'刘荃亨', N'2251115', N'1234', N'大三', N'中德机械电子', N'男', N'2024-09-01', N'学生', N'天只因')
INSERT [dbo].[student] ([stuid], [stuname], [stuxuehao], [stupasswd], [stugrade], [stumajor], [stusex], [stuborn], [role], [stuhometown]) VALUES (2, N'赵建峰', N'2253465', N'1234', N'大三', N'中德经济工程', N'男', N'2024-09-01', N'学生', N'张掖')
INSERT [dbo].[student] ([stuid], [stuname], [stuxuehao], [stupasswd], [stugrade], [stumajor], [stusex], [stuborn], [role], [stuhometown]) VALUES (3, N'王浩喻', N'2253132', N'1234', N'大三', N'中德汽车服务', N'男', N'2024-09-01', N'学生', N'坤明')

SET IDENTITY_INSERT [dbo].[student] OFF
GO
SET ANSI_PADDING ON
GO
ALTER TABLE [dbo].[manager] ADD UNIQUE NONCLUSTERED 
(
	[manname] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
ALTER TABLE [dbo].[student] ADD UNIQUE NONCLUSTERED 
(
	[stuxuehao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[manager] ADD  DEFAULT ('管理员') FOR [role]
GO
ALTER TABLE [dbo].[student] ADD  DEFAULT ('男') FOR [stusex]
GO
ALTER TABLE [dbo].[student] ADD  DEFAULT ('学生') FOR [role]
GO
ALTER TABLE [dbo].[sc]  WITH CHECK ADD  CONSTRAINT [scc_id] FOREIGN KEY([claid])
REFERENCES [dbo].[class] ([claid])
GO
ALTER TABLE [dbo].[sc] CHECK CONSTRAINT [scc_id]
GO
ALTER TABLE [dbo].[sc]  WITH CHECK ADD  CONSTRAINT [ssc_id] FOREIGN KEY([stuid])
REFERENCES [dbo].[student] ([stuid])
GO
ALTER TABLE [dbo].[sc] CHECK CONSTRAINT [ssc_id]
GO
ALTER TABLE [dbo].[sctime]  WITH CHECK ADD  CONSTRAINT [csctime_id] FOREIGN KEY([claid])
REFERENCES [dbo].[class] ([claid])
GO
ALTER TABLE [dbo].[sctime] CHECK CONSTRAINT [csctime_id]
GO
