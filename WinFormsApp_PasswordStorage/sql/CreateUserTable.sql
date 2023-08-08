USE EncryptionBase

CREATE TABLE Users (
	Username varchar(255) PRIMARY KEY,
	pws varchar(30),
	Salt varchar(30),
);