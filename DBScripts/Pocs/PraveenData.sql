USE [OnlineBookStore]
GO
SET IDENTITY_INSERT [dbo].[Users] ON 
GO
INSERT [dbo].[Users] ([userid], [Username], [password], [Firstname], [Lastname], [Address], [Phone], [MailId], [UserType]) VALUES (1, N'admin@gmail.com', N'password', N'John', N'Doe', N'123 Main St, NY', N'123-456-7890', N'jdoe@example.com', 1)
GO
INSERT [dbo].[Users] ([userid], [Username], [password], [Firstname], [Lastname], [Address], [Phone], [MailId], [UserType]) VALUES (2, N'user@gmail.com', N'password', N'Alice', N'Smith', N'456 Oak Ave, CA', N'321-654-0987', N'asmith@example.com', 2)
GO
INSERT [dbo].[Users] ([userid], [Username], [password], [Firstname], [Lastname], [Address], [Phone], [MailId], [UserType]) VALUES (3, N'bwayne', N'password', N'Bruce', N'Wayne', N'1007 Mountain Dr, Gotham', N'555-123-4567', N'bwayne@wayne.com', 1)
GO
INSERT [dbo].[Users] ([userid], [Username], [password], [Firstname], [Lastname], [Address], [Phone], [MailId], [UserType]) VALUES (4, N'ckent', N'password', N'Clark', N'Kent', N'344 Clinton St, Metro', N'555-000-1111', N'ckent@planet.com', 2)
GO
INSERT [dbo].[Users] ([userid], [Username], [password], [Firstname], [Lastname], [Address], [Phone], [MailId], [UserType]) VALUES (5, N'pparker', N'password', N'Peter', N'Parker', N'20 Ingram St, NY', N'555-222-3333', N'pparker@bugle.com', 1)
GO
INSERT [dbo].[Users] ([userid], [Username], [password], [Firstname], [Lastname], [Address], [Phone], [MailId], [UserType]) VALUES (6, N'nwilson', N'password', N'Nancy', N'Wilson', N'789 Elm St, TX', N'555-444-5555', N'nwilson@example.com', 1)
GO
INSERT [dbo].[Users] ([userid], [Username], [password], [Firstname], [Lastname], [Address], [Phone], [MailId], [UserType]) VALUES (7, N'tstark', N'password', N'Tony', N'Stark', N'10880 Malibu Point, CA', N'555-666-7777', N'tstark@stark.com', 2)
GO
INSERT [dbo].[Users] ([userid], [Username], [password], [Firstname], [Lastname], [Address], [Phone], [MailId], [UserType]) VALUES (8, N'srogers', N'password', N'Steve', N'Rogers', N'569 Brooklyn St, NY', N'555-888-9999', N'srogers@example.com', 1)
GO
INSERT [dbo].[Users] ([userid], [Username], [password], [Firstname], [Lastname], [Address], [Phone], [MailId], [UserType]) VALUES (9, N'bwilliams', N'password', N'Beth', N'Williams', N'101 Pine Rd, CO', N'555-000-1234', N'bwilliams@example.com', 2)
GO
INSERT [dbo].[Users] ([userid], [Username], [password], [Firstname], [Lastname], [Address], [Phone], [MailId], [UserType]) VALUES (10, N'djohnson', N'password', N'David', N'Johnson', N'11 Sunset Blvd, FL', N'555-111-2222', N'djohnson@example.com', 1)
GO
INSERT [dbo].[Users] ([userid], [Username], [password], [Firstname], [Lastname], [Address], [Phone], [MailId], [UserType]) VALUES (11, N'userDto.Username', N'default123', N'userDto.Firstname', N'userDto.Lastname', N' userDto.Address', N'1111', N'userDto.MailId', 2)
GO
INSERT [dbo].[Users] ([userid], [Username], [password], [Firstname], [Lastname], [Address], [Phone], [MailId], [UserType]) VALUES (12, N'userDto.Username', N'default123', N'userDto.Firstname', N'userDto.Lastname', N' userDto.Address', N'1111', N'userDto.MailId', 2)
GO
INSERT [dbo].[Users] ([userid], [Username], [password], [Firstname], [Lastname], [Address], [Phone], [MailId], [UserType]) VALUES (13, N'userDto.Username', N'default123', N'userDto.Firstname', N'userDto.Lastname', N' userDto.Address', N'1111', N'userDto.MailId', 2)
GO
INSERT [dbo].[Users] ([userid], [Username], [password], [Firstname], [Lastname], [Address], [Phone], [MailId], [UserType]) VALUES (14, N'userDto.Username', N'default123', N'userDto.Firstname', N'userDto.Lastname', N' userDto.Address', N'1111', N'userDto.MailId', 2)
GO
INSERT [dbo].[Users] ([userid], [Username], [password], [Firstname], [Lastname], [Address], [Phone], [MailId], [UserType]) VALUES (15, N'userDto.Username', N'default123', N'userDto.Firstname', N'userDto.Lastname', N' userDto.Address', N'1111', N'userDto.MailId', 2)
GO
INSERT [dbo].[Users] ([userid], [Username], [password], [Firstname], [Lastname], [Address], [Phone], [MailId], [UserType]) VALUES (16, N'admin@gmail.com', N'password', N'pravee', N'asdafs', N'asdfas', N'1234567890', N'admin@gmail.com', 1)
GO
INSERT [dbo].[Users] ([userid], [Username], [password], [Firstname], [Lastname], [Address], [Phone], [MailId], [UserType]) VALUES (17, N'admin1@gmail.com', N'password', N'asd', N'asdf', N'asdfas', N'1234444444', N'admin1@gmail.com', 2)
GO
INSERT [dbo].[Users] ([userid], [Username], [password], [Firstname], [Lastname], [Address], [Phone], [MailId], [UserType]) VALUES (18, N'admin2@gmail.com', N'password', N'FFF', N'SSq', N'asdfas', N'9999999399', N'admin2@gmail.com', 2)
GO
INSERT [dbo].[Users] ([userid], [Username], [password], [Firstname], [Lastname], [Address], [Phone], [MailId], [UserType]) VALUES (19, N'aaa@gmail.com', N'password', N'N', N'j', N'sadfa', N'9999939999', N'aaa@gmail.com', 2)
GO
INSERT [dbo].[Users] ([userid], [Username], [password], [Firstname], [Lastname], [Address], [Phone], [MailId], [UserType]) VALUES (20, N'admin2@gmail.com', N'password', N'sdf', N'sdf', N'sdf', N'8888888888', N'admin2@gmail.com', 2)
GO
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
SET IDENTITY_INSERT [dbo].[Books] ON 
GO
INSERT [dbo].[Books] ([BookId], [Title], [AuthorName], [Description], [Price], [ImageUrl], [TypeId], [BookTypeName], [StockQuantity], [IsActive], [PublishedDate]) VALUES (1, N'The Great Gatsby', N'F. Scott Fitzgerald', N'A novel set in the Jazz Age.', CAST(150.00 AS Decimal(10, 2)), N'images/book1.jpg', 2, N'Fiction', 20, 1, CAST(N'2025-05-10' AS Date))
GO
INSERT [dbo].[Books] ([BookId], [Title], [AuthorName], [Description], [Price], [ImageUrl], [TypeId], [BookTypeName], [StockQuantity], [IsActive], [PublishedDate]) VALUES (2, N'1984', N'George Orwell', N'A dystopian novel about totalitarianism.', CAST(180.00 AS Decimal(10, 2)), N'images/book2.jpg', 2, N'Fiction', 15, 1, CAST(N'2025-05-10' AS Date))
GO
INSERT [dbo].[Books] ([BookId], [Title], [AuthorName], [Description], [Price], [ImageUrl], [TypeId], [BookTypeName], [StockQuantity], [IsActive], [PublishedDate]) VALUES (3, N'To Kill a Mockingbird', N'Harper Lee', N'Racial injustice in the Deep South.', CAST(170.00 AS Decimal(10, 2)), N'images/book3.jpg', 2, N'Fiction', 10, 1, CAST(N'2025-05-10' AS Date))
GO
INSERT [dbo].[Books] ([BookId], [Title], [AuthorName], [Description], [Price], [ImageUrl], [TypeId], [BookTypeName], [StockQuantity], [IsActive], [PublishedDate]) VALUES (4, N'Pride and Prejudice', N'Jane Austen', N'A classic romance.', CAST(160.00 AS Decimal(10, 2)), N'images/book4.jpg', 2, N'Fiction', 18, 1, CAST(N'2025-05-10' AS Date))
GO
INSERT [dbo].[Books] ([BookId], [Title], [AuthorName], [Description], [Price], [ImageUrl], [TypeId], [BookTypeName], [StockQuantity], [IsActive], [PublishedDate]) VALUES (5, N'Moby-Dick', N'Herman Melville', N'Obsession with a whale.', CAST(190.00 AS Decimal(10, 2)), N'images/book5.jpg', 2, N'Fiction', 12, 1, CAST(N'2025-05-10' AS Date))
GO
INSERT [dbo].[Books] ([BookId], [Title], [AuthorName], [Description], [Price], [ImageUrl], [TypeId], [BookTypeName], [StockQuantity], [IsActive], [PublishedDate]) VALUES (6, N'War and Peace', N'Leo Tolstoy', N'A historical epic.', CAST(250.00 AS Decimal(10, 2)), N'images/book6.jpg', 2, N'Fiction', 8, 1, CAST(N'2025-05-10' AS Date))
GO
INSERT [dbo].[Books] ([BookId], [Title], [AuthorName], [Description], [Price], [ImageUrl], [TypeId], [BookTypeName], [StockQuantity], [IsActive], [PublishedDate]) VALUES (7, N'The Catcher in the Rye', N'J.D. Salinger', N'Teenage angst.', CAST(140.00 AS Decimal(10, 2)), N'images/book7.jpg', 2, N'Fiction', 25, 1, CAST(N'2025-05-10' AS Date))
GO
INSERT [dbo].[Books] ([BookId], [Title], [AuthorName], [Description], [Price], [ImageUrl], [TypeId], [BookTypeName], [StockQuantity], [IsActive], [PublishedDate]) VALUES (8, N'Brave New World', N'Aldous Huxley', N'A futuristic dystopia.', CAST(200.00 AS Decimal(10, 2)), N'images/book8.jpg', 1, N'Science', 10, 1, CAST(N'2025-05-10' AS Date))
GO
INSERT [dbo].[Books] ([BookId], [Title], [AuthorName], [Description], [Price], [ImageUrl], [TypeId], [BookTypeName], [StockQuantity], [IsActive], [PublishedDate]) VALUES (9, N'Jane Eyre', N'Charlotte Brontë', N'Resilience and romance.', CAST(155.00 AS Decimal(10, 2)), N'images/book9.jpg', 2, N'Fiction', 14, 1, CAST(N'2025-05-10' AS Date))
GO
INSERT [dbo].[Books] ([BookId], [Title], [AuthorName], [Description], [Price], [ImageUrl], [TypeId], [BookTypeName], [StockQuantity], [IsActive], [PublishedDate]) VALUES (10, N'Wuthering Heights', N'Emily Brontë', N'Love and revenge.', CAST(165.00 AS Decimal(10, 2)), N'images/book10.jpg', 2, N'Fiction', 16, 1, CAST(N'2025-05-10' AS Date))
GO
INSERT [dbo].[Books] ([BookId], [Title], [AuthorName], [Description], [Price], [ImageUrl], [TypeId], [BookTypeName], [StockQuantity], [IsActive], [PublishedDate]) VALUES (11, N'Crime and Punishment', N'Fyodor Dostoevsky', N'Guilt and redemption.', CAST(210.00 AS Decimal(10, 2)), N'images/book11.jpg', 2, N'Fiction', 9, 1, CAST(N'2025-05-10' AS Date))
GO
INSERT [dbo].[Books] ([BookId], [Title], [AuthorName], [Description], [Price], [ImageUrl], [TypeId], [BookTypeName], [StockQuantity], [IsActive], [PublishedDate]) VALUES (12, N'Frankenstein', N'Mary Shelley', N'Creation and responsibility.', CAST(195.00 AS Decimal(10, 2)), N'images/book12.jpg', 1, N'Science', 11, 1, CAST(N'2025-05-10' AS Date))
GO
INSERT [dbo].[Books] ([BookId], [Title], [AuthorName], [Description], [Price], [ImageUrl], [TypeId], [BookTypeName], [StockQuantity], [IsActive], [PublishedDate]) VALUES (13, N'Dracula', N'Bram Stoker', N'A vampire tale.', CAST(175.00 AS Decimal(10, 2)), N'images/book13.jpg', 2, N'Fiction', 13, 1, CAST(N'2025-05-10' AS Date))
GO
INSERT [dbo].[Books] ([BookId], [Title], [AuthorName], [Description], [Price], [ImageUrl], [TypeId], [BookTypeName], [StockQuantity], [IsActive], [PublishedDate]) VALUES (14, N'The Odyssey', N'Homer', N'A journey home.', CAST(160.00 AS Decimal(10, 2)), N'images/book14.jpg', 2, N'Fiction', 19, 1, CAST(N'2025-05-10' AS Date))
GO
INSERT [dbo].[Books] ([BookId], [Title], [AuthorName], [Description], [Price], [ImageUrl], [TypeId], [BookTypeName], [StockQuantity], [IsActive], [PublishedDate]) VALUES (15, N'The Iliad', N'Homer', N'Heroism in war.', CAST(160.00 AS Decimal(10, 2)), N'images/book15.jpg', 2, N'Fiction', 17, 1, CAST(N'2025-05-10' AS Date))
GO
SET IDENTITY_INSERT [dbo].[Books] OFF
GO
SET IDENTITY_INSERT [dbo].[Cart] ON 
GO
INSERT [dbo].[Cart] ([CartId], [UserId], [BookId], [Quantity], [DateAdded], [IsActive], [UpdatedDate]) VALUES (13, 2, 11, 1, CAST(N'2025-05-11T13:25:36.027' AS DateTime), 1, CAST(N'2025-05-11T13:25:36.027' AS DateTime))
GO
INSERT [dbo].[Cart] ([CartId], [UserId], [BookId], [Quantity], [DateAdded], [IsActive], [UpdatedDate]) VALUES (14, 2, 14, 1, CAST(N'2025-05-11T14:52:49.690' AS DateTime), 1, CAST(N'2025-05-11T14:52:49.690' AS DateTime))
GO
INSERT [dbo].[Cart] ([CartId], [UserId], [BookId], [Quantity], [DateAdded], [IsActive], [UpdatedDate]) VALUES (15, 2, 11, 1, CAST(N'2025-05-11T14:53:14.653' AS DateTime), 1, CAST(N'2025-05-11T14:53:14.653' AS DateTime))
GO
INSERT [dbo].[Cart] ([CartId], [UserId], [BookId], [Quantity], [DateAdded], [IsActive], [UpdatedDate]) VALUES (16, 2, 13, 1, CAST(N'2025-05-11T15:10:31.707' AS DateTime), 1, CAST(N'2025-05-11T15:10:31.710' AS DateTime))
GO
INSERT [dbo].[Cart] ([CartId], [UserId], [BookId], [Quantity], [DateAdded], [IsActive], [UpdatedDate]) VALUES (17, 2, 10, 1, CAST(N'2025-05-11T15:10:38.847' AS DateTime), 1, CAST(N'2025-05-11T15:10:38.847' AS DateTime))
GO
INSERT [dbo].[Cart] ([CartId], [UserId], [BookId], [Quantity], [DateAdded], [IsActive], [UpdatedDate]) VALUES (18, 2, 10, 1, CAST(N'2025-05-11T15:16:25.793' AS DateTime), 1, CAST(N'2025-05-11T15:16:25.793' AS DateTime))
GO
INSERT [dbo].[Cart] ([CartId], [UserId], [BookId], [Quantity], [DateAdded], [IsActive], [UpdatedDate]) VALUES (19, 2, 10, 1, CAST(N'2025-05-11T15:16:34.823' AS DateTime), 1, CAST(N'2025-05-11T15:16:34.823' AS DateTime))
GO
INSERT [dbo].[Cart] ([CartId], [UserId], [BookId], [Quantity], [DateAdded], [IsActive], [UpdatedDate]) VALUES (20, 2, 14, 1, CAST(N'2025-05-11T15:22:26.677' AS DateTime), 1, CAST(N'2025-05-11T15:22:26.677' AS DateTime))
GO
INSERT [dbo].[Cart] ([CartId], [UserId], [BookId], [Quantity], [DateAdded], [IsActive], [UpdatedDate]) VALUES (21, 2, 13, 1, CAST(N'2025-05-11T15:22:27.640' AS DateTime), 1, CAST(N'2025-05-11T15:22:27.640' AS DateTime))
GO
INSERT [dbo].[Cart] ([CartId], [UserId], [BookId], [Quantity], [DateAdded], [IsActive], [UpdatedDate]) VALUES (22, 2, 13, 1, CAST(N'2025-05-11T15:24:56.313' AS DateTime), 1, CAST(N'2025-05-11T15:24:56.313' AS DateTime))
GO
INSERT [dbo].[Cart] ([CartId], [UserId], [BookId], [Quantity], [DateAdded], [IsActive], [UpdatedDate]) VALUES (23, 2, 14, 1, CAST(N'2025-05-11T15:24:59.540' AS DateTime), 1, CAST(N'2025-05-11T15:24:59.540' AS DateTime))
GO
INSERT [dbo].[Cart] ([CartId], [UserId], [BookId], [Quantity], [DateAdded], [IsActive], [UpdatedDate]) VALUES (24, 2, 13, 1, CAST(N'2025-05-11T15:43:12.100' AS DateTime), 1, CAST(N'2025-05-11T15:43:12.100' AS DateTime))
GO
INSERT [dbo].[Cart] ([CartId], [UserId], [BookId], [Quantity], [DateAdded], [IsActive], [UpdatedDate]) VALUES (25, 2, 10, 1, CAST(N'2025-05-11T20:53:48.330' AS DateTime), 1, CAST(N'2025-05-11T20:53:48.330' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Cart] OFF
GO
SET IDENTITY_INSERT [dbo].[BookTypes] ON 
GO
INSERT [dbo].[BookTypes] ([TypeId], [TypeName]) VALUES (1, N'Fiction')
GO
INSERT [dbo].[BookTypes] ([TypeId], [TypeName]) VALUES (2, N'Non-Fiction')
GO
INSERT [dbo].[BookTypes] ([TypeId], [TypeName]) VALUES (3, N'Science')
GO
INSERT [dbo].[BookTypes] ([TypeId], [TypeName]) VALUES (4, N'Biography')
GO
INSERT [dbo].[BookTypes] ([TypeId], [TypeName]) VALUES (5, N'Fantasy')
GO
SET IDENTITY_INSERT [dbo].[BookTypes] OFF
GO
SET IDENTITY_INSERT [dbo].[Wishlist] ON 
GO
INSERT [dbo].[Wishlist] ([WishlistId], [UserId], [BookId], [AddedOn]) VALUES (22, 0, 14, CAST(N'2025-05-11T21:44:46.157' AS DateTime))
GO
INSERT [dbo].[Wishlist] ([WishlistId], [UserId], [BookId], [AddedOn]) VALUES (23, 0, 15, CAST(N'2025-05-11T21:44:49.620' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Wishlist] OFF
GO
