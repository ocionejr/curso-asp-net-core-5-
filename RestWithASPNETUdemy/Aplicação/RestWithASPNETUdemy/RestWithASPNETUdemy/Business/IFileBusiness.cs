﻿using Microsoft.AspNetCore.Http;
using RestWithASPNETUdemy.Data.VO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Business
{
    public interface IFileBusiness
    {
        public byte[] GetFile(string filename);
        public Task<FileDetailVO> SaveFileToDIsk(IFormFile file);
        public Task<List<FileDetailVO>> SaveFilesToDIsk(IList<IFormFile> file);

    }
}
