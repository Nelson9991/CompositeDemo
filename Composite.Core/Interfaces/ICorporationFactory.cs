using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Composite.Core.Implementations;

namespace Composite.Core.Interfaces;

public interface ICorporationFactory
{
    Corporation Create();
}
