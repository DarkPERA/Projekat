# Projekat
U pitanju je program koji vrši “Login\register” nekog od korisnika, uglavnom predviđen za administratore. 
Administratori mogu da pretražuju, dodaju i brišu studente i profesore. 
Jedino glavni administrator može da pretražuje, dodaje i briše admine. 
Ukoliko je ulogovani korisnik profesor, dobiće poruku pozdrava, slično važi i za studente. 
Podaci se čuvaju na D particiji. Ukoliko ta particija ne postoji, doće do greške, tako je program napravljen. 
Sve ostale foldere za čuvanje tekstualnih datoteka će program sam da napravi. 
Ukoliko dođe do greške u nekim od tekstualnih datoteka, program će napraviti svoje “default” članove. 
To se neće dogoditi tokom prve inicijalizacije, tek druge i nadalje.

Svi podace se čuvaju u tekstualnim datotekama “username.txt” i u njihovim podrazumevanim folderima. 
Takođe postoji datoteka koja sadrži listu svih “username.txt” datoteka na osnovu koje se vrši pretraga. 

Program prepoznaje da li je ulogovani korisnik admin ili glavni admin i na osnovu toga neke od opcija glavnog menija isključuje. 

Postoje raznorazne zaštite u programu, jedino što se može pogrešiti jeste prilikom upisa ukoliko na neke od polja se unese umesto
pravog imena i prezimena unese lažno ime i prezime ili lažni fakultet što program ne može da zna. 

Defaulti:

Admin:	 Jancic[username]  janko123[password]

Profesor: 	Marko[username] 	marko123[password]

Student: 	Jovan[username] 	jova123[password]
