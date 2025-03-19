
using abpdcw2;

Id id = new Id();
KontenerNaPlyny kontenerNaPlyny= new KontenerNaPlyny(1,2,3,4,500,"P",id,false);
kontenerNaPlyny.zaladujKontener(100);
// kontenerNaPlyny.zaladujKontener(600);
KontenerChlodniczy kontenerChlodniczy = new KontenerChlodniczy(1, 2, 3, 4, 300, "C", id, "banan", 20);
kontenerChlodniczy.zaladujKontener(100);
KontenerNaGaz kontenerNaGaz=new KontenerNaGaz(3,2,1,4,200,"G",id,1000);
kontenerNaGaz.zaladujKontener(100);
Statek statek = new Statek(100,90,9000);
statek.zaladujKontener(kontenerNaPlyny);
statek.zaladujKontener(kontenerNaGaz);
statek.zaladujKontener(kontenerChlodniczy);
statek.wypiszKontenery();
statek.zdejmijKontener(kontenerNaGaz);
statek.wypiszKontenery();

kontenerNaGaz.wypisz();
kontenerNaGaz.oproznienieLadunku();
kontenerNaGaz.wypisz();