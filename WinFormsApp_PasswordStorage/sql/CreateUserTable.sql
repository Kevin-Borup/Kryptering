USE EncryptionBase

CREATE TABLE Users (
	Username varchar(30) PRIMARY KEY,
	pws varchar(255),
	Salt varchar(30),
);