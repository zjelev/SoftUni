﻿namespace SIS.Http
{

    public interface IHttpServer
    {
        Task StartAsync();

        Task ResetAsync();

        void Stop();
    }
}