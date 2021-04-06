SET IDENTITY_INSERT [dbo].[Cars] ON
INSERT INTO [dbo].[Cars] ([CarId], [BrandId], [ColorId], [ModelYear], [DailyPrice], [Description]) VALUES (1, 1, 1, N'2012', CAST(15.0000 AS Money), N'A6, Compact, 4 Adults, 3 Bags')
INSERT INTO [dbo].[Cars] ([CarId], [BrandId], [ColorId], [ModelYear], [DailyPrice], [Description]) VALUES (2, 1, 2, N'2016', CAST(20.0000 AS Money), N'A6, Standard, 5 Adults, 4 Bags')
INSERT INTO [dbo].[Cars] ([CarId], [BrandId], [ColorId], [ModelYear], [DailyPrice], [Description]) VALUES (3, 4, 4, N'2019', CAST(35.0000 AS Money), N'CLA-180 AMG, Luxury, 5 Adults, 4 Bags')
INSERT INTO [dbo].[Cars] ([CarId], [BrandId], [ColorId], [ModelYear], [DailyPrice], [Description]) VALUES (4, 3, 1, N'2015', CAST(54.0000 AS Money), N'EcoSport, SUV - Compact, 6 Adults, 6 Bags')
SET IDENTITY_INSERT [dbo].[Cars] OFF
