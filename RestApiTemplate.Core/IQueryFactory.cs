﻿namespace RestApiTemplate.Core
{
    public interface IQueryFactory
    {
        T ResolveQuery<T>()
            where T : class, IQuery;
    }
}