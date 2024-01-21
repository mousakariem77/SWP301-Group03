CREATE DATABASE Course_Web
GO

USE Course_Web
GO

CREATE TABLE [admin]
(
    [adminID] VARCHAR(10) PRIMARY KEY,
	[name] NVARCHAR(50),
    [username] VARCHAR(50) NOT NULL,
    [password] VARCHAR(50) NOT NULL
);
GO

CREATE TABLE [learner]
(
    [learnerID] VARCHAR(10) PRIMARY KEY,
	[wallet] DECIMAL(10, 2),
    [status] INT DEFAULT 0
);
GO

CREATE TABLE [instructor]
(
    [instructorID] VARCHAR(10) PRIMARY KEY,
	[income] DECIMAL(10, 2),
    [status] INT DEFAULT 0
);
GO

CREATE TABLE [user]
(
    [userID] VARCHAR(10) PRIMARY KEY,
    [first_name] NVARCHAR(50),
    [last_name] NVARCHAR(50),
	[gender] NVARCHAR(10),
    [birthday] DATE,
	[phoneNumber] VARCHAR(20),
    [email] VARCHAR(320),
    [email_verified] BIT DEFAULT 0 NOT NULL,
	[country] NVARCHAR(255),
	[role] NVARCHAR(255),
    [username] VARCHAR(50)   NOT NULL,
    [password] VARCHAR(50)   NOT NULL,
    [picture] TEXT,
	[registration_Date] DATE,
	FOREIGN KEY (userID) REFERENCES [learner](learnerID),
	FOREIGN KEY (userID) REFERENCES [instructor](instructorID)
);
GO

CREATE TABLE [categories] (
    [categoryID] VARCHAR(10) PRIMARY KEY,
    [category_name] NVARCHAR(255),
    [description] NTEXT
);
GO

CREATE TABLE [courses] (
    [courseID] VARCHAR(10) PRIMARY KEY,
    [course_name] NVARCHAR(255),
    [description] NTEXT,
    [categoryID] VARCHAR(10),
	[picture] TEXT,
	[total_time] INT DEFAULT 0,
    [price] DECIMAL(10, 2),
    [startDate] DATE,
    [endDate] DATE,
	[rating] INT CHECK (rating >= 1 AND rating <= 5),
	[number_of_rated] INT DEFAULT 0,
    [status] NVARCHAR(20),
    FOREIGN KEY (categoryID) REFERENCES [categories](categoryID)
);
GO

CREATE TABLE [instruct]
(
    [instructID] VARCHAR(10) PRIMARY KEY,
    [courseID] VARCHAR(10),
    [instructorID] VARCHAR(10),
    FOREIGN KEY (instructorID) REFERENCES [instructor](instructorID),
    FOREIGN KEY (courseID) REFERENCES [courses](courseID),
    UNIQUE (instructorID, courseID)
);
GO

CREATE TABLE [chapter]
(
    [chapterID] VARCHAR(10) PRIMARY KEY,
    [courseID] VARCHAR(10),
    [chapter_name] NVARCHAR(50),
    [index] INT,
    [description] NTEXT,
    [total_time] INT DEFAULT 0,
    FOREIGN KEY (courseID) REFERENCES [courses](courseID)
);
GO

CREATE TABLE [lesson]
(
    [lessonID] VARCHAR(10) PRIMARY KEY,
    [chapterID] VARCHAR(10),
    [lesson_name] NVARCHAR(50),
    [description] NTEXT,
    [percent_to_passed] INT DEFAULT 80,
    [must_be_completed] BIT DEFAULT 1,
    [content] NTEXT,
    [index] INT,
    [type] INT,
    [time] INT DEFAULT 0 ,
    FOREIGN KEY (chapterID) REFERENCES [chapter](chapterID)
);
GO

CREATE TABLE [course_progress]
(
    [course_progressID] INT IDENTITY (1,1)PRIMARY KEY,
    [learnerID] VARCHAR(10),
    [courseID] VARCHAR(10),
    [enrolled] BIT DEFAULT 0,
    [completed] BIT DEFAULT 0,
    [progress_percent] INT DEFAULT 0,
    [rated] BIT DEFAULT 0,
    [rating] INT CHECK (rating >= 1 AND rating <= 5),
    [total_time] INT DEFAULT 0,
    [start_at] DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (learnerID) REFERENCES [learner](learnerID),
    FOREIGN KEY (courseID) REFERENCES [courses](courseID)
);
GO

