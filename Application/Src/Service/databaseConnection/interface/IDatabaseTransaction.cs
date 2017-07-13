using System;

namespace Service
{
    public interface IDatabaseTransaction : IDisposable
    {

        void Commit();
        void Rollback();

    }
}