﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ZKEACMS.Common.Service
{
    public interface IEventViewerService
    {
        IEnumerable<FileInfo> Get();
        void Delete(string id);
        void DeleteAll();
        string ReadLog(string id);
    }
}
