using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Core.Interfaces;

public interface IComponent
{
    void Add(IComponent component);
    void Remove(IComponent component);
    string Display();
    int Count();
    string Type { get; }
}
