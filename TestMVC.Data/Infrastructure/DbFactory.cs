namespace TestMVC.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private TestMVCDbContext dbContext;

        public TestMVCDbContext Init()
        {
            return dbContext ?? (dbContext = new TestMVCDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}