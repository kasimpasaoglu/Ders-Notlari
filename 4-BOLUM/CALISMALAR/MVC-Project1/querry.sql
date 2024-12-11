SELECT * FROM Students

DELETE From Students where Id > 20

DBCC CHECKIDENT ('Students', RESEED, 20);

