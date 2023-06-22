using Composite.Core.Interfaces;

namespace Composite.Core.Implementations;

public class Corporation : BookComposite
{
    public Corporation(ICompositePresenter presenter, string name)
        : base(presenter, name) { }
}

public class Store : BookComposite
{
    public Store(ICompositePresenter presenter, string name)
        : base(presenter, name) { }
}

public class Section : BookComposite
{
    public Section(ICompositePresenter presenter, string name)
        : base(presenter, name) { }
}

public class Set : BookComposite
{
    public Set(ICompositePresenter presenter, string name, params IComponent[] books)
        : base(presenter, name)
    {
        foreach (var book in books)
        {
            Add(book);
        }
    }
}
