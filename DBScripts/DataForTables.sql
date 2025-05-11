INSERT INTO [dbo].[Books] ([title], [authorName], [price], [stockquantity], [publisheddate], [Isactive], [TypeId])
VALUES
('The Lost Horizon', 'James Hilton', 12.99, 30, '2020-01-15', 1, 1),
('Future Tense', 'Lisa Holmes', 14.50, 45, '2019-11-20', 1, 2),
('Midnight Sun', 'Stephenie Meyer', 19.99, 50, '2021-08-10', 1, 3),
('Zero Hour', 'Clive Cussler', 11.49, 18, '2018-05-04', 1, 1),
('Crimson Sky', 'Ava Hart', 9.95, 25, '2022-03-11', 1, 2),
('Quantum Code', 'Neil Adams', 15.00, 10, '2021-12-30', 0, 3),
('Echoes of the Past', 'R. L. James', 13.99, 22, '2017-07-22', 1, 1),
('Digital Fortress', 'Dan Brown', 17.50, 60, '2005-04-01', 1, 4),
('Shadows of Time', 'Clara Park', 10.75, 28, '2019-09-15', 1, 2),
('Ocean of Dreams', 'Mira Bell', 8.99, 15, '2020-06-10', 1, 3),

('Broken Circles', 'T. J. Matthews', 16.20, 34, '2021-02-18', 0, 1),
('Fires of Winter', 'Johanna Lindsey', 12.99, 40, '1995-11-05', 1, 2),
('Iron Legacy', 'Wade Steele', 18.00, 12, '2016-03-30', 0, 3),
('The Wandering Earth', 'Cixin Liu', 20.00, 8, '2018-06-01', 1, 4),
('Echoes', 'Marc Levy', 10.00, 17, '2022-08-19', 1, 2),
('City of Gold', 'Wilbur Smith', 13.80, 20, '2019-04-12', 1, 1),
('Vanishing Point', 'John Thomas', 11.49, 26, '2017-12-09', 0, 3),
('The Infinite Loop', 'Sarah H. Lin', 14.95, 30, '2020-07-17', 1, 2),
('Legend of the Star', 'K. A. Hunter', 16.49, 42, '2021-11-23', 1, 1),
('Rainfall', 'Nina Simone', 7.89, 19, '2016-10-03', 0, 4),

('Digital Maze', 'Kevin Bright', 15.75, 23, '2022-01-15', 1, 2),
('Valley of the Kings', 'David Neal', 12.00, 55, '2018-03-27', 1, 3),
('Final Warning', 'James Patterson', 13.95, 38, '2014-09-13', 1, 1),
('Lost City', 'Clive Cussler', 16.25, 20, '2003-05-25', 1, 4),
('The Hollow Man', 'Dan Simmons', 11.30, 13, '2000-07-09', 0, 2),
('Night Shift', 'Stephen King', 9.99, 40, '1978-11-18', 1, 1),
('Beyond the Wall', 'A. G. Martin', 18.20, 9, '2016-06-21', 0, 3),
('Afterlife', 'Julia Stone', 10.50, 27, '2019-01-10', 1, 2),
('Storm Chasers', 'Chris Smith', 13.80, 35, '2020-04-04', 1, 3),
('The Second Realm', 'Daniel Fox', 19.99, 14, '2021-05-08', 1, 1),

('Solar Flare', 'R. T. Martin', 12.40, 31, '2019-11-11', 1, 2),
('Cold Steel', 'Tamara Ross', 15.99, 22, '2018-12-12', 0, 4),
('Darkness Falls', 'Rachel Lee', 11.20, 36, '2021-03-15', 1, 3),
('Blaze', 'Richard Bachman', 10.99, 42, '2007-01-01', 0, 1),
('Dragons Claw', 'Peter ODonnell', 13.65, 39, '1979-08-17', 1, 2),
('Red Shift', 'Alan Garner', 17.50, 28, '1973-02-06', 1, 3),
('Dust and Shadow', 'Lyndsay Faye', 14.45, 19, '2009-05-01', 1, 1),
('The Fifth Season', 'N. K. Jemisin', 16.00, 44, '2015-08-04', 1, 4),
('The Silent Patient', 'Alex Michaelides', 12.70, 33, '2019-02-05', 1, 2),
('Project Hail Mary', 'Andy Weir', 18.99, 60, '2021-05-04', 1, 3),

('Artificial Dawn', 'Lia Carter', 10.25, 21, '2022-10-15', 1, 1),
('Binary Code', 'Alan Steele', 9.75, 12, '2016-04-20', 0, 2),
('Galactic Rift', 'E. M. Harding', 14.80, 18, '2018-09-27', 1, 3),
('Neon Horizon', 'Zara Grant', 11.99, 16, '2020-12-01', 1, 2),
('Time Loop', 'Leo Park', 13.55, 24, '2023-01-01', 1, 1),
('Crimson Logic', 'Harvey Lee', 12.60, 30, '2022-05-30', 1, 3),
('The Long Tomorrow', 'Leigh Brackett', 15.00, 11, '1955-07-20', 0, 2),
('Empire Rising', 'J. S. Stone', 16.20, 20, '2021-09-09', 1, 4),
('Infinite Drift', 'Naomi Reed', 11.10, 29, '2020-03-12', 1, 3),
('The Algorithm', 'Vera Xu', 17.25, 32, '2023-07-28', 1, 2);


