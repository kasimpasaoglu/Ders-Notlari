using System;
using System.Collections.Generic;

namespace calisma.DMO;

public partial class Kitap
{
    public int Kitapno { get; set; }

    public string? Ad { get; set; }

    public int Sayfasayisi { get; set; }

    public int Puan { get; set; }

    public int? Yazarno { get; set; }

    public int Turno { get; set; }

    public virtual ICollection<Islem> Islems { get; set; } = new List<Islem>();

    public virtual Tur TurnoNavigation { get; set; } = null!;

    public virtual Yazar? YazarnoNavigation { get; set; }
}
