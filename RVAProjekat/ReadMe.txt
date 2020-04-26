I Delovi projekta:

	1. Server(Console Application)
	2. Client(WPF Application)
	3. Common(Class Library)


II Paterni u projektu:

	1. Singleton - Obezbedjuje da klasa ima samo jednu instancu i daje globalni pristup toj instanci. Odgovorna za kreiranje i rad sa svojom sopstvenom jedinstvenom instancom.
		1.1. LogHandler klasa.
		1.2. Channel klasa.
		1.3. ServerLogger klasa.

	2. Prototype - Definise mehanizam kako da se pravljenje objekta-duplikata odredjene klase poveri posebnom objektu date klase, koji predstavlja prototipski objekat te klase i koji se može klonirati.
		1.1 Telephone i ShopTelephone klase.

	3. Factory - Prosledjuje se zahtev za kreiranje objekata Factory metodi
		3.1. Channel klasa.

	4. Proxy
		4.1. Channel klasa 

	5. Command - Enkapsulira zahtev za izvrsenjem odredjene operacije u jedan objekat.Umesto da se direktno izvrsi odredjena operacija, kreira se objekat-komanda, koji se potom prosledjuje na izvrsenje.
		5.1. Commands folder i sve klase u njemu.

	6. Strategy - definise grupu algoritama, enkapsulirajuci ih, tako da su medjusobno zamenljivi.Omogucava laku zamenu algoritama tokom izvrsavanja programa
		6.1. Validation klasa koju nasledjuju Telephone,User i Shop klase a koristi Context klasa.

	7. Observer - Omogucuje da se promena sadrzaja u jednom elementu, odmah pojavi i usvim delovima programa koji dati element prikazuju u nekom obliku.
		7.1 MainWindowViewModel klasa koja nasledjuje INotifyPropertyChanged
		7.2 AddUserViewModel klasa koja nasledjuje INotifyPropertyChanged