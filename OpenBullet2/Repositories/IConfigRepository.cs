﻿using OpenBullet2.Models.Configs;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace OpenBullet2.Repositories
{
    public interface IConfigRepository
    {
        Task<Config> Create();
        void Delete(Config config);
        Task<Config> Get(string id);
        Task<List<Config>> GetAll();
        Task Save(Config config);
        Task Upload(Stream stream);
    }
}
