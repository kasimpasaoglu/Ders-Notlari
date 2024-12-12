SELECT * FROM Students

DELETE From Students where Id > 20

DBCC CHECKIDENT ('Students', RESEED, 20);

INSERT INTO Students (Name, LastName, Email, Phone, CitizenshipId, BirthDate, RegDate)
VALUES
('Hasan', 'Yıldız', 'hasan.yildiz@gmail.com', '05351234567', '12345678910', '1998-03-14', GETDATE()),
('Merve', 'Koç', 'merve.koc@yahoo.com', '05361234567', '12345678911', '2000-05-22', GETDATE()),
('Ali', 'Şahin', 'ali.sahin@example.com', '05371234567', '12345678912', '1995-10-02', GETDATE()),
('Fatma', 'Kaya', 'fatma.kaya@gmail.com', '05381234567', '12345678913', '1997-01-15', GETDATE()),
('Zeynep', 'Yılmaz', 'zeynep.yilmaz@gmail.com', '05391234567', '12345678914', '2003-07-25', GETDATE()),
('Mehmet', 'Eren', 'mehmet.eren@hotmail.com', '05401234567', '12345678915', '1999-11-30', GETDATE()),
('Ayşe', 'Demir', 'ayse.demir@gmail.com', '05411234567', '12345678916', '1996-04-12', GETDATE()),
('Burak', 'Güler', 'burak.guler@gmail.com', '05421234567', '12345678917', '2002-02-07', GETDATE()),
('Cansu', 'Öztürk', 'cansu.ozturk@gmail.com', '05431234567', '12345678918', '2001-06-19', GETDATE()),
('Esra', 'Polat', 'esra.polat@yahoo.com', '05441234567', '12345678919', '1998-09-09', GETDATE()),
('Hüseyin', 'Aksoy', 'huseyin.aksoy@gmail.com', '05451234567', '12345678920', '1997-12-13', GETDATE()),
('Deniz', 'Çelik', 'deniz.celik@example.com', '05461234567', '12345678921', '2004-08-11', GETDATE()),
('Can', 'Kurt', 'can.kurt@hotmail.com', '05471234567', '12345678922', '2000-10-17', GETDATE()),
('Gül', 'Tekin', 'gul.tekin@gmail.com', '05481234567', '12345678923', '1999-03-05', GETDATE()),
('Eren', 'Yavuz', 'eren.yavuz@gmail.com', '05491234567', '12345678924', '1996-06-30', GETDATE()),
('Deniz', 'Arslan', 'deniz.arslan@gmail.com', '05501234567', '12345678925', '1995-11-21', GETDATE()),
('Canan', 'Şimşek', 'canan.simsek@example.com', '05511234567', '12345678926', '2003-01-08', GETDATE()),
('Ahmet', 'Işık', 'ahmet.isik@gmail.com', '05521234567', '12345678927', '2002-07-14', GETDATE()),
('Elif', 'Aydın', 'elif.aydin@gmail.com', '05531234567', '12345678928', '1998-12-19', GETDATE()),
('Murat', 'Kurtuluş', 'murat.kurtulus@gmail.com', '05541234567', '12345678929', '1997-09-15', GETDATE());

