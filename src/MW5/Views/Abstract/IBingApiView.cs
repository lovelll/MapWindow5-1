﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MW5.Plugins.Mvp;

namespace MW5.Views.Abstract
{
    public interface IBingApiView: IView
    {
        string Key { get; }
    }
}
