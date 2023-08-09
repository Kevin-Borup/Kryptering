USE EncryptionBase

CREATE TABLE Users (
	Username varchar(30) PRIMARY KEY,
	pws nvarchar(44),
	Salt nvarchar(44)
);