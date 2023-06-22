using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Core.Interfaces;

public interface ICompositePresenter
{
    string Display(string name, List<IComponent> children, int count, string type);
}
