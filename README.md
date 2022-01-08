# Birden fazla input Alani Ekleme

#
    for (var i = 0; i < egitim.GrupSayisi.Length; i++)
    {
        Grup grup = new Grup
        {
            Adet = egitim.GrupNo[i],
            Sayi = egitim.GrupSayisi[i],
            Tarih = egitim.GrupTarihi[i],
            EgitimId = egitim.Id
        };
        _multiInputContext.Grups.Add(grup);
               
    }