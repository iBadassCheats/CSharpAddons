    public abstract class Page
    {
        public string Title { get; }

        protected Page(string title)
        {
            Title = title;
        }

        public abstract void Render();
    }

    public static List<Page> PageArray = new();

    PageArray = new()
    {
        new Test()
    };

    public class Test : Menu.Page
    {
        public Test() : base("Basic") { }

        public override void Render()
        {
             // Draw here
        }
    }
