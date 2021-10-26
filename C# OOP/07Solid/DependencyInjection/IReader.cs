using System;
using System.Collections.Generic;

namespace DependencyInjection
{
    public interface IReader
    {
        List<Document> Read();
    }
}
