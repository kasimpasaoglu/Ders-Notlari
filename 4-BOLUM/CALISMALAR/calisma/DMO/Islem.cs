using System;
using System.Collections.Generic;

namespace calisma.DMO;

public partial class Islem
{
    public int Islemno { get; set; }

    public int? Ogrno { get; set; }

    public int? Kitapno { get; set; }

    public DateOnly? Atarih { get; set; }

    public DateOnly? Vtarih { get; set; }

    public virtual Kitap? KitapnoNavigation { get; set; }

    public virtual Ogrenci? OgrnoNavigation { get; set; }
}