CREATE TABLE [chapter_progress]
(
    [chapter_progressID] INT IDENTITY (1,1) PRIMARY KEY,
    [chapterID] VARCHAR(10),
    [course_progressID] INT,
    [progress_percent] INT DEFAULT 0,
    [completed] BIT DEFAULT 0,
    [total_time] INT DEFAULT 0,
    [start_at] DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (chapterID) REFERENCES [chapter](chapterID),
    FOREIGN KEY (course_progressID) REFERENCES [course_progress](course_progressID)
);
GO

CREATE TABLE [lesson_progress]
(
    [lesson_progressID] INT IDENTITY (1,1) PRIMARY KEY,
    [lessonID] VARCHAR(10),
    [chapter_progressID] INT,
    [progress_percent] INT DEFAULT 0,
    [completed] BIT DEFAULT 0,
    [start_at] DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (lessonID) REFERENCES [lesson](lessonID),
    FOREIGN KEY (chapter_progressID) REFERENCES [chapter_progress](chapter_progressID)
);
GO

CREATE TABLE [question]
(
    [questionID] INT IDENTITY (1,1) PRIMARY KEY,
    [lessonID] VARCHAR(10),
	[startTime] DATETIME DEFAULT CURRENT_TIMESTAMP,
    [endTime] DATETIME DEFAULT CURRENT_TIMESTAMP,
    [index] INT,
    [content] NTEXT,
    [type] INT,
    [mark] INT DEFAULT 1,
    FOREIGN KEY (lessonID) REFERENCES [lesson](lessonID)
);
GO

CREATE TABLE [answer]
(
    [answerID] INT IDENTITY (1,1) PRIMARY KEY,
    [questionID] INT,
    [content] NTEXT,
    [correct] BIT DEFAULT 0,
    --True: 1, False: 0
    FOREIGN KEY (questionID) REFERENCES [question](questionID)
);
GO

CREATE TABLE [question_result]
(
    [question_resultID] INT IDENTITY (1,1) PRIMARY KEY,
    [lessonID] VARCHAR(10),
    [lesson_progressID] INT,
    [number_of_correct_answer] INT,
    [number_of_question] INT,
    [mark] INT,
    [finished] BIT DEFAULT 0,
    [start_at]  DATETIME,
    [end_at]  DATETIME,
    FOREIGN KEY (lessonID) REFERENCES [lesson](lessonID),
    FOREIGN KEY (lesson_progressID) REFERENCES [lesson_progress](lesson_progressID)
);
GO

CREATE TABLE [chosen_answer]
(
    [chosen_answerID] INT IDENTITY (1,1)PRIMARY KEY,
    [questionID] INT,
    [answerID] INT,
    [question_resultID] INT,
    [correct] BIT DEFAULT 0,
    FOREIGN KEY (question_resultID) REFERENCES [question_result](question_resultID),
    FOREIGN KEY (answerID) REFERENCES [answer](answerID),
    FOREIGN KEY (questionID) REFERENCES [question](questionID)
);
GO

CREATE TABLE [transaction]
(
    [transactionID] INT IDENTITY (1,1)PRIMARY KEY,
    [learnerID] VARCHAR(10),
    [courseID] VARCHAR(10),
	[enrollment_date] DATE,
    [origin_price]  NUMERIC(10, 2),
    [price] NUMERIC(10, 2),
    --[type] INT DEFAULT 0,
    [description] NTEXT,
    [status] INT DEFAULT 0,
    FOREIGN KEY (learnerID) REFERENCES [learner](learnerID),
    FOREIGN KEY (courseID) REFERENCES [courses](courseID)
);
GO

