create database PhamMinhTuan_231230946_de02;
go
use PhamMinhTuan_231230946_de02;

CREATE TABLE pmtCatalog (
    pmtId INT IDENTITY(1,1) PRIMARY KEY,     
    pmtCateName NVARCHAR(100) NOT NULL,      
    pmtCatePrice FLOAT CHECK (pmtCatePrice >= 0), 
    pmtCateQty INT CHECK (pmtCateQty >= 0),  
    pmtPicture NVARCHAR(255),              
    pmtCateActive BIT DEFAULT 1       
);
GO

INSERT INTO pmtCatalog (pmtCateName, pmtCatePrice, pmtCateQty, pmtPicture, pmtCateActive)
VALUES 
(N'Áo Thun Nam', 150000, 50, N'/images/aothun.jpg', 1),
(N'Quần Jean Nữ', 320000, 30, N'/images/quanjean.jpg', 1),
(N'Phạm Minh Tuấn-231230946-CNTT2-K64', 0, 1, N'', 0);
GO