using System.Text;
using Composite.Core.Interfaces;

namespace Composite.Core.Implementations;

public class ConsoleCompositePresenter : ICompositePresenter
{
    private int indentation = 0;

    public string Display(string name, List<IComponent> children, int count, string type)
    {
        var sb = new StringBuilder();
        AppendHeader(sb, name, count);
        AppendBody(sb, children);
        AppendFooter(sb, type);
        return sb.ToString();
    }

    private void AppendHeader(StringBuilder sb, string name, int count)
    {
        sb.Append(new String('\t', indentation));
        sb.Append(name);
        sb.Append($" ({count} books)");
        sb.Append(Environment.NewLine);
    }

    private void AppendBody(StringBuilder sb, List<IComponent> children)
    {
        indentation++;
        foreach (var child in children)
        {
            sb.Append(new String('\t', indentation));
            sb.Append(child.Display());
            sb.Append(Environment.NewLine);
        }
        indentation--;
    }

    private void AppendFooter(StringBuilder sb, string type)
    {
        sb.Append(new String('\t', indentation));
        sb.Append($"Type: {type}");
        sb.Append(Environment.NewLine);
    }
}