INSERT INTO Students (Name, LastName, Email, Phone, CitizenshipId, BirthDate, RegDate)
VALUES
('Büşra', 'Arslan', 'busra.arslan@gmail.com', '05352123456', '12345678930', '2001-03-14', DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 1460) * -1, GETDATE())),
('Kerem', 'Çelik', 'kerem.celik@example.com', '05353123456', '12345678931', '2002-12-10', DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 1460) * -1, GETDATE())),
('Ece', 'Koç', 'ece.koc@yahoo.com', '05354123456', '12345678932', '1999-05-22', DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 1460) * -1, GETDATE())),
('Barış', 'Kaya', 'baris.kaya@gmail.com', '05355123456', '12345678933', '1995-09-19', DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 1460) * -1, GETDATE())),
('Serap', 'Yıldız', 'serap.yildiz@gmail.com', '05356123456', '12345678934', '2004-07-15', DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 1460) * -1, GETDATE())),
('Emre', 'Demir', 'emre.demir@hotmail.com', '05357123456', '12345678935', '1998-11-02', DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 1460) * -1, GETDATE())),
('Duygu', 'Şahin', 'duygu.sahin@gmail.com', '05358123456', '12345678936', '2003-04-11', DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 1460) * -1, GETDATE())),
('Onur', 'Eren', 'onur.eren@gmail.com', '05359123456', '12345678937', '2000-01-30', DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 1460) * -1, GETDATE())),
('Ceyda', 'Polat', 'ceyda.polat@yahoo.com', '05360123456', '12345678938', '2002-06-18', DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 1460) * -1, GETDATE())),
('Tolga', 'Öztürk', 'tolga.ozturk@gmail.com', '05361123456', '12345678939', '1997-03-20', DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 1460) * -1, GETDATE())),
('Seda', 'Güler', 'seda.guler@gmail.com', '05362123456', '12345678940', '1996-08-07', DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 1460) * -1, GETDATE())),
('Can', 'Ar', 'can.ar@example.com', '05363123456', '12345678941', '2001-12-25', DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 1460) * -1, GETDATE())),
('Elif', 'Yavuz', 'elif.yavuz@gmail.com', '05364123456', '12345678942', '1999-10-14', DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 1460) * -1, GETDATE())),
('Halil', 'Tekin', 'halil.tekin@hotmail.com', '05365123456', '12345678943', '2000-05-01', DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 1460) * -1, GETDATE())),
('Gizem', 'Şimşek', 'gizem.simsek@gmail.com', '05366123456', '12345678944', '1998-07-28', DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 1460) * -1, GETDATE())),
('Ayhan', 'Işık', 'ayhan.isik@gmail.com', '05367123456', '12345678945', '1997-02-14', DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 1460) * -1, GETDATE())),
('Cansu', 'Aydın', 'cansu.aydin@gmail.com', '05368123456', '12345678946', '2005-03-01', DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 1460) * -1, GETDATE())),
('Okan', 'Kurtuluş', 'okan.kurtulus@gmail.com', '05369123456', '12345678947', '2004-09-17', DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 1460) * -1, GETDATE())),
('Esra', 'Aksoy', 'esra.aksoy@gmail.com', '05370123456', '12345678948', '1996-11-06', DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 1460) * -1, GETDATE())),
('Furkan', 'Çetin', 'furkan.cetin@gmail.com', '05371123456', '12345678949', '2000-08-19', DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 1460) * -1, GETDATE()));


INSERT INTO Students (Name, LastName, Email, Phone, CitizenshipId, BirthDate, RegDate)
VALUES
('Cem', 'Yıldırım', 'cem.yildirim@example.com', '05312345678', '12345678901', '1995-05-10', DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 1460) * -1, GETDATE())),
('Merve', 'Kaya', 'merve.kaya@example.com', '05322345678', '22345678901', '1997-07-15', DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 1460) * -1, GETDATE())),
('Ali', 'Demir', 'ali.demir@example.com', '05332345678', '32345678901', '1998-03-20', DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 1460) * -1, GETDATE())),
('Ayşe', 'Çelik', 'ayse.celik@example.com', '05342345678', '42345678901', '2000-08-25', DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 1460) * -1, GETDATE())),
('Fatma', 'Şahin', 'fatma.sahin@example.com', '05352345678', '52345678901', '1996-12-11', DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 1460) * -1, GETDATE())),
('Eren', 'Aydın', 'eren.aydin@example.com', '05362345678', '62345678901', '1999-04-18', DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 1460) * -1, GETDATE())),
('Zeynep', 'Eren', 'zeynep.eren@example.com', '05372345678', '72345678901', '2001-09-14', DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 1460) * -1, GETDATE())),
('Hüseyin', 'Koç', 'huseyin.koc@example.com', '05382345678', '82345678901', '1993-01-05', DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 1460) * -1, GETDATE())),
('Elif', 'Polat', 'elif.polat@example.com', '05392345678', '92345678901', '1994-02-28', DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 1460) * -1, GETDATE())),
('Burak', 'Can', 'burak.can@example.com', '05412345678', '12445678901', '1992-06-30', DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 1460) * -1, GETDATE())),
('Hatice', 'Aksoy', 'hatice.aksoy@example.com', '05422345678', '22445678901', '1991-11-25', DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 1460) * -1, GETDATE())),
('Gül', 'Yavuz', 'gul.yavuz@example.com', '05432345678', '32445678901', '1998-03-05', DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 1460) * -1, GETDATE())),
('Esra', 'İşık', 'esra.isik@example.com', '05442345678', '42445678901', '1995-07-07', DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 1460) * -1, GETDATE())),
('Deniz', 'Yıldız', 'deniz.yildiz@example.com', '05452345678', '52445678901', '1997-10-21', DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 1460) * -1, GETDATE())),
('Canan', 'Ersoy', 'canan.ersoy@example.com', '05462345678', '62445678901', '2002-05-19', DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 1460) * -1, GETDATE())),
('Okan', 'Tekin', 'okan.tekin@example.com', '05472345678', '72445678901', '1996-09-30', DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 1460) * -1, GETDATE())),
('Buse', 'Arslan', 'buse.arslan@example.com', '05482345678', '82445678901', '2000-04-08', DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 1460) * -1, GETDATE())),
('Ahmet', 'Güler', 'ahmet.guler@example.com', '05492345678', '92445678901', '1994-01-29', DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 1460) * -1, GETDATE())),
('Mert', 'Yılmaz', 'mert.yilmaz@example.com', '05512345678', '12545678901', '1998-12-13', DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 1460) * -1, GETDATE())),
('Melike', 'Kara', 'melike.kara@example.com', '05522345678', '22545678901', '1995-03-27', DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 1460) * -1, GETDATE()));

