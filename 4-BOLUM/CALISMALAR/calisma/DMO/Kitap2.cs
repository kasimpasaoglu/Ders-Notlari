﻿using System;
using System.Collections.Generic;

namespace calisma.DMO;

public partial class Kitap2
{
    public int Id { get; set; }

    public string? Ad { get; set; }

    public int? Yazarno { get; set; }

    public int? Sayi { get; set; }

    public virtual Yazar? YazarnoNavigation { get; set; }
}