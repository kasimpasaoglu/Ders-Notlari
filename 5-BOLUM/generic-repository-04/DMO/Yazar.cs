﻿using System;
using System.Collections.Generic;

namespace generic_repository_04.DMO;

public partial class Yazar
{
    public int Yazarno { get; set; }

    public string? Ad { get; set; }

    public string? Soyad { get; set; }

    public virtual ICollection<Kitap> Kitaps { get; set; } = new List<Kitap>();
}