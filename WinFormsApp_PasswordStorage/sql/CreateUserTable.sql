USE EncryptionBase

CREATE TABLE Users (
	Username varchar(30) PRIMARY KEY,
	pws varbinary(32),
	Salt varbinary(32),
);