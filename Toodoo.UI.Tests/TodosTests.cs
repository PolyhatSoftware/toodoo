using Bunit;
using NUnit.Framework;
using Toodoo.UI.Pages;
using TestContext = Bunit.TestContext;

namespace Toodoo.UI.Tests
{
    [TestFixture]
    public class TodosTests
    {
        private IRenderedComponent<Todos> _cut;
        private TestContext _ctx;

        [SetUp]
        public void Setup()
        {
            _ctx = new TestContext();

            _cut = _ctx.RenderComponent<Todos>();
        }

        [TearDown]
        public void Teardown()
        {
            _ctx.Dispose();
        }
        
        [Test]
        public void TitleIsAsExpected()
        {
            Assert.True(_cut.Markup.Contains("<h1>Todos</h1>"));
        }
        
        [Test]
        public void NewTodoIsDisplayed()
        {
            var newTodoTitle = _cut.Find(TodosPageElements.NewTodoTitleInput);
            newTodoTitle.Change("new todo text");
            var addButton = _cut.Find(TodosPageElements.AddButton);
            addButton.Click();
        
            var todoList = _cut.Find(TodosPageElements.TodoList);
        
            Assert.That(todoList.Children.Length, Is.EqualTo(1));
            Assert.True(todoList.Children[0].InnerHtml.Contains("new todo text"));
            Assert.That(newTodoTitle.Attributes["value"].Value.Length, Is.EqualTo(0));
        }
    }
}