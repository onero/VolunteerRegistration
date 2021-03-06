﻿namespace VRBDALTests
{
    public interface IRepositoryTest
    {
        void CreateOne();

        void GetAll();

        void GetOneByExistingId();

        void NotGetOneByNonExistingId();

        void GetAllByExistingIds();

        void NotGetAllByNonExistingIds();

        void DeleteByExistingId();

        void NotDeleteByNonExistingId();
        
    }
}