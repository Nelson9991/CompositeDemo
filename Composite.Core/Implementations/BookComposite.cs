using System.Text;
using Composite.Core.Interfaces;

namespace Composite.Core.Implementations;

public abstract class BookComposite : IComponent
{
    public BookComposite(ICompositePresenter presenter, string name)
    {
        _presenter = presenter;
        Name = name ?? throw new ArgumentNullException(nameof(name));
    }

    protected readonly List<IComponent> children = new();
    private readonly ICompositePresenter _presenter;

    public string Name { get; }
    public virtual string Type => GetType().Name;

    public virtual void Add(IComponent bookComponent)
    {
        children.Add(bookComponent);
    }

    public virtual string Display()
    {
        return _presenter.Display(Name, children, Count(), Type);
    }

    public virtual int Count()
    {
        return children.Sum(child => child.Count());
    }

    public virtual void Remove(IComponent bookComponent)
    {
        children.Remove(bookComponent);
    }
}
