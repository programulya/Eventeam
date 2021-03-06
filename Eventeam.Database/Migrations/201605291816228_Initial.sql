/****** Object:  Database [Eventeam]    Script Date: 5/29/2016 5:57:36 PM ******/

/****** Object:  Schema [Hall]    Script Date: 5/29/2016 5:57:36 PM ******/
CREATE SCHEMA [Hall]
GO
/****** Object:  Schema [Hotel]    Script Date: 5/29/2016 5:57:36 PM ******/
CREATE SCHEMA [Hotel]
GO
/****** Object:  Schema [NonStandard]    Script Date: 5/29/2016 5:57:36 PM ******/
CREATE SCHEMA [NonStandard]
GO
/****** Object:  Schema [Portfolio]    Script Date: 5/29/2016 5:57:36 PM ******/
CREATE SCHEMA [Portfolio]
GO
/****** Object:  Schema [Restaurant]    Script Date: 5/29/2016 5:57:36 PM ******/
CREATE SCHEMA [Restaurant]
GO
/****** Object:  Table [dbo].[City]    Script Date: 5/29/2016 5:57:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[City](
	[CityID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_City] PRIMARY KEY CLUSTERED 
(
	[CityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Level]    Script Date: 5/29/2016 5:57:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Level](
	[LevelID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [int] NOT NULL,
 CONSTRAINT [PK_Level] PRIMARY KEY CLUSTERED 
(
	[LevelID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Location]    Script Date: 5/29/2016 5:57:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Location](
	[LocationID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_Location] PRIMARY KEY CLUSTERED 
(
	[LocationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Platform]    Script Date: 5/29/2016 5:57:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Platform](
	[PlatformID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
	[FolderName] [nvarchar](200) NOT NULL,
	[CityID] [int] NOT NULL,
	[LevelID] [int] NOT NULL,
	[LocationID] [int] NOT NULL,
	[Geography] [geography] NOT NULL,
	[Address] [nvarchar](1000) NOT NULL,
	[Subway] [nvarchar](500) NULL,
	[DistanceRailwayStation] [float] NULL,
	[DistanceAirportBorispil] [float] NULL,
	[DistanceAirportZhulyany] [float] NULL,
	[Site] [nvarchar](500) NULL,
	[HallsCount] [int] NULL,
	[HallCapacity] [int] NULL,
	[RestaurantsCount] [int] NULL,
	[BanquetCapacity] [int] NULL,
	[BuffetCapacity] [int] NULL,
 CONSTRAINT [PK_Platform] PRIMARY KEY CLUSTERED 
(
	[PlatformID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [Hall].[Hall]    Script Date: 5/29/2016 5:57:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Hall].[Hall](
	[HallID] [int] IDENTITY(1,1) NOT NULL,
	[PlatformID] [int] NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
	[FolderName] [nvarchar](200) NOT NULL,
	[TotalSquare] [int] NULL,
	[Theater] [int] NULL,
	[Class] [int] NULL,
	[PPlanting] [int] NULL,
	[MeetingRoom] [int] NULL,
	[Banquet] [int] NULL,
	[Buffet] [int] NULL,
	[Equipment] [nvarchar](max) NULL,
 CONSTRAINT [PK_Hall] PRIMARY KEY CLUSTERED 
(
	[HallID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [Hotel].[Hotel]    Script Date: 5/29/2016 5:57:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Hotel].[Hotel](
	[HotelID] [int] IDENTITY(1,1) NOT NULL,
	[PlatformID] [int] NOT NULL,
	[HotelCategoryID] [int] NULL,
	[Name] [nvarchar](200) NOT NULL,
	[FolderName] [nvarchar](200) NOT NULL,
	[Site] [nvarchar](200) NULL,
	[RoomCount] [int] NULL,
	[Capacity] [int] NULL,
	[Entertainment] [nvarchar](max) NULL,
	[Rehabilitation] [nvarchar](max) NULL,
	[Parking] [nvarchar](max) NULL,
	[Internet] [nvarchar](max) NULL,
	[Other] [nvarchar](max) NULL,
 CONSTRAINT [PK_Hotel] PRIMARY KEY CLUSTERED 
(
	[HotelID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [Hotel].[HotelCategory]    Script Date: 5/29/2016 5:57:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Hotel].[HotelCategory](
	[HotelCategoryID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [int] NOT NULL,
 CONSTRAINT [PK_HotelCategory] PRIMARY KEY CLUSTERED 
(
	[HotelCategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [Hotel].[Room]    Script Date: 5/29/2016 5:57:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Hotel].[Room](
	[RoomID] [int] IDENTITY(1,1) NOT NULL,
	[HotelID] [int] NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
	[RoomCategoryID] [int] NOT NULL,
	[RoomTypeID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_Room] PRIMARY KEY CLUSTERED 
(
	[RoomID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [Hotel].[RoomCategory]    Script Date: 5/29/2016 5:57:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Hotel].[RoomCategory](
	[RoomCategoryID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_RoomCategory] PRIMARY KEY CLUSTERED 
(
	[RoomCategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [Hotel].[RoomType]    Script Date: 5/29/2016 5:57:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Hotel].[RoomType](
	[TypeID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_Type] PRIMARY KEY CLUSTERED 
(
	[TypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [NonStandard].[NonStandardType]    Script Date: 5/29/2016 5:57:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [NonStandard].[NonStandardType](
	[TypeID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_Type] PRIMARY KEY CLUSTERED 
(
	[TypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [Portfolio].[Format]    Script Date: 5/29/2016 5:57:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Portfolio].[Format](
	[FormatID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_Format] PRIMARY KEY CLUSTERED 
(
	[FormatID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [Portfolio].[Portfolio]    Script Date: 5/29/2016 5:57:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Portfolio].[Portfolio](
	[PortfolioID] [int] IDENTITY(1,1) NOT NULL,
	[FolderName] [nvarchar](200) NOT NULL,
	[ProjectName] [nvarchar](200) NOT NULL,
	[FormatID] [int] NOT NULL,
	[Сustomer] [nvarchar](200) NOT NULL,
	[Participants] [nvarchar](200) NOT NULL,
	[Location] [nvarchar](200) NOT NULL,
	[Task] [nvarchar](max) NOT NULL,
	[Implementation] [nvarchar](max) NOT NULL,
	[Result] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Portfolio] PRIMARY KEY CLUSTERED 
(
	[PortfolioID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [Restaurant].[Classification]    Script Date: 5/29/2016 5:57:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Restaurant].[Classification](
	[ClassificationID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_Classification] PRIMARY KEY CLUSTERED 
(
	[ClassificationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [Restaurant].[Kitchen]    Script Date: 5/29/2016 5:57:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Restaurant].[Kitchen](
	[KitchenID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_Kitchen] PRIMARY KEY CLUSTERED 
(
	[KitchenID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [Restaurant].[Restaurant]    Script Date: 5/29/2016 5:57:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Restaurant].[Restaurant](
	[RestaurantID] [int] IDENTITY(1,1) NOT NULL,
	[PlatformID] [int] NOT NULL,
	[TypeID] [int] NOT NULL,
	[ClassificationID] [int] NULL,
	[KitchenID] [int] NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
	[FolderName] [nvarchar](200) NOT NULL,
	[Banquet] [int] NULL,
	[Buffet] [int] NULL,
	[TotalSquare] [int] NULL,
	[Seating] [int] NULL,
 CONSTRAINT [PK_Restaurant] PRIMARY KEY CLUSTERED 
(
	[RestaurantID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [Restaurant].[RestaurantType]    Script Date: 5/29/2016 5:57:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Restaurant].[RestaurantType](
	[TypeId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_Type_1] PRIMARY KEY CLUSTERED 
(
	[TypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Simple Data ******/

SET IDENTITY_INSERT [dbo].[City] ON 
INSERT [dbo].[City] ([CityID], [Name]) VALUES (1, N'Винница')
INSERT [dbo].[City] ([CityID], [Name]) VALUES (2, N'Днепропетровск')
INSERT [dbo].[City] ([CityID], [Name]) VALUES (3, N'Житомир')
INSERT [dbo].[City] ([CityID], [Name]) VALUES (4, N'Киев')
INSERT [dbo].[City] ([CityID], [Name]) VALUES (5, N'Львов')
INSERT [dbo].[City] ([CityID], [Name]) VALUES (6, N'Одесса')
INSERT [dbo].[City] ([CityID], [Name]) VALUES (7, N'Полтава')
INSERT [dbo].[City] ([CityID], [Name]) VALUES (8, N'Ровно')
INSERT [dbo].[City] ([CityID], [Name]) VALUES (9, N'Сумы')
INSERT [dbo].[City] ([CityID], [Name]) VALUES (10, N'Харьков')
SET IDENTITY_INSERT [dbo].[City] OFF

SET IDENTITY_INSERT [dbo].[Level] ON 
INSERT [dbo].[Level] ([LevelID], [Name]) VALUES (1, 1)
INSERT [dbo].[Level] ([LevelID], [Name]) VALUES (2, 2)
INSERT [dbo].[Level] ([LevelID], [Name]) VALUES (3, 3)
INSERT [dbo].[Level] ([LevelID], [Name]) VALUES (4, 4)
INSERT [dbo].[Level] ([LevelID], [Name]) VALUES (5, 5)
SET IDENTITY_INSERT [dbo].[Level] OFF

SET IDENTITY_INSERT [dbo].[Location] ON 
INSERT [dbo].[Location] ([LocationID], [Name]) VALUES (1, N'В центре')
INSERT [dbo].[Location] ([LocationID], [Name]) VALUES (2, N'Возле метро')
INSERT [dbo].[Location] ([LocationID], [Name]) VALUES (3, N'За городом')
SET IDENTITY_INSERT [dbo].[Location] OFF

