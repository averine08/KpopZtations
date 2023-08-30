DELETE FROM Customer;
DBCC CHECKIDENT (Customer, RESEED, 0);

SET IDENTITY_INSERT [dbo].[Customer] ON
INSERT INTO [dbo].[Customer] ([CustomerID], [CustomerName], [CustomerEmail], [CustomerPassword], [CustomerGender], [CustomerAddress], [CustomerRole]) VALUES (1, N'Admin', N'admin@mail.com', N'admin1234', N'Female', N'Jakarta Street', N'ADM')
INSERT INTO [dbo].[Customer] ([CustomerID], [CustomerName], [CustomerEmail], [CustomerPassword], [CustomerGender], [CustomerAddress], [CustomerRole]) VALUES (2, N'John Brown', N'john.brown@mail.com', N'john1234', N'Male', N'Johnny Boy Street', N'CST')
INSERT INTO [dbo].[Customer] ([CustomerID], [CustomerName], [CustomerEmail], [CustomerPassword], [CustomerGender], [CustomerAddress], [CustomerRole]) VALUES (3, N'Amanda', N'amanda@mail.com', N'amanda1234', N'Female', N'Dolly Street', N'CST')
INSERT INTO [dbo].[Customer] ([CustomerID], [CustomerName], [CustomerEmail], [CustomerPassword], [CustomerGender], [CustomerAddress], [CustomerRole]) VALUES (4, N'Troye', N'troye@mail.com', N'troye1234', N'Male', N'Avenue Street', N'CST')
INSERT INTO [dbo].[Customer] ([CustomerID], [CustomerName], [CustomerEmail], [CustomerPassword], [CustomerGender], [CustomerAddress], [CustomerRole]) VALUES (5, N'Anthony', N'anthony@mail.com', N'anthony1234', N'Male', N'Soprano Street', N'CST')
INSERT INTO [dbo].[Customer] ([CustomerID], [CustomerName], [CustomerEmail], [CustomerPassword], [CustomerGender], [CustomerAddress], [CustomerRole]) VALUES (6, N'Robbie', N'robbie@mail.com', N'robbie1234', N'Female', N'Roman Street', N'CST')
SET IDENTITY_INSERT [dbo].[Customer] OFF

DELETE FROM Artist;
DBCC CHECKIDENT (Artist, RESEED, 0);

SET IDENTITY_INSERT [dbo].[Artist] ON
INSERT INTO [dbo].[Artist] ([ArtistID], [ArtistName], [ArtistImage]) VALUES (1, N'NewJeans', N'638058485179546128.jfif')
INSERT INTO [dbo].[Artist] ([ArtistID], [ArtistName], [ArtistImage]) VALUES (2, N'LOONA', N'638058489004609070.jfif')
INSERT INTO [dbo].[Artist] ([ArtistID], [ArtistName], [ArtistImage]) VALUES (3, N'LADIES'' CODE', N'638058554486609538.jfif')
INSERT INTO [dbo].[Artist] ([ArtistID], [ArtistName], [ArtistImage]) VALUES (4, N'Red Velvet', N'638059446432559006.jfif')
INSERT INTO [dbo].[Artist] ([ArtistID], [ArtistName], [ArtistImage]) VALUES (5, N'SHINEE', N'638059447901481658.jfif')
INSERT INTO [dbo].[Artist] ([ArtistID], [ArtistName], [ArtistImage]) VALUES (6, N'Wonder Girls', N'638059450808002463.jfif')
SET IDENTITY_INSERT [dbo].[Artist] OFF

DELETE FROM Album;
DBCC CHECKIDENT (Album, RESEED, 0);

