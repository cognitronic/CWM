﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IdeaSeed.Core;
using CWM.Core.Domain.Interfaces;

namespace CWM.Core.Domain
{
    public class ApplicationView : IApplicationView
    {
        public virtual int ID { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual string Path { get; set; }
        public virtual AccessLevels AccessLevel { get; set; }
    }
}