SET IDENTITY_INSERT [dbo].[Platform] ON 
INSERT [dbo].[Platform] ([PlatformID], [Name], [FolderName], [CityID], [LevelID], [LocationID], [Geography], [Address], [Subway], [DistanceRailwayStation], [DistanceAirportBorispil], [DistanceAirportZhulyany], [Site], [HallsCount], [HallCapacity], [RestaurantsCount], [BanquetCapacity], [BuffetCapacity]) VALUES (1, N'Казацкий Стан', N'kazatskiyStan', 4, 1, 2, 0xE6100000010C8716D9CEF7D34740D7A3703D0A975EC0, N'Бориспольское шоссе, 18-й км', N'Бориспольская - 1.3 км', 17.9, 20.4, 20.1, N'http://www.kstan.com.ua', 6, 220, 5, 250, NULL)
INSERT [dbo].[Platform] ([PlatformID], [Name], [FolderName], [CityID], [LevelID], [LocationID], [Geography], [Address], [Subway], [DistanceRailwayStation], [DistanceAirportBorispil], [DistanceAirportZhulyany], [Site], [HallsCount], [HallCapacity], [RestaurantsCount], [BanquetCapacity], [BuffetCapacity]) VALUES (2, N'Grand Admiral Resort & SPA', N'admiralClub', 4, 4, 3, 0xE6100000010C54E23AC61545494003B16CE690443E40, N'ул. Советская, 116, г. Ирпень', NULL, 25.8, 60.8, 28.8, N'http://admiralclub.com.ua', 3, 200, 7, 120, NULL)
SET IDENTITY_INSERT [dbo].[Platform] OFF

SET IDENTITY_INSERT [Hall].[Hall] ON 
INSERT [Hall].[Hall] ([HallID], [PlatformID], [Name], [FolderName], [TotalSquare], [Theater], [Class], [PPlanting], [MeetingRoom], [Banquet], [Buffet], [Equipment]) VALUES (1, 1, N'Конференц-зал «Европейский»', N'hallEuro', 242, 220, 120, 65, 70, 150, 200, N'Кондиционер, бесплатный Wi-Fi. Конференц-оборудование оплачивается дополнительно.')
SET IDENTITY_INSERT [Hall].[Hall] OFF