SET IDENTITY_INSERT [dbo].[Album] ON
INSERT INTO [dbo].[Album] ([AlbumID], [ArtistID], [AlbumName], [AlbumImage], [AlbumPrice], [AlbumStock], [AlbumDescription]) VALUES (1, 1, N'Kid A', N'638058597622333864.jfif', 100000, 5, N'Kid A is the fourth studio album by the English rock band Radiohead, released on 2 October 2000 by Parlophone. It was recorded with their producer, Nigel Godrich, in Paris, Copenhagen, Gloucestershire and Oxfordshire.')
INSERT INTO [dbo].[Album] ([AlbumID], [ArtistID], [AlbumName], [AlbumImage], [AlbumPrice], [AlbumStock], [AlbumDescription]) VALUES (2, 1, N'OK Computer', N'638058600253472624.jpg', 50000, 25, N'OK Computer is the third studio album by the English rock band Radiohead, released in the UK on 16 June 1997 by EMI.')
INSERT INTO [dbo].[Album] ([AlbumID], [ArtistID], [AlbumName], [AlbumImage], [AlbumPrice], [AlbumStock], [AlbumDescription]) VALUES (3, 2, N'The Bends', N'638058602735846856.jpg', 150000, 10, N'The Bends is the second studio album by the English rock band Radiohead, released on 13 March 1995 by Parlophone. It was produced by John Leckie, with extra production by Radiohead, Nigel Godrich and Jim Warren.')
INSERT INTO [dbo].[Album] ([AlbumID], [ArtistID], [AlbumName], [AlbumImage], [AlbumPrice], [AlbumStock], [AlbumDescription]) VALUES (4, 2, N'Hail to the Thief', N'638058717003784490.jpg', 200000, 20, N'Hail to the Thief is the sixth studio album by the English rock band Radiohead. It was released on 9 June 2003 through Parlophone internationally and a day later through Capitol Records in the United States.')
INSERT INTO [dbo].[Album] ([AlbumID], [ArtistID], [AlbumName], [AlbumImage], [AlbumPrice], [AlbumStock], [AlbumDescription]) VALUES (5, 3, N'A Moon Shaped Pool', N'638059437442094314.jfif', 250000, 15, N'A Moon Shaped Pool is the ninth studio album by the English rock band Radiohead. It was released digitally on 8 May 2016, and physically on 17 June 2016 through XL Recordings. ')
INSERT INTO [dbo].[Album] ([AlbumID], [ArtistID], [AlbumName], [AlbumImage], [AlbumPrice], [AlbumStock], [AlbumDescription]) VALUES (6, 4, N'Pablo Honey', N'638059438205501702.jpg', 300000, 10, N'Pablo Honey is the debut studio album by the English rock band Radiohead, released on 22 February 1993 in the UK by Parlophone and on 20 April in the US by Capitol Records.')
INSERT INTO [dbo].[Album] ([AlbumID], [ArtistID], [AlbumName], [AlbumImage], [AlbumPrice], [AlbumStock], [AlbumDescription]) VALUES (7, 5, N'In Rainbows', N'638059451370799986.jfif', 50000, 15, N'In Rainbows is the seventh studio album by the English rock band Radiohead. It was self-released on 10 October 2007 as a pay-what-you-want download.')
INSERT INTO [dbo].[Album] ([AlbumID], [ArtistID], [AlbumName], [AlbumImage], [AlbumPrice], [AlbumStock], [AlbumDescription]) VALUES (8, 6, N'The King of Limbs', N'638059449025055368.jpg', 100000, 10, N'The King of Limbs is the eighth studio album by the English rock band Radiohead.')
INSERT INTO [dbo].[Album] ([AlbumID], [ArtistID], [AlbumName], [AlbumImage], [AlbumPrice], [AlbumStock], [AlbumDescription]) VALUES (9, 6, N'Amnesiac', N'638059449905363164.jpg', 150000, 20, N'Amnesiac is the fifth studio album by the English rock band Radiohead, released on 30 May 2001 by EMI subsidiaries Parlophone and Capitol Records.')
SET IDENTITY_INSERT [dbo].[Album] OFF

