using System;

namespace TestMVC.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        TestMVCDbContext Init();
    }
}