CREATE TABLE [dbo].[Students] (
    [id]            INT          IDENTITY (1, 1) NOT NULL,
    [first_name]    VARCHAR (50) NOT NULL,
    [last_name]     VARCHAR (50) NOT NULL,
    [email_address] VARCHAR (50) NOT NULL,
    [phone_number]  VARCHAR (50) NOT NULL,
    [country]       VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

SET IDENTITY_INSERT [dbo].[Students] ON
INSERT INTO [dbo].[Students] ([id], [first_name], [last_name], [email_address], [phone_number], [country]) VALUES (1, N'Carmina', N'Catherick', N'ccatherick0@tamu.edu', N'323-587-4791', N'China')
INSERT INTO [dbo].[Students] ([id], [first_name], [last_name], [email_address], [phone_number], [country]) VALUES (2, N'Niko', N'Huitt', N'nhuitt1@creativecommons.org', N'289-764-4255', N'Ukraine')
INSERT INTO [dbo].[Students] ([id], [first_name], [last_name], [email_address], [phone_number], [country]) VALUES (3, N'Shirley', N'Campling', N'scampling2@posterous.com', N'631-779-6757', N'Croatia')
INSERT INTO [dbo].[Students] ([id], [first_name], [last_name], [email_address], [phone_number], [country]) VALUES (4, N'Mathew', N'Perrycost', N'mperrycost3@loc.gov', N'686-822-2356', N'Russia')
INSERT INTO [dbo].[Students] ([id], [first_name], [last_name], [email_address], [phone_number], [country]) VALUES (5, N'Nobie', N'Ormistone', N'normistone4@reverbnation.com', N'767-940-2088', N'China')
INSERT INTO [dbo].[Students] ([id], [first_name], [last_name], [email_address], [phone_number], [country]) VALUES (6, N'Zitella', N'Boyce', N'zboyce5@mtv.com', N'671-421-7240', N'China')
INSERT INTO [dbo].[Students] ([id], [first_name], [last_name], [email_address], [phone_number], [country]) VALUES (7, N'Claudie', N'O''Neary', N'coneary6@livejournal.com', N'464-597-9016', N'Peru')
INSERT INTO [dbo].[Students] ([id], [first_name], [last_name], [email_address], [phone_number], [country]) VALUES (8, N'Robinet', N'Healey', N'rhealey7@china.com.cn', N'465-250-0500', N'Finland')
INSERT INTO [dbo].[Students] ([id], [first_name], [last_name], [email_address], [phone_number], [country]) VALUES (9, N'Fae', N'Pabst', N'fpabst8@hubpages.com', N'124-863-1894', N'Indonesia')
INSERT INTO [dbo].[Students] ([id], [first_name], [last_name], [email_address], [phone_number], [country]) VALUES (10, N'Mellisent', N'Maffioletti', N'mmaffioletti9@zimbio.com', N'741-514-9770', N'China')
INSERT INTO [dbo].[Students] ([id], [first_name], [last_name], [email_address], [phone_number], [country]) VALUES (11, N'Ermina', N'Sothern', N'esotherna@godaddy.com', N'664-826-3335', N'China')
INSERT INTO [dbo].[Students] ([id], [first_name], [last_name], [email_address], [phone_number], [country]) VALUES (12, N'Kimbra', N'Mateus', N'kmateusb@angelfire.com', N'705-814-1647', N'Uganda')
INSERT INTO [dbo].[Students] ([id], [first_name], [last_name], [email_address], [phone_number], [country]) VALUES (13, N'Caro', N'Paulusch', N'cpauluschc@mozilla.org', N'609-776-8079', N'Mexico')
INSERT INTO [dbo].[Students] ([id], [first_name], [last_name], [email_address], [phone_number], [country]) VALUES (14, N'Meredith', N'Molines', N'mmolinesd@mail.ru', N'854-982-3429', N'Indonesia')
INSERT INTO [dbo].[Students] ([id], [first_name], [last_name], [email_address], [phone_number], [country]) VALUES (15, N'Gustaf', N'Snoden', N'gsnodene@bloomberg.com', N'512-231-4771', N'Peru')
INSERT INTO [dbo].[Students] ([id], [first_name], [last_name], [email_address], [phone_number], [country]) VALUES (16, N'Wylie', N'Talmadge', N'wtalmadgef@mediafire.com', N'181-822-3337', N'Russia')
INSERT INTO [dbo].[Students] ([id], [first_name], [last_name], [email_address], [phone_number], [country]) VALUES (17, N'Linn', N'Pawlik', N'lpawlikg@wordpress.com', N'320-808-4904', N'Indonesia')
INSERT INTO [dbo].[Students] ([id], [first_name], [last_name], [email_address], [phone_number], [country]) VALUES (18, N'Lena', N'Scotchbrook', N'lscotchbrookh@nhs.uk', N'817-896-3968', N'Yemen')
INSERT INTO [dbo].[Students] ([id], [first_name], [last_name], [email_address], [phone_number], [country]) VALUES (19, N'Cindy', N'Sinkin', N'csinkini@addtoany.com', N'599-433-2778', N'Philippines')
INSERT INTO [dbo].[Students] ([id], [first_name], [last_name], [email_address], [phone_number], [country]) VALUES (20, N'Zackariah', N'Lovick', N'lovick-z@email.ulster.ac.uk', N'445-839-6354', N'Brazil')
INSERT INTO [dbo].[Students] ([id], [first_name], [last_name], [email_address], [phone_number], [country]) VALUES (22, N'test', N'test2', N'test@test.com', N'123-456-7890', N'test5')
SET IDENTITY_INSERT [dbo].[Students] OFF
