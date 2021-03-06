﻿namespace SnelStart.B2B.V2.Client.Operations
{
    /// <summary>
    /// Een enumeratie van grootboekfuncties.
    /// </summary>
    public enum GrootboekFunctieModel
    {
        Diversen = 0,
        DagboekKas = 1,
        DagboekBank = 2,
        DagboekGiro = 3,
        DagboekVerkoop = 4,
        DagboekInkoop = 5,
        DagboekMemoriaal = 7,
        DagboekBalans = 8,
        VerkopenOmzetOnbelastVerlegd = 10,
        VerkopenOmzetLaag = 11,
        VerkopenOmzetHoog = 12,
        VerkopenOmzetOverig = 13,
        VerkopenBtwVrij = 15,
        BtwAfteDragenLaag = 21,
        BtwAfTeDragenHoog = 22,
        BtwAfTeDragenOverig = 23,
        BtwAfTeDragenVerlegdVerkopen = 24,
        BtwTeVorderenVerlegd = 25,
        BtwAfteDragenLaagGlobalisatie = 26,
        BtwAfTeDragenHoogGlobalisatie = 27,
        BtwAfTeDragenOverigGlobalisatie = 28,
        InkopenKostenAlleBtwTarieven = 30,
        InkopenKostenLaag = 31,
        InkopenKostenHoog = 32,
        InkopenKostenOverig = 33,
        InkopenVraagPosten = 34,
        BtwTeVorderenLaag = 41,
        BtwTeVorderenHoog = 42,
        BtwTeVorderenOverig = 43,
        BtwAfTeDragenVerlegdInkopen = 44,
        BtwTeVorderenVerlegdInkopen = 45,
        InkopenImportBinnenEUlaag = 61,
        InkopenImportBinnenEUhoog = 62,
        InkopenImportBinnenEUoverig = 63,
        InkopenImportBuitenEUlaag = 71,
        InkopenImportBuitenEUhoog = 72,
        InkopenImportBuitenEUoverig = 73,
        VerkopenExportBinnenEU = 80,
        VerkopenExportBuitenEU = 81,
        OninbareVorderingen = 82,
        HerrekeningCorrecties = 83,
        InstallatieTeleverkoopBinnenEUgeen = 84,
        BpmVerkopen = 85,
        BpmInkopen = 86,
        BpmVoorraad = 87,
        DienstverleningBinnenEU = 88,
        VerkoopGlobalisatieLaag = 91,
        VerkoopGlobalisatieHoog = 92,
        VerkoopGlobalisatieOverig = 93,
        InkoopGlobalisatieLaag = 94,
        InkoopGlobalisatieHoog = 95,
        InkoopGlobalisatieOverig = 96,
        BtwGlobalisatie = 97,
        KredietbeperkingVerkopen = 100,
        KredietbeperkingInkopen = 101,
        Betalingskorting = 102,
        TussenrekeningBetalingen = 110,
        OnbekendeBetalingen = 111,
        Kruisposten = 112,
        ContanteBetaling = 120,
        ElectronischeBetaling = 121,
        Winstboeking = 130
    }
}
