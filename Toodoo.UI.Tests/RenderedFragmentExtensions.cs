using AngleSharp.Dom;
using Bunit;
using Toodoo.UI.Pages;

namespace Toodoo.UI.Tests
{
    public static class RenderedFragmentExtensions
    {
        public static IElement Find(this IRenderedFragment renderedFragment, MyElement cssSelector)
        {
            return renderedFragment.Find($".{cssSelector}");
        }
    }
}