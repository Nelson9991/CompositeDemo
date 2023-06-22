using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Composite.Core.Interfaces;

namespace Composite.Core.Implementations;

public class WebCompositePresenter : ICompositePresenter
{
    public string Display(string name, List<IComponent> children, int count, string type)
    {
        var sb = new StringBuilder();
        sb.Append("<section class=\"card\">");
        AppendHeader(sb, name, count);
        AppendBody(sb, children);
        AppendFooter(sb, type);
        sb.Append("</section>");
        return sb.ToString();
    }

    private void AppendHeader(StringBuilder sb, string name, int count)
    {
        sb.Append($"<h3 class=\"card-header\">");
        sb.Append(name);
        sb.Append($"<span class=\"badge badge-secondary float-right\">{count} books</span>");
        sb.Append($"</h3>");
    }

    private void AppendBody(StringBuilder sb, List<IComponent> children)
    {
        sb.Append($"<ul class=\"list-group list-group-flush\">");
        children.ForEach(child =>
        {
            sb.Append($"<li class=\"list-group-item\">");
            sb.Append(child.Display());
            sb.Append("</li>");
        });
        sb.Append("</ul>");
    }

    private void AppendFooter(StringBuilder sb, string type)
    {
        sb.Append("<div class=\"card-footer text-muted\">");
        sb.Append($"<small class=\"text-muted text-right\">{type}</small>");
        sb.Append("</div>");
    }
}
