using System.Text;
using Composite.Core.Interfaces;

namespace Composite.Core.Implementations;

public class ConsoleCompositePresenter : ICompositePresenter
{
    private int level = 0;

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
        if (level > 0)
        {
            sb.Append(new String('-', level * 2));
            sb.Append(" ");
        }
        sb.Append($"{name} ({count} books)");
        sb.Append(Environment.NewLine);
    }

    private void AppendBody(StringBuilder sb, List<IComponent> children)
    {
        level++;
        foreach (var child in children)
        {
            sb.Append(new String(' ', level * 2));
            sb.Append(child.Display());
            sb.Append(Environment.NewLine);
        }
        level--;
    }

    private void AppendFooter(StringBuilder sb, string type)
    {
        if (level > 0)
        {
            sb.Append(new String('-', level * 2));
            sb.Append(" ");
        }
        sb.Append($"Type: {type}");
        sb.Append(Environment.NewLine);
        sb.Append(Environment.NewLine); // Añadimos un salto de línea adicional para separar mejor las secciones
    }
}
