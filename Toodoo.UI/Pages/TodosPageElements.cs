namespace Toodoo.UI.Pages
{
    public static class TodosPageElements
    {
        public static readonly MyElement AddButton = new MyElement("add-new-todo");
        public static readonly MyElement NewTodoTitleInput = new MyElement("new-todo-title");
        public static readonly MyElement TodoList = new MyElement("todo-list");
    }

    public class MyElement
    {
        private string Selector { get; }

        public MyElement(string selector)
        {
            Selector = selector;
        }

        public override string ToString()
        {
            return Selector;
        }
    }
}