CREATE TABLE [notification] (
    [notificationID] INT PRIMARY KEY,
    [receiverID] VARCHAR(10),
	[receiverType] NVARCHAR(50), --- Loại người nhận (learner, instructor, admin, etc.)
    [messageType] NVARCHAR(50), -- Loại thông báo (ví dụ: Announcement, QuizReminder, etc.)
    [message] NTEXT,
    [sent_date] DATETIME,
    [isRead] BIT, -- Kiểm tra xem thông báo đã được đọc chưa
	FOREIGN KEY (ReceiverID) REFERENCES [admin](adminID) ON DELETE CASCADE,
    FOREIGN KEY (ReceiverID) REFERENCES [learner](learnerID) ON DELETE CASCADE,
    FOREIGN KEY (ReceiverID) REFERENCES [instructor](instructorID) ON DELETE CASCADE
);
GO

CREATE TABLE [discountCodes] (
    [discountCodeID] VARCHAR(10) PRIMARY KEY,
    [instructorID] VARCHAR(10),
    [courseID] VARCHAR(10),
    [code] NVARCHAR(20) UNIQUE,
    [percent_discount] INT, --tỉ lệ phần trăm giảm giá
	[start_at] DATETIME,
    [end_at]   DATETIME,
    [IsActive] BIT,
    FOREIGN KEY (instructorID) REFERENCES [instructor](instructorID),
    FOREIGN KEY (courseID) REFERENCES [courses](courseID)
);

CREATE TABLE [review] (
    [reviewID] INT PRIMARY KEY,
    [learnerID] VARCHAR(10),
    [instructorID] VARCHAR(10),
	[courseID] VARCHAR(10),
    [rating] INT CHECK (Rating >= 1 AND Rating <= 5),
    [comment] NTEXT,
    [img] TEXT,
    [icon] VARCHAR(50),
    [review_date] DATE,
    FOREIGN KEY (learnerID) REFERENCES [learner](learnerID),
    FOREIGN KEY (instructorID) REFERENCES [instructor](instructorID),
	FOREIGN KEY (courseID) REFERENCES [courses](courseID)
);
GO

--------------------------------------các bảng nâng cao, mở rộng nếu kịp---------------------------------------
CREATE TABLE [payment] (
    [paymentID] VARCHAR(10) PRIMARY KEY,
    [learnerID] VARCHAR(10),
	[account_number] INT,
	[account_name] NVARCHAR(255),
	[bank] NVARCHAR(255),
    [status] BIT DEFAULT 0,
    FOREIGN KEY (learnerID) REFERENCES learner(learnerID),
);
GO

CREATE TABLE [AdvertisingPackage]
(
    [packageID] INT IDENTITY (1,1) PRIMARY KEY,
    [instructorID] VARCHAR(10),
    [startDate] DATE,
    [endDate] DATE,
    [price] NUMERIC(10, 2),
    [status] INT DEFAULT 0,
    FOREIGN KEY (instructorID) REFERENCES instructor(instructorID)
);

CREATE TABLE [Receiver_Messages] (
    [MessageID] INT PRIMARY KEY,
	[UserID] VARCHAR(10),
    [MessageType] NVARCHAR(50), -- Loại tin nhắn (ví dụ: TextMessage, ImageMessage, etc.)
    [MessageText] NTEXT,
    [SentDate] DATETIME,
    [IsRead] BIT, -- Kiểm tra xem tin nhắn đã được đọc chưa
    FOREIGN KEY (UserID) REFERENCES learner(learnerID) ON DELETE CASCADE,
    FOREIGN KEY (UserID) REFERENCES instructor(instructorID) ON DELETE CASCADE
	-- tự động xóa các tin nhắn liên quan khi một sinh viên hoặc giáo viên bị xóa khỏi hệ thống
);
GO

CREATE TABLE [Send_Messages] 
(
    [MessageID] INT PRIMARY KEY,
	[UserID] VARCHAR(10),
    [IsSender] BIT,
    [MessageType] NVARCHAR(50), -- Loại tin nhắn (ví dụ: TextMessage, ImageMessage, etc.)
    [MessageText] NTEXT,
    [SentDate] DATETIME,
    [IsRead] BIT, -- Kiểm tra xem tin nhắn đã được đọc chưa
    FOREIGN KEY (UserID) REFERENCES learner(learnerID) ON DELETE CASCADE,
    FOREIGN KEY (UserID) REFERENCES instructor(instructorID) ON DELETE CASCADEE
	-- tự động xóa các tin nhắn liên quan khi một sinh viên hoặc giáo viên bị xóa khỏi hệ thống
);
GO