DELETE FROM Cart;
INSERT INTO [dbo].[Cart] ([CustomerID], [AlbumID], [Qty]) VALUES (2, 1, 2)
INSERT INTO [dbo].[Cart] ([CustomerID], [AlbumID], [Qty]) VALUES (3, 2, 3)
INSERT INTO [dbo].[Cart] ([CustomerID], [AlbumID], [Qty]) VALUES (2, 3, 4)
INSERT INTO [dbo].[Cart] ([CustomerID], [AlbumID], [Qty]) VALUES (2, 5, 1)
INSERT INTO [dbo].[Cart] ([CustomerID], [AlbumID], [Qty]) VALUES (3, 4, 4)
INSERT INTO [dbo].[Cart] ([CustomerID], [AlbumID], [Qty]) VALUES (3, 6, 5)
INSERT INTO [dbo].[Cart] ([CustomerID], [AlbumID], [Qty]) VALUES (4, 8, 6)
INSERT INTO [dbo].[Cart] ([CustomerID], [AlbumID], [Qty]) VALUES (4, 9, 3)
INSERT INTO [dbo].[Cart] ([CustomerID], [AlbumID], [Qty]) VALUES (3, 7, 2)

DELETE FROM TransactionHeader;
DBCC CHECKIDENT (TransactionHeader, RESEED, 0);

SET IDENTITY_INSERT [dbo].[TransactionHeader] ON
INSERT INTO [dbo].[TransactionHeader] ([TransactionID], [TransactionDate], [CustomerID]) VALUES (1, N'2023-06-16', 2)
INSERT INTO [dbo].[TransactionHeader] ([TransactionID], [TransactionDate], [CustomerID]) VALUES (2, N'2023-07-21', 3)
INSERT INTO [dbo].[TransactionHeader] ([TransactionID], [TransactionDate], [CustomerID]) VALUES (3, N'2023-11-02', 2)
INSERT INTO [dbo].[TransactionHeader] ([TransactionID], [TransactionDate], [CustomerID]) VALUES (4, N'2023-11-03', 4)
INSERT INTO [dbo].[TransactionHeader] ([TransactionID], [TransactionDate], [CustomerID]) VALUES (5, N'2023-12-13', 3)
SET IDENTITY_INSERT [dbo].[TransactionHeader] OFF

DELETE FROM TransactionDetail;
INSERT INTO [dbo].[TransactionDetail] ([TransactionID], [AlbumID], [Qty]) VALUES (1, 1, 3)
INSERT INTO [dbo].[TransactionDetail] ([TransactionID], [AlbumID], [Qty]) VALUES (1, 2, 5)
INSERT INTO [dbo].[TransactionDetail] ([TransactionID], [AlbumID], [Qty]) VALUES (1, 5, 1)
INSERT INTO [dbo].[TransactionDetail] ([TransactionID], [AlbumID], [Qty]) VALUES (2, 3, 4)
INSERT INTO [dbo].[TransactionDetail] ([TransactionID], [AlbumID], [Qty]) VALUES (2, 4, 8)
INSERT INTO [dbo].[TransactionDetail] ([TransactionID], [AlbumID], [Qty]) VALUES (2, 5, 2)
INSERT INTO [dbo].[TransactionDetail] ([TransactionID], [AlbumID], [Qty]) VALUES (3, 6, 1)
INSERT INTO [dbo].[TransactionDetail] ([TransactionID], [AlbumID], [Qty]) VALUES (3, 7, 1)
INSERT INTO [dbo].[TransactionDetail] ([TransactionID], [AlbumID], [Qty]) VALUES (4, 8, 1)
INSERT INTO [dbo].[TransactionDetail] ([TransactionID], [AlbumID], [Qty]) VALUES (5, 1, 1)
INSERT INTO [dbo].[TransactionDetail] ([TransactionID], [AlbumID], [Qty]) VALUES (5, 2, 1)
INSERT INTO [dbo].[TransactionDetail] ([TransactionID], [AlbumID], [Qty]) VALUES (5, 6, 1)
INSERT INTO [dbo].[TransactionDetail] ([TransactionID], [AlbumID], [Qty]) VALUES (5, 8, 1)
INSERT INTO [dbo].[TransactionDetail] ([TransactionID], [AlbumID], [Qty]) VALUES (5, 9, 1)