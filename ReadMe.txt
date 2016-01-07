Sucelja
=======

SmisaoSucelja
-------------
Sučelja doprinose apstrakciji i omogućavaju slabiju uparenost.
Primjer sortiranja liste objekata klase Osoba koja sadrži
ime osobe i datum njena rođenja.

Mogli bismo upotrijebiti metodu:
  List<T>.Sort()
koja može sortirati samo elemente koji implementiraju ISortable sučelje. 
Zbog toga bi uvjet koji se koristi za sortiranje trebalo ugraditi 
u kod klase Osoba i lista bi uvijek bila sortirana prema tom uvjetu.

Međutim, ako osobe želimo sortirati prema različitim uvjetima, tada
ćemo upotrijebiti:
  List<T>.Sort(IComparer<T>)
koja omogućava sortiranje članova liste prema uvjetu definiranom
u klasi koja implementira IComparer<T> sučelje. To omogućava da
jednostavnom promjenom argumenta metode možemo promijeniti uvjet 
sortiranja, a da pri tome ne mijenjamo kod klase Osoba niti klase List.


DefinicijaImplementacijaSucelja
-------------------------------
Sucelje se definira ključnom riječi interface te sadrži samo deklaracije
metoda, svojstava i događaja.
Tip koji implementira sučelje mora implementirati sve njegove članove
ili je u protivnom tip apstraktan.


VirtualniClanovi
----------------
Ako se u baznoj klasi koja implementira sučelje član ne označi virtualnim,
neće ga se moći pregaziti u iz nje izvedenim klasama.


ImplicitnaExplicitnaPretvorba
-----------------------------
Ako klasa implementira neko sučelje, moguća je implicitna pretvorba objekta
u to sučelje.
Ako klasa implentira više sučelja, moguća je eksplicitna pretvorba iz jednog
u drugo sučelje.


ImplementacijaIstoimenihClanovaIzRazlicitihSucelja
--------------------------------------------------
Primjer kako se implementiraju metode s istim potpisom iz različitih sučelja.


TipskiSigurneImplementacije
---------------------------
Primjer kako se sučelje može implementirati da bude tipski sigurno.


SortIComparable
---------------
Primjer implementacije ISortable sučelja koja omogućava implicitno sortiranje
elemenata, bez eksplicitnog navođenja metode za usporedbu.