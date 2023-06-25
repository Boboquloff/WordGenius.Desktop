﻿using System;
using System.CodeDom;
using WordGenius.Helpers;

namespace WordGenius.Desktop.Entities;

public abstract class Auditable: BaseEntity
{
    public DateTime CreateAt { get; set; }

    public DateTime UpdateAt { get; set; }

    public Auditable()
    {
        CreateAt = TimeHelper.GetDateTime();
        UpdateAt = TimeHelper.GetDateTime();
    }
}