SET IDENTITY_INSERT [Hotel].[Hotel] ON 
INSERT [Hotel].[Hotel] ([HotelID], [PlatformID], [HotelCategoryID], [Name], [FolderName], [Site], [RoomCount], [Capacity], [Entertainment], [Rehabilitation], [Parking], [Internet], [Other]) VALUES (2, 1, 4, N'Казацкий Стан', N'kazatskiyStan', N'http://www.kstan.com.ua', 64, 153, N'Бильярд', N'Сауна, бассейн, SPA', N'Частная, на территории, бесплатно', N'Wi-Fi, по всему комплексу, бесплатно', N'Сейф, банкомат, камера хранения багажа, прачечная, глажка одежды, чистка обуви, бизнес-центр, ксерокс/факс, доставка еды/напитков в номер, барбекю, детская игровая площадка, места для курения, индивидуальная регистрация')
INSERT [Hotel].[Hotel] ([HotelID], [PlatformID], [HotelCategoryID], [Name], [FolderName], [Site], [RoomCount], [Capacity], [Entertainment], [Rehabilitation], [Parking], [Internet], [Other]) VALUES (3, 2, 4, N'Grand Admiral Resort & SPA', N'admiralClub', N'http://admiralclub.com.ua', 68, 140, N'Теннисный центр и спортивные площадки
Конные прогулки
Рыбалка на озере
Квадроциклы, сегвеи, миникары и веломобили
Веревочный парк «Лазалка»
Тир
Боулинг и бильярд
Пейнтбол и лазертаг
Аттракцион «Танковый бой»
Пинг-понг
Горка «Адреналин»
Аэрохоккей
Аттракцион Angry Birds
Уличные шахматы', N'3 бассейна, комплекс бань и саун, SPA-кабинеты, тренажерный зал, зал групповых занятий', N'Охраняемая парковка на территории', N'Свободный доступ к Wi-Fi по всей территории', N'Пакетные предложения по проживанию, ресторанные залы и летние террасы, интересные тематические мероприятия на протяжении всего года, детская площадка и детская комната, анимация выходного дня для детей и взрослых, admiral Kids Club, SPA-программы различной продолжительности, банкетные и конференц-залы, организация мероприятий «под ключ», колесный парк, открытые бассейны, разнообразные аттракционы, рыбалка и конные прогулки')
SET IDENTITY_INSERT [Hotel].[Hotel] OFF

SET IDENTITY_INSERT [Hotel].[HotelCategory] ON 
INSERT [Hotel].[HotelCategory] ([HotelCategoryID], [Name]) VALUES (1, 1)
INSERT [Hotel].[HotelCategory] ([HotelCategoryID], [Name]) VALUES (2, 2)
INSERT [Hotel].[HotelCategory] ([HotelCategoryID], [Name]) VALUES (3, 3)
INSERT [Hotel].[HotelCategory] ([HotelCategoryID], [Name]) VALUES (4, 4)
INSERT [Hotel].[HotelCategory] ([HotelCategoryID], [Name]) VALUES (5, 5)
SET IDENTITY_INSERT [Hotel].[HotelCategory] OFF

SET IDENTITY_INSERT [Hotel].[Room] ON 
INSERT [Hotel].[Room] ([RoomID], [HotelID], [Name], [RoomCategoryID], [RoomTypeID], [Quantity]) VALUES (7, 2, N'Одноместный - односпальная кровать', 13, 2, 5)
INSERT [Hotel].[Room] ([RoomID], [HotelID], [Name], [RoomCategoryID], [RoomTypeID], [Quantity]) VALUES (8, 2, N'Двухместный - двуспальная кровать', 1, 4, 19)
INSERT [Hotel].[Room] ([RoomID], [HotelID], [Name], [RoomCategoryID], [RoomTypeID], [Quantity]) VALUES (10, 2, N'Твин - две односпальные кровати', 2, 6, 32)
INSERT [Hotel].[Room] ([RoomID], [HotelID], [Name], [RoomCategoryID], [RoomTypeID], [Quantity]) VALUES (11, 2, N'Полулюкс', 7, 4, 6)
INSERT [Hotel].[Room] ([RoomID], [HotelID], [Name], [RoomCategoryID], [RoomTypeID], [Quantity]) VALUES (12, 2, N'Люкс', 8, 4, 2)
INSERT [Hotel].[Room] ([RoomID], [HotelID], [Name], [RoomCategoryID], [RoomTypeID], [Quantity]) VALUES (13, 2, N'СПА-домик (в доме 3 номера)', 12, 8, 1)
INSERT [Hotel].[Room] ([RoomID], [HotelID], [Name], [RoomCategoryID], [RoomTypeID], [Quantity]) VALUES (14, 2, N'Домик 1/2 (в доме 2 номера)', 12, 8, 2)
INSERT [Hotel].[Room] ([RoomID], [HotelID], [Name], [RoomCategoryID], [RoomTypeID], [Quantity]) VALUES (15, 2, N'Домик 3 (2-этажный)', 12, 8, 1)
INSERT [Hotel].[Room] ([RoomID], [HotelID], [Name], [RoomCategoryID], [RoomTypeID], [Quantity]) VALUES (16, 2, N'Домик 4 (с сауной и бассейном)', 12, 8, 1)
INSERT [Hotel].[Room] ([RoomID], [HotelID], [Name], [RoomCategoryID], [RoomTypeID], [Quantity]) VALUES (17, 2, N'Охотничий домик', 12, 8, 1)
INSERT [Hotel].[Room] ([RoomID], [HotelID], [Name], [RoomCategoryID], [RoomTypeID], [Quantity]) VALUES (18, 2, N'Панская хата (2 комнаты, сауна, комната отдыха, ванная)', 12, 8, 1)
INSERT [Hotel].[Room] ([RoomID], [HotelID], [Name], [RoomCategoryID], [RoomTypeID], [Quantity]) VALUES (19, 2, N'Хатка 1/2/3', 12, 8, 3)
INSERT [Hotel].[Room] ([RoomID], [HotelID], [Name], [RoomCategoryID], [RoomTypeID], [Quantity]) VALUES (20, 3, N'Альпийская деревня Полулюкс', 7, 4, 6)
INSERT [Hotel].[Room] ([RoomID], [HotelID], [Name], [RoomCategoryID], [RoomTypeID], [Quantity]) VALUES (21, 3, N'Альпийская деревня Полулюкс', 7, 6, 18)
INSERT [Hotel].[Room] ([RoomID], [HotelID], [Name], [RoomCategoryID], [RoomTypeID], [Quantity]) VALUES (23, 3, N'Альпийская деревня Люкс', 8, 4, 8)
INSERT [Hotel].[Room] ([RoomID], [HotelID], [Name], [RoomCategoryID], [RoomTypeID], [Quantity]) VALUES (25, 3, N'Основное здание Стандарт', 3, 8, 18)
INSERT [Hotel].[Room] ([RoomID], [HotelID], [Name], [RoomCategoryID], [RoomTypeID], [Quantity]) VALUES (27, 3, N'Основное здание Бизнес', 7, 4, 9)
INSERT [Hotel].[Room] ([RoomID], [HotelID], [Name], [RoomCategoryID], [RoomTypeID], [Quantity]) VALUES (30, 3, N'Основное здание Бизнес', 7, 6, 3)
INSERT [Hotel].[Room] ([RoomID], [HotelID], [Name], [RoomCategoryID], [RoomTypeID], [Quantity]) VALUES (31, 3, N'Коттеджный', 12, 4, 8)
INSERT [Hotel].[Room] ([RoomID], [HotelID], [Name], [RoomCategoryID], [RoomTypeID], [Quantity]) VALUES (33, 3, N'Сосновый дом', 12, 10, 1)
SET IDENTITY_INSERT [Hotel].[Room] OFF

SET IDENTITY_INSERT [Hotel].[RoomCategory] ON
INSERT [Hotel].[RoomCategory] ([RoomCategoryID], [Name]) VALUES (1, N'Стандарт Dbl')
INSERT [Hotel].[RoomCategory] ([RoomCategoryID], [Name]) VALUES (2, N'Стандарт Twin')
INSERT [Hotel].[RoomCategory] ([RoomCategoryID], [Name]) VALUES (3, N'Стандарт Dbl/Twin')
INSERT [Hotel].[RoomCategory] ([RoomCategoryID], [Name]) VALUES (4, N'Улучшенный Dbl')
INSERT [Hotel].[RoomCategory] ([RoomCategoryID], [Name]) VALUES (5, N'Улучшенный Twin')
INSERT [Hotel].[RoomCategory] ([RoomCategoryID], [Name]) VALUES (6, N'Улучшенный Dbl/Twin')
INSERT [Hotel].[RoomCategory] ([RoomCategoryID], [Name]) VALUES (7, N'Полулюкс')
INSERT [Hotel].[RoomCategory] ([RoomCategoryID], [Name]) VALUES (8, N'Люкс')
INSERT [Hotel].[RoomCategory] ([RoomCategoryID], [Name]) VALUES (9, N'Дуплекс')
INSERT [Hotel].[RoomCategory] ([RoomCategoryID], [Name]) VALUES (10, N'Апартамент')
INSERT [Hotel].[RoomCategory] ([RoomCategoryID], [Name]) VALUES (11, N'Президентский')
INSERT [Hotel].[RoomCategory] ([RoomCategoryID], [Name]) VALUES (12, N'Другое')
INSERT [Hotel].[RoomCategory] ([RoomCategoryID], [Name]) VALUES (13, N'Стандарт Sgl')
SET IDENTITY_INSERT [Hotel].[RoomCategory] OFF

SET IDENTITY_INSERT [Hotel].[RoomType] ON
INSERT [Hotel].[RoomType] ([TypeID], [Name]) VALUES (1, N'SGL')
INSERT [Hotel].[RoomType] ([TypeID], [Name]) VALUES (2, N'SGL+ExB')
INSERT [Hotel].[RoomType] ([TypeID], [Name]) VALUES (3, N'DBL')
INSERT [Hotel].[RoomType] ([TypeID], [Name]) VALUES (4, N'DBL+ExB')
INSERT [Hotel].[RoomType] ([TypeID], [Name]) VALUES (5, N'TWIN')
INSERT [Hotel].[RoomType] ([TypeID], [Name]) VALUES (6, N'TWIN+ExB')
INSERT [Hotel].[RoomType] ([TypeID], [Name]) VALUES (7, N'DBL/TWIN')
INSERT [Hotel].[RoomType] ([TypeID], [Name]) VALUES (8, N'DBL/TWIN+ExB')
INSERT [Hotel].[RoomType] ([TypeID], [Name]) VALUES (9, N'DBL+TWIN')
INSERT [Hotel].[RoomType] ([TypeID], [Name]) VALUES (10, N'DBL+TWIN+ExB')
INSERT [Hotel].[RoomType] ([TypeID], [Name]) VALUES (11, N'DBL+DBL/TWIN')
INSERT [Hotel].[RoomType] ([TypeID], [Name]) VALUES (12, N'DBL+DBL/TWIN')
INSERT [Hotel].[RoomType] ([TypeID], [Name]) VALUES (13, N'DBL+DBL/TWIN+ExB')
INSERT [Hotel].[RoomType] ([TypeID], [Name]) VALUES (14, N'DBL+DBL')
INSERT [Hotel].[RoomType] ([TypeID], [Name]) VALUES (15, N'DBL+DBL+ExB')
INSERT [Hotel].[RoomType] ([TypeID], [Name]) VALUES (16, N'TWIN+TWIN')
INSERT [Hotel].[RoomType] ([TypeID], [Name]) VALUES (17, N'TWIN+TWIN+ExB')
SET IDENTITY_INSERT [Hotel].[RoomType] OFF

SET IDENTITY_INSERT [NonStandard].[NonStandardType] ON
INSERT [NonStandard].[NonStandardType] ([TypeID], [Name]) VALUES (1, N'Теплоход')
INSERT [NonStandard].[NonStandardType] ([TypeID], [Name]) VALUES (2, N'Планетарий')
INSERT [NonStandard].[NonStandardType] ([TypeID], [Name]) VALUES (3, N'Кинотеатр')
INSERT [NonStandard].[NonStandardType] ([TypeID], [Name]) VALUES (4, N'Tеатр')
INSERT [NonStandard].[NonStandardType] ([TypeID], [Name]) VALUES (5, N'Филармония')
INSERT [NonStandard].[NonStandardType] ([TypeID], [Name]) VALUES (6, N'Галерея')
INSERT [NonStandard].[NonStandardType] ([TypeID], [Name]) VALUES (7, N'Музей')
INSERT [NonStandard].[NonStandardType] ([TypeID], [Name]) VALUES (8, N'Парк')
INSERT [NonStandard].[NonStandardType] ([TypeID], [Name]) VALUES (9, N'Завод')
INSERT [NonStandard].[NonStandardType] ([TypeID], [Name]) VALUES (10, N'Ресторан на крыше')
INSERT [NonStandard].[NonStandardType] ([TypeID], [Name]) VALUES (11, N'Ресторан в небе')
INSERT [NonStandard].[NonStandardType] ([TypeID], [Name]) VALUES (12, N'Гостиница на воде')
INSERT [NonStandard].[NonStandardType] ([TypeID], [Name]) VALUES (13, N'Трамвай')
INSERT [NonStandard].[NonStandardType] ([TypeID], [Name]) VALUES (14, N'Винный погреб')
INSERT [NonStandard].[NonStandardType] ([TypeID], [Name]) VALUES (15, N'Аэродром')
INSERT [NonStandard].[NonStandardType] ([TypeID], [Name]) VALUES (16, N'Полигон')
INSERT [NonStandard].[NonStandardType] ([TypeID], [Name]) VALUES (17, N'Бункер')
INSERT [NonStandard].[NonStandardType] ([TypeID], [Name]) VALUES (18, N'Лофт')
INSERT [NonStandard].[NonStandardType] ([TypeID], [Name]) VALUES (19, N'Замок')
INSERT [NonStandard].[NonStandardType] ([TypeID], [Name]) VALUES (20, N'Шатер')
INSERT [NonStandard].[NonStandardType] ([TypeID], [Name]) VALUES (21, N'Веранда')
INSERT [NonStandard].[NonStandardType] ([TypeID], [Name]) VALUES (22, N'Пляжный клуб')
INSERT [NonStandard].[NonStandardType] ([TypeID], [Name]) VALUES (23, N'Гольф-клуб')
INSERT [NonStandard].[NonStandardType] ([TypeID], [Name]) VALUES (24, N'Яхт-клуб')
INSERT [NonStandard].[NonStandardType] ([TypeID], [Name]) VALUES (25, N'Бильярд')
INSERT [NonStandard].[NonStandardType] ([TypeID], [Name]) VALUES (26, N'Картинг')
INSERT [NonStandard].[NonStandardType] ([TypeID], [Name]) VALUES (27, N'Теннисный корт')
INSERT [NonStandard].[NonStandardType] ([TypeID], [Name]) VALUES (28, N'Стрелковый центр')
INSERT [NonStandard].[NonStandardType] ([TypeID], [Name]) VALUES (29, N'Пейнтбол')
INSERT [NonStandard].[NonStandardType] ([TypeID], [Name]) VALUES (30, N'Скалодром')
INSERT [NonStandard].[NonStandardType] ([TypeID], [Name]) VALUES (32, N'Каток')
INSERT [NonStandard].[NonStandardType] ([TypeID], [Name]) VALUES (33, N'Аквапарк')
INSERT [NonStandard].[NonStandardType] ([TypeID], [Name]) VALUES (34, N'Бассейн')
INSERT [NonStandard].[NonStandardType] ([TypeID], [Name]) VALUES (35, N'Караоке')
SET IDENTITY_INSERT [NonStandard].[NonStandardType] OFF

SET IDENTITY_INSERT [Portfolio].[Format] ON
INSERT [Portfolio].[Format] ([FormatID], [Name]) VALUES (1, N'Фестиваль')
INSERT [Portfolio].[Format] ([FormatID], [Name]) VALUES (2, N'Организация участия в заграничных конференциях')
INSERT [Portfolio].[Format] ([FormatID], [Name]) VALUES (3, N'Съезд врачей')
INSERT [Portfolio].[Format] ([FormatID], [Name]) VALUES (4, N'Корпоративный НГ')
INSERT [Portfolio].[Format] ([FormatID], [Name]) VALUES (5, N'Воркшопы+фотоквест')
INSERT [Portfolio].[Format] ([FormatID], [Name]) VALUES (6, N'Гала-ужин')
INSERT [Portfolio].[Format] ([FormatID], [Name]) VALUES (7, N'Детский праздник')
INSERT [Portfolio].[Format] ([FormatID], [Name]) VALUES (8, N'Празднование 8 марта')
INSERT [Portfolio].[Format] ([FormatID], [Name]) VALUES (9, N'Конференция')
INSERT [Portfolio].[Format] ([FormatID], [Name]) VALUES (10, N'Корпоративный праздник')
INSERT [Portfolio].[Format] ([FormatID], [Name]) VALUES (11, N'Поощрительная поездка')
INSERT [Portfolio].[Format] ([FormatID], [Name]) VALUES (12, N'Повышение квалификации')
SET IDENTITY_INSERT [Portfolio].[Format] OFF

SET IDENTITY_INSERT [Portfolio].[Portfolio] ON
INSERT [Portfolio].[Portfolio] ([PortfolioID], [FolderName], [ProjectName], [FormatID], [Сustomer], [Participants], [Location], [Task], [Implementation], [Result]) VALUES (1, N'kanefronfest-2014', N'Канефронфест-2014', 1, N'Фармацевтическая компания', N'Врачи (урологи, нефрологи, терапевты)', N'Украина (Трускавец, Харьков, Черкасская обл.)', N'Для врачей, экспертов в области урологии, нефрологии и терапии, был запланирован ряд мероприятий на осень: конференции, воркшопы, гала-ужины, численностью 100-120 чел., в разных регионах Украины. В программу этих мероприятий Заказчик хотел включить развлекательную часть, целью которой было сделать акцент на немецком происхождении препаратов компании, поскольку Германия априори ассоциируется с качеством.', N'Мы уже делали для этой компании мероприятия с акцентом на немецком качестве. Проводили параллель между немецким качеством автомобилей, бытовой техники и т.д., и качеством препаратов данной компании. Раскрывали состав препарата, рассматривали сферы применения растительных компонентов, которые входят в его состав, и проводили мастер-класс немецкой кухни, поскольку кулинария — также одна из сфер применения этих растений. Казалось бы, что еще можно придумать… Разработано было три концепции: «Ужин чемпионов», «Формула» и «Канефронфест». Выбрана была концепция №3. Согласно книге рекордов Гиннеса, самый масштабный в мире праздник — Октоберфест, который проводится в Германии. Мы решили сделать аналог — фестиваль «Канефронфест». С порога, гостей погружали в атмосферу праздника — одевали шляпы/подтяжки/галстуки, угощали пивом и сосисками и пивом, приветствовали на фестивале «Канефронфест». Гостей ждали аттракционы, развлекательная программа, фотозона с баварскими девушками на фоне немецких пейзажей. Мастер-класс по традиционному баварскому танцу Schuhplattler (Шухплаттлер), который считается копией брачного поведения тетерева. У нас даже были пряники свои особенные, как на Октоберфесте, с брендингом «Канефронфест». Атмосферу дополнял декор — немецкие флаги и флажки на столах, шпажки с флажками Германии, логотипом компании и фестиваля (для фестиваля был разработан свой логотип), бочки, повозки, сено, бокалы и прочие концептуальные детали.', N'Первый «Канефронфест» прошел в Трускавце, в ресторане «Ellesar». Настолько успешно, что о нем говорили не только урологи, но и гинекологи, которые слышали восторженные отзывы от своих коллег на работе. Второй — в Харькове, в Kharkov Palace Hotel 5*. В Харькове, кроме развлекательной части, была конференция с приглашенным спикерами, экспертами в области урологии, с Германии и Украины. Профессор из Германии плакал от умиления, поскольку возле замка Нойшванштайн, который был изображен у нас на баннере, жил и ходил в школу, а «Октоберфест» — его любимый праздник. Третий — на курорте «Вита Парк Аквадар», в Черкасской области. Канефронфест, как мы и предполагали, стал официальным праздником и доброй традицией, которую решено поддерживать каждой осенью теперь.')
INSERT [Portfolio].[Portfolio] ([PortfolioID], [FolderName], [ProjectName], [FormatID], [Сustomer], [Participants], [Location], [Task], [Implementation], [Result]) VALUES (2, N'ERS-2014', N'Европейский конгресс отоларингологов ERS-2014', 2, N'Фармацевтическая компания', N'Лидеры мнений в области отоларингологии, профессора и врачи', N'Нидерланды, Амстердам', N'Комплексная организация участия профессоров из Украины в Европейском конгрессе отоларингологов ERS-2014 в Амстердаме: оформление виз, подбор гостиниц, ресторанов, развлечений и экскурсий, организация перелета и трансферов, бронирование и оплата, координация и сопровождение.', N'Изначально мы нашли надежного партнера в Амстердаме для чек-тура гостиниц и ресторанов, потому что по фотографиям этого сделать нельзя, отзывы не всегда релевантны, есть свои тонкости в каждой стране и в каждом городе. Максимально близко к месту проведения конференции, было два достойных варианта в рамках бюджета — Swissotel 4* и Crowne Plaza Amsterdam City Centre 4*. Первый находился через дорогу от Beurs van Berlage, где проходил конгресс, второй — в 10 минутах ходьбы. Но фокус в том, что Swissotel — это в самом центре, в оживленном квартале, где шумно и днем и ночью. Поэтому рекомендовали клиенту Crowne Plaza, который расположен тоже в центре, но в тихой улочке. Дальше мы напрямую вели переговоры с отелем, ресторанами, транспортной компанией и людьми, которые были ответственны за развлекательную и экскурсионную программу. Вели коммуникацию с организационным комитетом конгресса. Был ряд вопросов и нестандартных просьб, которые решились в нашу пользу, по итогам переговоров. Мы полностью взяли на себя также визовое сопровождение. У профессоров был сложный маршрут — несколько поездок до/после нашего конгресса в разные страны, с туристическими и бизнес-целями, поэтому нам нужно было грамотно открыть визы, на период всех поездок. Были решены вопросы со страховками для тех, кому за 75; и даже по вопросам открытия визы за сутки и нового загранпаспорта за 3 дня тоже было найдено решение. Ни одного отказа и мультивизы всем, кому запрашивали. Мы обеспечили также внутреннюю логистику — авиаперелеты, ж/д, проживание и трансферы по Украине и в Москве. Разработали туристические гиды для нашей группы, где была прописана программа, представлена гостиница и рестораны, и проложены маршруты до этих ресторанов от гостиницы и от места проведения конгресса, краткая информация про Амстердам, яркие фотографии — все самое интересное и полезное. Менеджер проекта улетел в Амстердам за 2 дня, чтобы лично пообщаться со всеми подрядчиками, обновить договоренности, сделать ревизию локаций и подготовить встречу. Авиапартнером в этом проекте для нас стал KLM. Встретили группу охапкой воздушных шаров с логотипом клиента и тортом с изображениями растений, из которых производятся их препараты. Вечером был ужин в ресторане «Christophe» — одном из самых престижных заведений Амстердама. Последующие обеды/ужины проходили в таких ресторанах как Wannemakers, Keizersgracht 238 (ресторан при отеле Pulitzer 5*), Mazzo, Cafe Loetje (лучшие стейки в Амстердаме). Для экскурсии по каналам был заказан индивидуальный кораблик, со своим капитаном, стюардом и прекрасным баром. Также была организована экскурсия в Заансе-Сханс — деревушка на окраине Амстердама, которая позиционируется как «настоящая Голландия», чем-то напоминает наше Пирогово. Сам конгресс порадовал высоким уровнем организации, интересными докладами и возможностями нетворкинга. Мы избавили профессоров от стояния в очереди — самостоятельно их зарегистрировали, и раздали готовые бейджи и материалы за обедом. Старались предупреждать все просьбы, сопровождали во все рестораны, заранее согласовывали меню, делали заказ и контролировали выдачу. Таким образом, мы смогли обеспечить тот высокий уровень сервиса, к которому привыкли гости такого уровня. Это было необходимо, потому что в Амстердаме действует принцип «американского смайла», но на деле есть проблемы со скоростью и качеством обслуживания.', N'Мы старались по-максимуму разгрузить клиента, и нам это удалось — все вопросы «куда пойти/как добраться/что выбрать/узнай/попроси/спроси, пожалуйста» решались нашим менеджером. Для гостей осталось тайной, что в Амстердаме есть проблемы с сервисом, поскольку мы их решили грамотным выбором заведений и личным контролем. Менеджер проекта оставался в Нидерландах еще 3 недели, провел чек-тур практически всех локаций, которые можно рассматривать для проведения мероприятий, и убедился, что наш выбор был самым оптимальным по соотношению цена/качество. Долго можно описывать слова искренней благодарности, которые звучали от участников поездки, и для нас являются высочайшей наградой, но, очевидно, главный показатель успешного проведения этого проекта — то, что мы получили заказы на организацию последующих мероприятий клиента. А также обращения другого бренд-менеджера этой же компании, с просьбой взяться за подготовку поездки в Италию для ТОП-менеджмента крупнейших аптечных сетей Украины.')
INSERT [Portfolio].[Portfolio] ([PortfolioID], [FolderName], [ProjectName], [FormatID], [Сustomer], [Participants], [Location], [Task], [Implementation], [Result]) VALUES (3, N'CIPP-XIII', N'Международный конгресс педиатров CIPP — XIII', 2, N'Фармацевтическая компания', N'Лидеры мнений в области педиатрии, профессора и врачи', N'Бельгия, Брюгге', N'Комплексная организация поездки: оформление виз, подбор гостиниц, ресторанов, развлечений и экскурсий, организация перелета и трансферов, бронирование и оплата, координация и сопровождение.', N'Участники поездки изъявили желание провести еще пару дней в Амстердаме, перед поездкой на конгресс в Брюгге. Мы оплатили участие в конгрессе, оформили визы, организовали перелет «Киев-Амстердам, Брюссель-Киев», из Амстердама в Брюгге заказали трансфер, так было экономически выгоднее. Подобрали гостиницу в Амстердаме и в Брюгге, договорились о специальных тарифах. Составили программу посещения ресторанов и достопримечательностей. В Амстердаме организовали частный кораблик, с очаровательным капитаном и талантливым экскурсоводом; организовали гала-ужин в ресторане Wannemakers с коллегами из Украины, которые в это время тоже были в Амстердаме на конференции; покормили знаменитой селедкой в заведении Haesje Claes Spui, которое рекомендуем для этих целей. Дальше была Бельгия. Брюгге — самый популярный и очаровательный город в этой прекрасной стране. Hotel De Orangerie, который мы выбрали, — самая очаровательная гостиница в этом городе. Это жемчужина в сети отелей Small Luxury Hotels of the World: непередаваемая атмосфера, уютный интерьер и превосходный сервис — так можно охарактеризовать это место. В 200 м от гостиницы есть греческий ресторан The Olive Tree — превосходное место для ужина. Да, специфика ресторанов в Брюгге заключается в том, что, в большинстве своем, они не работают целый день — кто до 15:00, кто после 15:00, у кого «сиеста» с 13:00 до 17:00, кто работает, но без кухни в определенные часы. Задачу предварительно с ними пообщаться и забронировать нам, как организаторам, это усложнило (на письма они отвечают редко и долго, со всеми созванивались), но на месте все оказалось намного лучше, чем в Амстердаме — если в Амстердаме даже после личной встречи могут забыть про твой резерв, и просто виновато улыбнуться, то в Брюгге, даже если они тебя никогда не видели, но сделали резерв на твое имя, столик никому не отдадут, даже за дополнительную плату. Греки удивили нас своей щедростью — после того, как наш менеджер объяснил, какие важные люди у них в гостях, они не могли остановиться в своих «комплиментах» — оливки, десерты и шампанское неожиданно приходили за наш стол, а скорость обслуживания и внимание утроились. Если в Амстердаме must have — это кораблики, селедка и район красных фонарей, то в Брюгге это катание в повозках с лошадьми, вафли и пиво. После экскурсии по городу мы организовали обед в Bierbrasserie Cambrinus, где предлагают 400 сортов пива. А вафли профессора попробовали в ресторане Gruuthuse Hof, это заведение им полюбилось больше всех. Участники поездки также посетили Брюссель, увидели писающего мальчика, писающую девочку, писающую собачку и другие достопримечательности. На конгресс, стандартно, участников зарегистрировал наш менеджер, чтобы избавить их от стояния в очереди. Прощальный ужин мы провели во французском ресторане Patrick Devos, который находится в историческом здании постройки 1300-го года и завораживает своей атмосферой — уникальное место в центре Брюгге.', N'Участники поездки были в восторге от гостиницы и тех мест, которые посетили. При том, что представитель компании-заказчика не смог поехать, наш менеджер по сопровождению взял на себя функцию окружить их заботой и вниманием, обеспечить комфортное пребывание и образцовый сервис. Очевидно, это получилось, потому что нам поручили организацию следующего мероприятия для этой группы людей.')
INSERT [Portfolio].[Portfolio] ([PortfolioID], [FolderName], [ProjectName], [FormatID], [Сustomer], [Participants], [Location], [Task], [Implementation], [Result]) VALUES (4, N'legendLviv', N'Легендарный Львов', 3, N'Bionorica', N'Врачи, 100 чел.', N'Украина, Львов', N'Организация развлекательной программы. <br/> <strong>День 1:</strong> обед, экскурсия, ужин. <br/> <strong>День 2:</strong> мастер-класс, банкет. </br><strong>День 3:</strong> обед. Логистика.', N'<strong>День 1.</strong> Обед в гостинице Citadel Inn 5*. Театрализованная экскурсия по Львову. Ужин в «Криївці», под «аккомпанимент» местных колоритных музыкантов. <br>
<strong>День 2.</strong> Мастер-класс по приготовлению шоколада. Банкет в одном из самых престижных ресторанов Львова (ресторан «Гармата», гостиница Citadel Inn 5*), с тематической развлекательной программой. <br>
<strong>День 3.</strong> Рыцарский обед в ресторане «Арсенал».', N'Заказчик доволен. Гости в восторге. Мы счастливы)')
INSERT [Portfolio].[Portfolio] ([PortfolioID], [FolderName], [ProjectName], [FormatID], [Сustomer], [Participants], [Location], [Task], [Implementation], [Result]) VALUES (5, N'europediatrics-florence', N'7th Europediatrics Congress of the European Paediatric Association (EPA) and the Union of National European Paediatric Societies and Associations (UNEPSA)', 2, N'Фармацевтическая компания', N'Лидеры мнений в области педиатрии', N'Флоренция, Италия', N'Была поставлена', N'Не подкачала', N'Порадовал')
INSERT [Portfolio].[Portfolio] ([PortfolioID], [FolderName], [ProjectName], [FormatID], [Сustomer], [Participants], [Location], [Task], [Implementation], [Result]) VALUES (6, N'belgium-2015', N'Бельгия — 2015', 11, N'Фармацевтическая компания', N'Собственники и директора аптечных сетей', N'Бельгия, Брюссель + Гент + Брюгге + Бланкенберге', N'Поставлена', N'Осуществилась', N'Превысил ожидания')
INSERT [Portfolio].[Portfolio] ([PortfolioID], [FolderName], [ProjectName], [FormatID], [Сustomer], [Participants], [Location], [Task], [Implementation], [Result]) VALUES (7, N'munich-2015', N'Мюнхен — 2015', 12, N'Фармацевтическая компания', N'Лидеры мнений в области оториноларингологии и педиатрии', N'Мюнхен, Германия', N'Для врачей, экспертов в области урологии, нерологии и терапии, был запланирован ряд мероприятий на осень: конференции, воркшопы, гала-ужины, численностью 100-120 чел., в разных регионах Украины. В программу этих мероприятий Заказчик хотел включить развлекательную часть, целью которой было сделать акцент на немецком происхождении препаратов компании, поскольку Германия априори ассоциируется с качеством.', N'Мы уже делали для этой компании мероприятия с акцентом на немецком качестве. Проводили параллель между немецким качеством автомобилей, бытовой техники и т.д., и качеством препаратов данной компании. Раскрывали состав препарата, рассматривали сферы применения растительных компонентов, которые в его составе, и проводили мастер-класс немецкой кухни, поскольку кулинария — также одна из сфер применения этих растений. Казалось бы, что еще можно придумать… Разработано было три концепции: «Ужин чемпионов», «Формула» и «Канефронфест». Выбрана была концепция №2. Согласно книге рекордов Гиннеса, самый масштабный в мире праздник — Октоберфест, который проводится в Германии. Мы решили сделать аналог — фестиваль «Канефронфест». С порога, гостей погружали в атмосферу праздника — одевали шляпы/подтяжки/галстуки, угощали пивом и сосисками и пивом, приветствовали на фестивале «Канефронфест». Гостей ждали аттракционы, развлекательная программа, фотозона с баварскими девушками на фоне немецких пейзажей. Мастер-класс по танцу Шухплахтер, который считается копией брачного поведения тетерева. У нас даже были пряники свои особенные, как на Октоберфесте, с брендингом «Канефронфест». Атмосферу дополнял декор — немецкие флаги и флажки на столах, шпажки с флажками Германии, логотипом компании и фестиваля (для фестиваля был разработан свой логотип), бочки, повозки, сено, бокалы и прочие концептуальные детали.', N'Первый «Канефронфест» прошел в Трускавце, в ресторане «Ellesar». Настолько успешно, что о нем говорили не только урологи, но и гинекологи, которые слышали восторженные отзывы от своих коллег на работе. Второй — в Харькове, в Kharkov Palace Hotel 5*. В Харькове, кроме развлекательной части, была конференция с приглашенным спикерами, экспертами в области урологии, с Германии и Украины. Профессор из Германии плакал от умиления, поскольку возле замка Нойшванштайн, который был изображен у нас на баннере, жил и ходил в школу, а «Октоберфест» — его любимый праздник. Третий — на курорте «Вита Парк Аквадар», в Черкасской области. Канефронфест, как мы и предполагали, стал официальным праздником и доброй традицией, которую решено поддерживать каждой осенью теперь.')
INSERT [Portfolio].[Portfolio] ([PortfolioID], [FolderName], [ProjectName], [FormatID], [Сustomer], [Participants], [Location], [Task], [Implementation], [Result]) VALUES (8, N'eau-madrid-2015', N'30th Annual Congress of the European Association of Urology', 2, N'Фармацевтическая компания', N'Лидеры мнений в области урологии', N'Испания, Мадрид', N'Комплексная организация участия профессоров из Украины в 30-м ежегодном конгрессе Европейской ассоциации урологов и сопровождение.', N'Регистрация, оплата оргвзносов. Оформление виз. Подбор гостиницы. По соотношению цена/качество/месторасположение, была выбрана гостиница Villa Real Madrid 5*. Организация внешних и внутренних авиаперелетов и трансферов. Составление экскурсионной и развлекательной программы. Бронирование ресторанов, согласование меню. Это стандартные вехи подготовки к проекту.
Создание эксклюзивного информационного буклета с информацией о стране, городе, гостинице, в которой будут жить участники, с ресторанами, которые им предстоит посетить, достопримечательностями, которые они смогут увидеть, картами с маршрутом до этих мест от гостиницы и от конгресса, с подробным таймингом пребывания, контактами и другой полезной информацией. Это наша инициатива, которая очень нравится участникам, и без чего теперь не обходится ни один проект.
Но самое главное — сопровождение. Наш менеджер прилетел в Мадрид на 3 дня раньше. Проверил все рестораны, проложил маршруты, зарегистрировал учасников и получил бейджи на них еще за день до начала конгресса. В день прибытия, проверил номера в гостинице, предназначенные для наших гостей, договорился за ранний чек-ин, лично встретил делегацию украинских профессоров в аэропорту, и не расставался с ними до конца проекта, чтобы решать любые вопросы и спонтанные просьбы врачей, потому что обычно они сыпятся на голову представителю Фармкомпании.', N'О результате пускай говорят факты: 1) в течении трех месяцев после проекта, к нам обратилось 2 профессора, из числа участников, с просьбой организовать для них поездку; 2) со следующими своими поездками они тоже обратились к нам;) 3) нам поручили организацию такой же поездки для гинекологов 19-23 мая 2015 г. (EMAS-2015, Madrid).')
INSERT [Portfolio].[Portfolio] ([PortfolioID], [FolderName], [ProjectName], [FormatID], [Сustomer], [Participants], [Location], [Task], [Implementation], [Result]) VALUES (9, N'european-orl-hns-prague', N'III Международном конгрессе оториноларингологов European ORL-HNS (Прага, 2015 г.)', 2, N'Фармацевтическая компания', N'Лидеры мнений в области оториноларингологии', N'Чехия, Прага', N'Комплексная организация участия профессоров из Украины в III Международном конгрессе оториноларингологов European ORL-HNS в Праге: оформление виз, подбор гостиниц, ресторанов, развлечений и экскурсий, организация перелета и трансферов, бронирование, оплата и координация.', N'Полная визовая поддержка, организация внешних авиаперелетов, а так же внутренней логистики— авиаперелеты, ж/д, проживание и трансферы по Украине. Регистрация, оргвзносы. Благодаря постоянному мониторингу цен и скидок на гостиницы, нашим менеджерам удалось забронировать шикарный пятизвездочный отель в центре Праги — Grand Hotel Bohemia, по очень низкой цене для отеля такого уровня. В Праге большинство ресторанов выглядят как пивнушки, поэтому мы старались выбрать места, максимально привычные для наших людей, сохраняя при этом национальный колорит Чехии. Среди этих мест оказались такие рестораны, как Franz Josef Restaurant, KOGO Slovansky dum, Divinis, Restaurace MINCOVNA и другие. Не обошлось и без посещения культовых для Праги мест, таких как Монастырская пивоварня «Страгов» и «Пражский пивной музей». Так как группа, в большинстве своем, состояла из мужчин, мы не могли не провести для них пивной тур по заведениям Праги. Особенностью этого тура было то, что мы, изучив культовые пивоварни Праги, составили маршрут самостоятельно, без привлечения экскурсовода, благодаря чему помогли клиенту сэкономить. В первый вечер пребывания в Праге для участников была организована поездка на фольклорную вечеринку « У Марчану», где они отведали старочешские традиционные блюда с безлимитным пивом и вином, под зажигательные песни и танцы моравийского ансамбля.
Экскурсионная программа, гостиница, трансферы и прочее было оплачено нами из Украины, поэтому клиенты просто наслаждались организованной программой, не беспокоясь о вопросах оплаты.
Приятным и полезным бонусом с нашей стороны служит специальный информационный буклет, в котором описаны особенности страны и ее жителей, указаны забронированные рестораны с картой прохода от гостиницы, описание предстоящих экскурсий, достопримечательностей для самостоятельного посещения, полезных контактов и многое другое.', N'Проводить проект без предварительного чек-тура, еще и в другой стране, достаточно сложно, и тем не менее, у нас получилось сделать это профессионально и без лишних проблем для клиента. Были нюансы, которые трудно предугадать без личного присутствия на площадке, например внешний вид ресторана или подтверждение бронирования столика. Поэтому для решения таких моментов мы были на связи 24 часа в сутки на протяжении всей поездки, впрочем, как и в любой другой день для наших клиентов.')
INSERT [Portfolio].[Portfolio] ([PortfolioID], [FolderName], [ProjectName], [FormatID], [Сustomer], [Participants], [Location], [Task], [Implementation], [Result]) VALUES (10, N'hipsters-golden-dawn', N'Стиляги Золотого Рассвета', 4, N'ЗОЛОТОЙ РАССВЕТ АГРО', N'Сотрудники всех регионов', N'Украина, Киев, ресторан «Софія»', N'Ключевой задачей было — подготовить новогодний корпоратив на тему «Стиляги» за 4 дня (заказ был дан 20.12, в четверг, мероприятие было 24.12 — во вторник, по факту, мы его за выходные подготовили). Прописать концепцию и сценарий, согласовать с руководством компании, подобрать площадку, организовать ивент, а также интересную экскурсию по городу для гостей из регионов в преддверии Нового года.', N'Стиляги — тема хорошая, яркая, поэтому сложностей с разработкой концепции не возникло. Сложно было за 2 дня до мероприятия найти хороших артистов, ведущих, аниматоров, у которых эта дата была свободна. По желанию Заказчика, ведущим мы взяли Дядю Жору из «Comedy Club Ukraine». Киностудии тоже не работали в эти дни, поэтому реквизит для антуража мы свозили со всех уголков Киева — тематических заведений, «красных уголков» государственных аптек и т.п. На входе у нас стоял «киоск» с сигаретами «Беломор» и «Казбек», одеколон, значки с Лениным, старые журналы, мундштуки и многое другое, связанное с той эпохой. Гости получали советские рубли за участие в конкурсах и покупали «товары» в киоске или у фарцовщика. Участники мероприятия, по образам, делились на «идейно выдержанных» и «стиляг». На мероприятии работали аниматоры, в образе фарцовщика и продавщицы, шаржист, хостесс. Также в программе были выступления вокальных и танцевальных коллективов, мастер-класс по буги-вуги, шоу барменов. Прекрасным интерактивом послужил коллаж на тему «Стиляг», в виде большого баннера, который можно было раскрашивать. Завершающим аккордом, в лучших новогодних традициях, стал фейерверк!', N'Очень красочный, позитивный, бесшабашный праздник получился! Гости довольны (разойтись не могли до глубой ночи, так понравилось), Заказчик счастлив, мы, соответственно — вдвойне!')
INSERT [Portfolio].[Portfolio] ([PortfolioID], [FolderName], [ProjectName], [FormatID], [Сustomer], [Participants], [Location], [Task], [Implementation], [Result]) VALUES (11, N'indian-new-year-party', N'Indian New Year Party (2013)', 4, N'Банк', N'Сотрудники компании', N'Украина, Киев, Buddha Bar', N'Концептуальное празднование Нового Года, активное вовлечение сотрудников в процесс подготовки и проведения мероприятия', N'Рассматривались концепции «Венский Бал» и «Болливуд», предпочтение было отдано индийскому стилю вечеринки. «Будда Бар» был выбран как идеальное место проведения такого мероприятия, локация с высоким уровнем сервиса, отменной кухней и качественным обслуживанием. Поскольку задачей было вовлечь сотрудников, были организованы уроки по изучению искусства индийского танца, осуществлены тематические танцевальные постановки, подобраны костюмы. Был прописан креативный сценарий с участием сотрудников, приглашены гуру индийского танца в Украине Сергей Журавлев с дочерьми, звезда шоу «Україна має талант» — Казимир, с ярчайшими танцевальными номерами, и ансамбль индийского танца Oriental Dance. На протяжении всего вечера работали развлекательные локации: гадание на картах Ошо, гадание на специях, рисунки хной Мехенди. Завершающим аккордом мероприятия, по традиции банка, стал брендированный торт и дискотека.', N'По отзывам сотрудников, это был лучший Новый Год в истории Банка!')
INSERT [Portfolio].[Portfolio] ([PortfolioID], [FolderName], [ProjectName], [FormatID], [Сustomer], [Participants], [Location], [Task], [Implementation], [Result]) VALUES (12, N'we-building-life', N'Мы строим жизнь', 5, N'BOSCH', N'Сотрудники компании', N'Fortuna Club', N'Обучение. Командообразование. Фан.', N'Были решены стандартные задачи: проживание, питание, траснфер, конференц-сервис. Поскольку весь комплекс мероприятий проводился для отдела строительных инструментов BOSCH, в качестве развлекательно-командообразующей составляющей была разработана концепция «Мы строим жизнь». Идея вот в чем. Мы не просто работаем, мы помогаем СТОРОИТЬ. Строить дома. Строить планы. Строить отношения. Строить доверие. Строить счастье. Строить карьеру. Строить бизнес. Строить стратегии. Строить успех. Строить состояние. Строить страну. Строить будущее. Мы не просто строим, мы строим свою ЖИЗНЬ! Тимбилдинг проходил в формате фотоквеста. Участников поделили на команду, раздали инструменты и карточки с заданиями. Дальше им нужно было сделать постановку на одну из тем: строить дома/отношения/стратегии. С командами работали визажисты, фотографы и режиссер-постановщики. Каждая постановка делалась в двух вариантах: по сюжету, прописанному заранее креативщиком, и свой вариант, придуманный командой на месте. Потому что внутри команды определялись свои «режиссеры-постановщики» и главные герои. Как распределяются роли важно было увидеть. После фотоквеста сотрудников ждал фуршет и мастер-класс грузинской кухни. На следующий день — Октоберфест. Хоть «Октоберфест» мы уже делали, но грех было не повторить — даты совпали с проведением знаменитого фестиваля, плюс компания немецкая, и загородный комплекс. Это было очень удачное решение.', N'Формат тимбилдинга-фотосессии очень понравился сотрудникам. Из отснятого материала компания планирует сделать корпоративный календарь на 2015-й год.')
INSERT [Portfolio].[Portfolio] ([PortfolioID], [FolderName], [ProjectName], [FormatID], [Сustomer], [Participants], [Location], [Task], [Implementation], [Result]) VALUES (13, N'strength-of-plants', N'Сказочная сила растений', 6, N'Bionorica', N'Партнеры, 170 чел', N'Украина, Полтава, PODIUM Fashion Club', N'Организация гала-ужина, с небольшой научной частью и развлекательной программой...', N'В основе развлекательной программы была фотосессия на тему «Сказочная сила растений». Участников поделили на команды. В специально оборудованом помещении, их ждали фотографы, костюмы и реквизит. Фотографии отдавались сразу дизайнерам, для подставления клипартов из сказок, на которые были постановки. В конце вечера кадры фотосессии были презентованы участникам. После дополнительной обработки, был сделан календарь и разослан участникам.', N'Календарь вызвал массу восторгов, попросили повторить обязательно на следующий год...')
INSERT [Portfolio].[Portfolio] ([PortfolioID], [FolderName], [ProjectName], [FormatID], [Сustomer], [Participants], [Location], [Task], [Implementation], [Result]) VALUES (14, N'fitoteka', N'Фитотека', 7, N'Фармацевтическая компания', N'Дети, родители', N'Украина (Полтава, Винница, Одесса)', N'Организация открытия отдела «Фитотека» в аптеках. Мероприятие для детей города.', N'В честь открытия отделов «Фитотека», проводились открытые мероприятия для детей города. За 2 недели до мероприятия, объявлялся конкурс рисунка на тему «Сила растений». Для привлечения детей, также была организована работа промоутеров и реклама. Детей собиралось много. Официальная часть мероприятия занимала буквально 10 минут, все остальное время ведущий и аниматоры развлекали детей. По легенде, у нас заболел Мишка, и доктор Айболит, с помощью растительных препаратов и улыбок детей, его лечил.', N'Улыбки на лицах детей. Это бесценно.')
INSERT [Portfolio].[Portfolio] ([PortfolioID], [FolderName], [ProjectName], [FormatID], [Сustomer], [Participants], [Location], [Task], [Implementation], [Result]) VALUES (15, N'stars-of-renaissance', N'Звезды Ренессанса', 8, N'Банк «Ренессанс Кредит»', N'Сотрудники, 600 чел', N'Украина, Киев, офис компании', N'Поздравить всех девушек в офисе с международным женским днем, сделать это красиво и эффектно. Это должно быть не просто поздравление утром, а праздник целый день. Праздничная атмосфера должна оставлять место для работы, выполнения своих функциональных обязанностей в этот день.', N'Было разработано 2 концепции — «Сказочное 8-е марта» и Fashion Woman’s Day, которые трансформировались в праздник «Звезды Ренессанса». Утром девушек встречал миллион алых роз на ресепшене, шампанское, печенье с предсказаниями и ТОП-менеджмент компании с персональными поздравлениями. На рабочих местах их ожидали вкусные сюрпризы с забавными бирками «Съешь меня», «Выпей меня», «Укуси меня», «Улыбнись, ты прекрасна». Работала станция безумно вкусного итальянского мороженного, которым с удовольствием лакомились не только девушки, но и мужчины. На протяжении всего дня играла музыка и происходила фотосессия на красной дорожке — с цветами, шампанским, Джеймсом Бондом, другими знаменитостями и забавным реквизитом. Очаровательный журналист брал у девушек интервью, а папарацци сновали по всему офису, улавливая бесценные кадры жизни офиса. Все это легло в основу корпоративного журнала «Звезды Ренессанса», который будет выпущен ко Дню Банковского работника.', N'Прекрасная половина банка «Ренессанс Кредит» была в восторге — улыбки, благодарные отзывы и хорошее настроение господствовали на протяжении всего дня. Мужчины были довольны, они были героями в этот день, девушки их сердечно благодарили за организацию такого праздника. Праздник прошел гладко, в четком соответствии с техническим сценарием и таймингом, все цели были достигнуты, задача выполнена на «отлично».')
INSERT [Portfolio].[Portfolio] ([PortfolioID], [FolderName], [ProjectName], [FormatID], [Сustomer], [Participants], [Location], [Task], [Implementation], [Result]) VALUES (16, N'fetal-medicine', N'Медицина плода', 9, N'Клиника Isida', N'Врачи, представители фармкомпаний (спонсоры), 300 чел.', N'Украина, Киев, НСК «Олимпийский»', N'Найти локацию в рамках бюджета, привлечь спонсоров. Организовать конференцию для обсуждения вопросов ведения беременности, операции на плоде во время беременности и т.д. Найти решения, презентовать инновации.', N'Для проведения мероприятия был выбран НСК «Олимпийский» — удобное месторасположение, отличные залы, приемлемые цены, статусность площадки. Был приглашен иностранный спикер (Николай Веропортвеляна), сформированы спонсорские пакеты, привлечены спонсоры (Ipsen, Delta Medical, MedLab, BESINS Healthcare, Інститут клітинної терапії), разработана система коммуникаций их продуктов с гостями. Также были решены стандартные организационные моменты: кейтеринг, размещение, брендирование, стенды, синхронный перевод, видеотрансляция, фоторепортаж, презентационные материалы, разрешительное согласование, организация поездки спикера и т.д.', N'Для клиники ISIDA — это был хороший PR-ход для закрепления своих позиций на рынке и улучшения репутации. Для спонсоров и для гостей — это была возможность услышать интересных спикеров, узнать последние инновации, обменяться опытом с коллегами, а также побывать на экскурсии в НСК, вкусно покушать, послушать пианиста-виртуоза Евгения Хмару — приятно и с пользой провести время.')
INSERT [Portfolio].[Portfolio] ([PortfolioID], [FolderName], [ProjectName], [FormatID], [Сustomer], [Participants], [Location], [Task], [Implementation], [Result]) VALUES (17, N'deer-vs-hare', N'ЗАЙЦЫ vs ОЛЕНИ', 10, N'Фармацевтическая компания', N'Сотрудники, 100 чел.', N'Закарпатье, Воеводино', N'Организация новогодней вечеринки, простой, в плане подготовки для сотрудников, веселой, без приглашенных артистов...', N'Деда Мороза и Санту всегда сравнивали. Это не ново, но чрезвычайно актуально, ведь в Киеве, в этом году, официально проигнорировали Деда, вместе со Снегурочкой. И всем досадно. Как же так, Деда Мороза не существует?.. И Снегурочки не будут дефилировать.. У нашего заказчика были на празднике все, причем это был настоящий БАтЛ: Дед Мороз VS Санта Клаус, Снегурочка VS Подружки Санты, Зайцы VS Олени. Дресс-код, как и хотел Заказчик, был простой — ушки и рожки. Кто с ушками шел в команду к Деду, кто с рожками — к Санте, соответственно. Вся штука еще в том, что у Заказчика есть два любимых ведущих, которые на протяжении года были «хэдлайнерами» всех возможных мероприятий. Они и вдохновили нас на рождение этой концепции.', N'Было очень весело. А завершилось все свадьбой… Но об этом — при встрече;)')
INSERT [Portfolio].[Portfolio] ([PortfolioID], [FolderName], [ProjectName], [FormatID], [Сustomer], [Participants], [Location], [Task], [Implementation], [Result]) VALUES (18, N'workshop-by-sosnovskih', N'Мастер-класс Сосновских', 9, N'Фармацевтическая компания', N'Врачи, 100 чел.', N'Украина, Одесса, Сады Победы', N'Организация конференции и мастер-класса немецкой кухни.', N'Местом проведения мероприятия выбрали «Сады Победы», одну из лучших площадок Одессы. Для проведения мастер-класса по приготовлению двух знаменитых блюд немецкой кухни — свинной рульки и штруделя, был приглашен финалист проекта «Мастер-Шеф» Михаил Сосновских. После мастер-класса, на праздничном ужине, гости оценили кулинарные шедевры талантливого шеф-повара.', N'Гости, благодарные за полученные разносторонние знания, профессиональные и кулинарные.')
SET IDENTITY_INSERT [Portfolio].[Portfolio] OFF

SET IDENTITY_INSERT [Restaurant].[Classification] ON
INSERT [Restaurant].[Classification] ([ClassificationID], [Name]) VALUES (1, N'Классический ')
INSERT [Restaurant].[Classification] ([ClassificationID], [Name]) VALUES (2, N'Тематический')
INSERT [Restaurant].[Classification] ([ClassificationID], [Name]) VALUES (3, N'Национальный')
INSERT [Restaurant].[Classification] ([ClassificationID], [Name]) VALUES (4, N'Специализированный')
INSERT [Restaurant].[Classification] ([ClassificationID], [Name]) VALUES (5, N'Паб')
INSERT [Restaurant].[Classification] ([ClassificationID], [Name]) VALUES (6, N'Караоке')
SET IDENTITY_INSERT [Restaurant].[Classification] OFF

SET IDENTITY_INSERT [Restaurant].[Kitchen] ON
INSERT [Restaurant].[Kitchen] ([KitchenID], [Name]) VALUES (1, N'Авторская')
INSERT [Restaurant].[Kitchen] ([KitchenID], [Name]) VALUES (2, N'Азербайджанская')
INSERT [Restaurant].[Kitchen] ([KitchenID], [Name]) VALUES (3, N'Американская')
INSERT [Restaurant].[Kitchen] ([KitchenID], [Name]) VALUES (4, N'Арабская')
INSERT [Restaurant].[Kitchen] ([KitchenID], [Name]) VALUES (5, N'Армянская')
INSERT [Restaurant].[Kitchen] ([KitchenID], [Name]) VALUES (6, N'Грузинская')
INSERT [Restaurant].[Kitchen] ([KitchenID], [Name]) VALUES (7, N'Еврейская')
INSERT [Restaurant].[Kitchen] ([KitchenID], [Name]) VALUES (8, N'Европейская')
INSERT [Restaurant].[Kitchen] ([KitchenID], [Name]) VALUES (9, N'Индийская')
INSERT [Restaurant].[Kitchen] ([KitchenID], [Name]) VALUES (10, N'Испанская')
INSERT [Restaurant].[Kitchen] ([KitchenID], [Name]) VALUES (11, N'Итальянская')
INSERT [Restaurant].[Kitchen] ([KitchenID], [Name]) VALUES (12, N'Китайская')
INSERT [Restaurant].[Kitchen] ([KitchenID], [Name]) VALUES (13, N'Корейская')
INSERT [Restaurant].[Kitchen] ([KitchenID], [Name]) VALUES (14, N'Ливанская')
INSERT [Restaurant].[Kitchen] ([KitchenID], [Name]) VALUES (15, N'Марокканская')
INSERT [Restaurant].[Kitchen] ([KitchenID], [Name]) VALUES (16, N'Мексиканская')
INSERT [Restaurant].[Kitchen] ([KitchenID], [Name]) VALUES (17, N'Немецкая')
INSERT [Restaurant].[Kitchen] ([KitchenID], [Name]) VALUES (18, N'Польская')
INSERT [Restaurant].[Kitchen] ([KitchenID], [Name]) VALUES (19, N'Русская')
INSERT [Restaurant].[Kitchen] ([KitchenID], [Name]) VALUES (20, N'Средиземноморская')
INSERT [Restaurant].[Kitchen] ([KitchenID], [Name]) VALUES (21, N'Тайская')
INSERT [Restaurant].[Kitchen] ([KitchenID], [Name]) VALUES (22, N'Турецкая')
INSERT [Restaurant].[Kitchen] ([KitchenID], [Name]) VALUES (23, N'Узбекская')
INSERT [Restaurant].[Kitchen] ([KitchenID], [Name]) VALUES (24, N'Украинская')
INSERT [Restaurant].[Kitchen] ([KitchenID], [Name]) VALUES (25, N'Французская')
INSERT [Restaurant].[Kitchen] ([KitchenID], [Name]) VALUES (26, N'Шотландская')
INSERT [Restaurant].[Kitchen] ([KitchenID], [Name]) VALUES (27, N'Японская')
SET IDENTITY_INSERT [Restaurant].[Kitchen] OFF

SET IDENTITY_INSERT [Restaurant].[Restaurant] ON
INSERT [Restaurant].[Restaurant] ([RestaurantID], [PlatformID], [TypeID], [ClassificationID], [KitchenID], [Name], [FolderName], [Banquet], [Buffet], [TotalSquare], [Seating]) VALUES (1, 1, 1, 3, 24, N'Литораль', N'kazatskiyStan\restaurants\litoral', 250, 300, NULL, 200)
INSERT [Restaurant].[Restaurant] ([RestaurantID], [PlatformID], [TypeID], [ClassificationID], [KitchenID], [Name], [FolderName], [Banquet], [Buffet], [TotalSquare], [Seating]) VALUES (2, 1, 1, 3, 24, N'Гетьманский', N'kazatskiyStan\restaurants\litoral', 100, 160, NULL, 64)
SET IDENTITY_INSERT [Restaurant].[Restaurant] OFF

SET IDENTITY_INSERT [Restaurant].[RestaurantType] ON
INSERT [Restaurant].[RestaurantType] ([TypeId], [Name]) VALUES (1, N'Ресторан')
INSERT [Restaurant].[RestaurantType] ([TypeId], [Name]) VALUES (2, N'Банкетный зал')
INSERT [Restaurant].[RestaurantType] ([TypeId], [Name]) VALUES (3, N'Конференц-зал')
INSERT [Restaurant].[RestaurantType] ([TypeId], [Name]) VALUES (4, N'Выставочный зал')
INSERT [Restaurant].[RestaurantType] ([TypeId], [Name]) VALUES (5, N'Концертный зал')
INSERT [Restaurant].[RestaurantType] ([TypeId], [Name]) VALUES (6, N'Ночной клуб')
INSERT [Restaurant].[RestaurantType] ([TypeId], [Name]) VALUES (7, N'Нестандартная площадка')
INSERT [Restaurant].[RestaurantType] ([TypeId], [Name]) VALUES (8, N'Летняя площадка')
INSERT [Restaurant].[RestaurantType] ([TypeId], [Name]) VALUES (9, N'Площадка с активностями')
INSERT [Restaurant].[RestaurantType] ([TypeId], [Name]) VALUES (10, N'Лаунж-бар')
INSERT [Restaurant].[RestaurantType] ([TypeId], [Name]) VALUES (11, N'Ballroom')
INSERT [Restaurant].[RestaurantType] ([TypeId], [Name]) VALUES (12, N'Лобби-бар')
SET IDENTITY_INSERT [Restaurant].[RestaurantType] OFF

/****** Constraints ******/

ALTER TABLE [dbo].[Platform]  WITH CHECK ADD  CONSTRAINT [FK_Platform_City] FOREIGN KEY([CityID])
REFERENCES [dbo].[City] ([CityID])
GO
ALTER TABLE [dbo].[Platform] CHECK CONSTRAINT [FK_Platform_City]
GO
ALTER TABLE [dbo].[Platform]  WITH CHECK ADD  CONSTRAINT [FK_Platform_Level] FOREIGN KEY([LevelID])
REFERENCES [dbo].[Level] ([LevelID])
GO
ALTER TABLE [dbo].[Platform] CHECK CONSTRAINT [FK_Platform_Level]
GO
ALTER TABLE [dbo].[Platform]  WITH CHECK ADD  CONSTRAINT [FK_Platform_Location] FOREIGN KEY([LocationID])
REFERENCES [dbo].[Location] ([LocationID])
GO
ALTER TABLE [dbo].[Platform] CHECK CONSTRAINT [FK_Platform_Location]
GO
ALTER TABLE [Hall].[Hall]  WITH CHECK ADD  CONSTRAINT [FK_Hall_Platform] FOREIGN KEY([PlatformID])
REFERENCES [dbo].[Platform] ([PlatformID])
GO
ALTER TABLE [Hall].[Hall] CHECK CONSTRAINT [FK_Hall_Platform]
GO
ALTER TABLE [Hotel].[Hotel]  WITH CHECK ADD  CONSTRAINT [FK_Hotel_HotelCategory] FOREIGN KEY([HotelCategoryID])
REFERENCES [Hotel].[HotelCategory] ([HotelCategoryID])
GO
ALTER TABLE [Hotel].[Hotel] CHECK CONSTRAINT [FK_Hotel_HotelCategory]
GO
ALTER TABLE [Hotel].[Hotel]  WITH CHECK ADD  CONSTRAINT [FK_Hotel_Platform] FOREIGN KEY([PlatformID])
REFERENCES [dbo].[Platform] ([PlatformID])
GO
ALTER TABLE [Hotel].[Hotel] CHECK CONSTRAINT [FK_Hotel_Platform]
GO
ALTER TABLE [Hotel].[Room]  WITH CHECK ADD  CONSTRAINT [FK_Room_Category] FOREIGN KEY([RoomCategoryID])
REFERENCES [Hotel].[RoomCategory] ([RoomCategoryID])
GO
ALTER TABLE [Hotel].[Room] CHECK CONSTRAINT [FK_Room_Category]
GO
ALTER TABLE [Hotel].[Room]  WITH CHECK ADD  CONSTRAINT [FK_Room_Hotel] FOREIGN KEY([HotelID])
REFERENCES [Hotel].[Hotel] ([HotelID])
GO
ALTER TABLE [Hotel].[Room] CHECK CONSTRAINT [FK_Room_Hotel]
GO
ALTER TABLE [Hotel].[Room]  WITH CHECK ADD  CONSTRAINT [FK_Room_RoomType] FOREIGN KEY([RoomTypeID])
REFERENCES [Hotel].[RoomType] ([TypeID])
GO
ALTER TABLE [Hotel].[Room] CHECK CONSTRAINT [FK_Room_RoomType]
GO
ALTER TABLE [Portfolio].[Portfolio]  WITH CHECK ADD  CONSTRAINT [FK_Portfolio_Format] FOREIGN KEY([FormatID])
REFERENCES [Portfolio].[Format] ([FormatID])
GO
ALTER TABLE [Portfolio].[Portfolio] CHECK CONSTRAINT [FK_Portfolio_Format]
GO
ALTER TABLE [Restaurant].[Restaurant]  WITH CHECK ADD  CONSTRAINT [FK_Restaurant_Classification] FOREIGN KEY([ClassificationID])
REFERENCES [Restaurant].[Classification] ([ClassificationID])
GO
ALTER TABLE [Restaurant].[Restaurant] CHECK CONSTRAINT [FK_Restaurant_Classification]
GO
ALTER TABLE [Restaurant].[Restaurant]  WITH CHECK ADD  CONSTRAINT [FK_Restaurant_Kitchen] FOREIGN KEY([KitchenID])
REFERENCES [Restaurant].[Kitchen] ([KitchenID])
GO
ALTER TABLE [Restaurant].[Restaurant] CHECK CONSTRAINT [FK_Restaurant_Kitchen]
GO
ALTER TABLE [Restaurant].[Restaurant]  WITH CHECK ADD  CONSTRAINT [FK_Restaurant_Platform] FOREIGN KEY([PlatformID])
REFERENCES [dbo].[Platform] ([PlatformID])
GO
ALTER TABLE [Restaurant].[Restaurant] CHECK CONSTRAINT [FK_Restaurant_Platform]
GO
ALTER TABLE [Restaurant].[Restaurant]  WITH CHECK ADD  CONSTRAINT [FK_Restaurant_RestaurantType] FOREIGN KEY([TypeID])
REFERENCES [Restaurant].[RestaurantType] ([TypeId])
GO
ALTER TABLE [Restaurant].[Restaurant] CHECK CONSTRAINT [FK_Restaurant_RestaurantType]
GO