INSERT INTO [dbo].[BookTypes] ([TypeName])
VALUES
('Fiction'),
('Non-Fiction'),
('Science Fiction'),
('Fantasy'),
('Mystery'),
('Biography'),
('Historical'),
('Romance'),
('Thriller'),
('Self-Help');



INSERT INTO [dbo].[Users] ([Username], [password], [Firstname], [Lastname], [Address], [Phone], [MailId], [UserType])
VALUES
('admin', 'pasword', 'John', 'Doe', '123 Elm Street, Springfield', '123-456-7890', 'jdoe@example.com', 1),
('asmith', 'secure456', 'Anna', 'Smith', '456 Oak Avenue, Metropolis', '234-567-8901', 'asmith@example.com', 2),
('bjones', 'myPass789', 'Bob', 'Jones', '789 Pine Road, Gotham', '345-678-9012', 'bjones@example.com', 2),
('mjane', 'abc@321', 'Mary', 'Jane', '321 Maple Lane, Star City', '456-789-0123', 'mjane@example.com', 1),
('wrogers', 'winter2025', 'Will', 'Rogers', '101 Sunset Blvd, Central City', '567-890-1234', 'wrogers@example.com', 2),
('klee', 'sunshine22', 'Karen', 'Lee', '202 Sunrise Ave, Coast City', '678-901-2345', 'klee@example.com', 1),
('tparker', 'web456!', 'Tom', 'Parker', '404 Hero Lane, Metropolis', '789-012-3456', 'tparker@example.com', 2),
('rsanchez', 'portal1', 'Rick', 'Sanchez', '999 Portal Way, Dimension C-137', '890-123-4567', 'rsanchez@example.com', 3),
('mjohnson', 'password123', 'Mark', 'Johnson', '555 Ocean Dr, San Andreas', '901-234-5678', 'mjohnson@example.com', 1),
('elane', 'crypto999', 'Eva', 'Lane', '909 Silicon Valley Blvd, Palo Alto', '012-345-6789', 'elane@example.com', 2),

('rwhite', 'breakBad', 'Rick', 'White', '100 Desert St, Albuquerque', '213-456-7890', 'rwhite@example.com', 2),
('ssmith', 'ssPass2025', 'Susan', 'Smith', '300 Main Street, Hill Valley', '324-567-8901', 'ssmith@example.com', 1),
('kturner', 'test567', 'Kevin', 'Turner', '888 River Rd, Twin Peaks', '435-678-9012', 'kturner@example.com', 1),
('dlee', 'hello123', 'Diana', 'Lee', '200 Liberty St, New York', '546-789-0123', 'dlee@example.com', 2),
('amorris', 'qwerty88', 'Alan', 'Morris', '901 Freedom Ave, Chicago', '657-890-1234', 'amorris@example.com', 2),
('hcarter', 'newpass001', 'Helen', 'Carter', '342 Sunshine Blvd, Miami', '768-901-2345', 'hcarter@example.com', 1),
('bwilliams', 'testpass02', 'Bruce', 'Williams', '473 Autumn Lane, Seattle', '879-012-3456', 'bwilliams@example.com', 2),
('cmonroe', 'admin321', 'Cathy', 'Monroe', '654 Winter Dr, Boston', '980-123-4567', 'cmonroe@example.com', 3),
('dking', 'dragonfire', 'David', 'King', '127 Castle Rd, Westeros', '091-234-5678', 'dking@example.com', 1),
('ychoi', 'spring2025', 'Yuna', 'Choi', '789 Blossom St, Seoul', '102-345-6789', 'ychoi@example.com', 2);



INSERT INTO [dbo].[Wishlist] ([UserId], [BookId], [AddedOn])
VALUES
(1, 5, '2025-04-01 10:15:00'),
(2, 10, '2025-04-02 11:20:00'),
(3, 12, '2025-04-03 09:05:00'),
(4, 8, '2025-04-04 14:30:00'),
(5, 20, '2025-04-05 16:45:00'),
(6, 2, '2025-04-06 08:50:00'),
(7, 17, '2025-04-07 13:25:00'),
(8, 22, '2025-04-08 15:00:00'),
(9, 30, '2025-04-09 12:15:00'),
(10, 1, '2025-04-10 10:30:00'),

(11, 45, '2025-04-11 09:40:00'),
(12, 6, '2025-04-12 11:05:00'),
(13, 14, '2025-04-13 13:50:00'),
(14, 19, '2025-04-14 15:25:00'),
(15, 3, '2025-04-15 16:10:00'),
(16, 26, '2025-04-16 10:20:00'),
(17, 39, '2025-04-17 09:55:00'),
(18, 11, '2025-04-18 08:45:00'),
(19, 28, '2025-04-19 14:10:00'),
(20, 49, '2025-04-20 12:35:00'),

(1, 21, '2025-04-21 10:30:00'),
(2, 37, '2025-04-22 11:40:00'),
(3, 4, '2025-04-23 13:15:00'),
(4, 25, '2025-04-24 16:00:00'),
(5, 32, '2025-04-25 14:20:00'),
(6, 43, '2025-04-26 15:35:00'),
(7, 24, '2025-04-27 12:05:00'),
(8, 36, '2025-04-28 09:50:00'),
(9, 7, '2025-04-29 11:25:00'),
(10, 18, '2025-04-30 10:10:00');