INSERT INTO Students (Name, LastName, Email, Phone, CitizenshipId, BirthDate, RegDate)
VALUES
('Kemal', 'Yıldız', 'kemal.yildiz@gmail.com', '05532345678', '12555678901', '1990-07-11', DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 1460) * -1, GETDATE())),
('Selin', 'Kurt', 'selin.kurt@gmail.com', '05542345678', '22555678901', '1993-08-20', DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 1460) * -1, GETDATE())),
('Hakan', 'Çelik', 'hakan.celik@gmail.com', '05552345678', '32555678901', '1995-01-15', DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 1460) * -1, GETDATE())),
('Mina', 'Koç', 'mina.koc@gmail.com', '05562345678', '42555678901', '1996-06-25', DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 1460) * -1, GETDATE())),
('Ozan', 'Demir', 'ozan.demir@hotmail.com', '05572345678', '52555678901', '1999-03-18', DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 1460) * -1, GETDATE())),
('Ece', 'Yılmaz', 'ece.yilmaz@hotmail.com', '05582345678', '62555678901', '1994-11-28', DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 1460) * -1, GETDATE())),
('Bora', 'Polat', 'bora.polat@hotmail.com', '05592345678', '72555678901', '1992-02-17', DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 1460) * -1, GETDATE())),
('Melisa', 'Aydın', 'melisa.aydin@hotmail.com', '05612345678', '82555678901', '1993-09-07', DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 1460) * -1, GETDATE())),
('Can', 'Eren', 'can.eren@gmail.com', '05622345678', '92555678901', '1997-04-30', DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 1460) * -1, GETDATE())),
('Ayşegül', 'Kara', 'aysegul.kara@gmail.com', '05632345678', '13555678901', '1991-12-12', DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 1460) * -1, GETDATE())),
('Murat', 'Tekin', 'murat.tekin@gmail.com', '05642345678', '23555678901', '1990-06-22', DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 1460) * -1, GETDATE())),
('Zehra', 'Şahin', 'zehra.sahin@yahoo.com', '05652345678', '33555678901', '1998-08-19', DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 1460) * -1, GETDATE())),
('Burak', 'Arslan', 'burak.arslan@yahoo.com', '05662345678', '43555678901', '1995-05-21', DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 1460) * -1, GETDATE())),
('Elif', 'Yavuz', 'elif.yavuz@yahoo.com', '05672345678', '53555678901', '1993-03-10', DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 1460) * -1, GETDATE())),
('Eren', 'Aksoy', 'eren.aksoy@yahoo.com', '05682345678', '63555678901', '1996-01-08', DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 1460) * -1, GETDATE())),
('Merve', 'Can', 'merve.can@gmail.com', '05692345678', '73555678901', '1997-07-14', DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 1460) * -1, GETDATE())),
('Tuna', 'Yıldırım', 'tuna.yildirim@gmail.com', '05712345678', '83555678901', '1994-05-23', DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 1460) * -1, GETDATE())),
('Deniz', 'Kurt', 'deniz.kurt@gmail.com', '05722345678', '93555678901', '1992-09-11', DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 1460) * -1, GETDATE())),
('Büşra', 'Güler', 'busra.guler@gmail.com', '05732345678', '14555678901', '1995-10-06', DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 1460) * -1, GETDATE())),
('Alper', 'Öztürk', 'alper.ozturk@gmail.com', '05742345678', '24555678901', '1993-02-03', DATEADD(DAY, ABS(CHECKSUM(NEWID()) % 1460) * -1, GETDATE()));
